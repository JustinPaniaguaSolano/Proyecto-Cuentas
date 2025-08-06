using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class CobrarAD
    {
        public CobrarAD()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBaseDatos"].ToString();

        }
        private string CadenaConexion = string.Empty;
        //Metodo para agregar Cobro
        public bool AgregarCobro(Cobrar cobrar)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            bool RegistroExitoso = false;

            using (conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();
                comando.Connection = conexion;
                comando.Transaction = transaccion;

                try
                {
                    // 1. Obtener saldo actual
                    decimal saldoActual = 0;
                    comando.CommandText = "SELECT Saldo FROM CuentasPorCobrar WHERE PersonaId = @PersonaIdSaldo";
                    comando.Parameters.AddWithValue("@PersonaIdSaldo", cobrar.Persona.Id);
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                        saldoActual = Convert.ToDecimal(resultado);
                    else
                    {
                        // Si no existe saldo para esta persona, insertar en CuentasPorCobrar
                        comando.Parameters.Clear();
                        comando.CommandText = "INSERT INTO CuentasPorCobrar (PersonaId, Saldo) VALUES (@PersonaId, 0)";
                        comando.Parameters.AddWithValue("@PersonaId", cobrar.Persona.Id);
                        comando.ExecuteNonQuery();
                        saldoActual = 0;
                    }

                    comando.Parameters.Clear();

                    // 2. Calcular nuevo saldo
                    decimal nuevoSaldo = cobrar.Movimiento
                        ? saldoActual + cobrar.Monto   // préstamo
                        : saldoActual - cobrar.Monto;  // abono

                    if (nuevoSaldo < 0)
                    {
                        transaccion.Rollback();
                        return false;
                    }

                    // 3. Insertar el cobro
                    string sentencia = "INSERT INTO Cobrar (PersonaId, Fecha, Monto, Descripcion, Movimiento, Saldo) " +
                                       "VALUES (@PersonaId, @Fecha, @Monto, @Descripcion, @Movimiento, @Saldo)";
                    comando.CommandText = sentencia;

                    comando.Parameters.AddWithValue("@PersonaId", cobrar.Persona.Id);
                    comando.Parameters.AddWithValue("@Fecha", cobrar.Fecha);
                    comando.Parameters.AddWithValue("@Monto", cobrar.Monto);
                    comando.Parameters.AddWithValue("@Descripcion", cobrar.Descripcion);
                    comando.Parameters.AddWithValue("@Movimiento", cobrar.Movimiento);
                    comando.Parameters.AddWithValue("@Saldo", nuevoSaldo);

                    int resultadoInsercion = comando.ExecuteNonQuery();
                    comando.Parameters.Clear();

                    if (resultadoInsercion <= 0)
                    {
                        transaccion.Rollback();
                        return false;
                    }

                    // 4. Actualizar saldo acumulado en CuentasPorCobrar
                    comando.CommandText = "UPDATE CuentasPorCobrar SET Saldo = @NuevoSaldo WHERE PersonaId = @PersonaId";
                    comando.Parameters.AddWithValue("@NuevoSaldo", nuevoSaldo);
                    comando.Parameters.AddWithValue("@PersonaId", cobrar.Persona.Id);

                    int resultadoUpdate = comando.ExecuteNonQuery();

                    if (resultadoUpdate <= 0)
                    {
                        transaccion.Rollback();
                        return false;
                    }

                    transaccion.Commit();
                    RegistroExitoso = true;
                }
                catch (Exception)
                {
                    transaccion.Rollback();
                }
            }

            return RegistroExitoso;
        }
        //Metodo para obtener todos los cobros
        public List<Cobrar> ObtenerTodosLosCobros()
        {
            List<Cobrar> listaCobros = new List<Cobrar>();

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                string sentencia = @"
            SELECT 
                c.Id, c.PersonaId, c.Fecha, c.Monto, c.Descripcion, c.Movimiento, c.Saldo,
                p.Nombre, p.PrimerApellido, p.SegundoApellido
            FROM Cobrar c
            INNER JOIN Persona p ON c.PersonaId = p.Id";

                SqlCommand comando = new SqlCommand(sentencia, conexion);
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Cobrar cobrar = new Cobrar
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Persona = new Persona
                        {
                            Id = Convert.ToInt32(reader["PersonaId"]),
                            Nombre = reader["Nombre"].ToString(),
                            PrimerApellido = reader["PrimerApellido"].ToString(),
                            SegundoApellido = reader["SegundoApellido"].ToString()
                        },
                        Fecha = Convert.ToDateTime(reader["Fecha"]),
                        Monto = Convert.ToDecimal(reader["Monto"]),
                        Descripcion = reader["Descripcion"].ToString(),
                        Movimiento = Convert.ToBoolean(reader["Movimiento"]),
                        Saldo = Convert.ToDecimal(reader["Saldo"]),
                    };
                    listaCobros.Add(cobrar);
                }
            }
            return listaCobros;
        }
        //Metodo para obtener los cobros de acuerdo al ID de la persona
        public List<Cobrar> ObtenerCobrosPorPersona(int personaId)
        {
            List<Cobrar> listaCobros = new List<Cobrar>();

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                string sentencia = "SELECT Id, PersonaId, Fecha, Monto, Descripcion, Movimiento, Saldo FROM Cobrar WHERE PersonaId = @PersonaId";
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                comando.Parameters.AddWithValue("@PersonaId", personaId);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Cobrar cobrar = new Cobrar
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Persona = new Persona { Id = Convert.ToInt32(reader["PersonaId"]) },
                        Fecha = Convert.ToDateTime(reader["Fecha"]),
                        Monto = Convert.ToDecimal(reader["Monto"]),
                        Descripcion = reader["Descripcion"].ToString(),
                        Movimiento = Convert.ToBoolean(reader["Movimiento"]),
                        Saldo = Convert.ToDecimal(reader["Saldo"]),
                    };
                    listaCobros.Add(cobrar);
                }
            }

            return listaCobros;
        }

    }
}
