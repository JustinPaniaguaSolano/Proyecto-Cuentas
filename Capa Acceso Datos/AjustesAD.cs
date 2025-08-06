using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Acceso_Datos
{
    public class AjustesAD
    {
        public AjustesAD() 
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBaseDatos"].ToString();

        }
        private string CadenaConexion = string.Empty;

        //Metodo Agregar Ajuste
        public bool AgregarAjuste(Ajustes ajuste)
        {
            bool RegistroExitoso = false;

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();

                // 1. Obtener saldo actual de la cuenta
                decimal saldoActual = 0;
                string consultaSaldo = "SELECT Monto FROM Cuentas WHERE Id = @CuentaId";
                using (SqlCommand cmdSaldo = new SqlCommand(consultaSaldo, conexion))
                {
                    cmdSaldo.Parameters.AddWithValue("@CuentaId", ajuste.IdCuenta.Id);
                    object resultado = cmdSaldo.ExecuteScalar();
                    saldoActual = resultado != DBNull.Value ? Convert.ToDecimal(resultado) : 0m;
                }

                // 2. Guardar saldo anterior en 'Cantidad'
                decimal saldoAnterior = saldoActual;

                // 3. Calcular nuevo saldo según el movimiento
                if (ajuste.Movimiento) // Entrada
                {
                    saldoActual += ajuste.Monto;
                }
                else // Salida
                {
                    saldoActual -= ajuste.Monto;
                }

                // 4. Insertar registro en Ajustes, usando 'Cantidad' para saldo anterior
                string insertarAjuste = @"
                                         INSERT INTO Ajustes (Fecha, Descripcion, CuentaId, Monto, Movimiento, Saldo, Cantidad)
                                        VALUES (@Fecha, @Descripcion, @CuentaId, @Monto, @Movimiento, @Saldo, @Cantidad)";

                using (SqlCommand cmdInsertar = new SqlCommand(insertarAjuste, conexion))
                {
                    cmdInsertar.Parameters.AddWithValue("@Fecha", ajuste.Fecha);
                    cmdInsertar.Parameters.AddWithValue("@Descripcion", ajuste.Descripcion);
                    cmdInsertar.Parameters.AddWithValue("@CuentaId", ajuste.IdCuenta.Id);
                    cmdInsertar.Parameters.AddWithValue("@Monto", ajuste.Monto);
                    cmdInsertar.Parameters.AddWithValue("@Movimiento", ajuste.Movimiento);
                    cmdInsertar.Parameters.AddWithValue("@Saldo", saldoActual);
                    cmdInsertar.Parameters.AddWithValue("@Cantidad", saldoAnterior);

                    RegistroExitoso = cmdInsertar.ExecuteNonQuery() > 0;
                }

                // 5. Actualizar saldo en la cuenta
                string actualizarCuenta = "UPDATE Cuentas SET Monto = @NuevoSaldo WHERE Id = @CuentaId";
                using (SqlCommand cmdActualizar = new SqlCommand(actualizarCuenta, conexion))
                {
                    cmdActualizar.Parameters.AddWithValue("@NuevoSaldo", saldoActual);
                    cmdActualizar.Parameters.AddWithValue("@CuentaId", ajuste.IdCuenta.Id);
                    cmdActualizar.ExecuteNonQuery();
                }
            }
            return RegistroExitoso;
        }
        //Metodo para Obtener todos los ajustes
        public List<Ajustes> ObtenerTodosLosAjustes()
        {
            List<Ajustes> listaAjustes = new List<Ajustes>();

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                string sentencia = @"
            SELECT 
                A.Id, A.Fecha, A.Descripcion, A.CuentaId, 
                C.Nombre AS NombreCuenta, 
                A.Monto, A.Movimiento, 
                A.Saldo,
                A.Cantidad  -- Aquí está saldo anterior
            FROM Ajustes A
            INNER JOIN Cuentas C ON A.CuentaId = C.Id";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ajustes ajustes = new Ajustes
                            {
                                Id = reader.GetInt32(0),
                                Fecha = reader.GetDateTime(1),
                                Descripcion = reader.GetString(2),
                                IdCuenta = new Cuentas
                                {
                                    Id = reader.GetInt32(3),
                                    Nombre = reader.GetString(4)
                                },
                                Monto = reader.GetDecimal(5),
                                Movimiento = reader.GetBoolean(6),
                                Saldo = reader.GetDecimal(7),
                            };
                            listaAjustes.Add(ajustes);
                        }
                    }
                }
            }
            return listaAjustes;
        }

        //Metodo para obtener los Ajustes de acuerdo al mes
        public List<Ajustes> ObtenerAjustesPorMes(int mes, int anio)
        {
            List<Ajustes> listaAjustes = new List<Ajustes>();

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                string sentencia = @"
            SELECT 
                A.Id, A.Fecha, A.Descripcion, A.CuentaId, C.Nombre AS NombreCuenta,
                A.Monto, A.Movimiento,
                A.Saldo,      -- saldo después del ajuste
                A.Cantidad    -- saldo anterior al ajuste
            FROM Ajustes A
            INNER JOIN Cuentas C ON A.CuentaId = C.Id
            WHERE MONTH(A.Fecha) = @Mes AND YEAR(A.Fecha) = @Anio";

                SqlCommand comando = new SqlCommand(sentencia, conexion);
                comando.Parameters.AddWithValue("@Mes", mes);
                comando.Parameters.AddWithValue("@Anio", anio);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Ajustes ajuste = new Ajustes
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Fecha = Convert.ToDateTime(reader["Fecha"]),
                        Descripcion = reader["Descripcion"].ToString(),

                        IdCuenta = new Cuentas
                        {
                            Id = Convert.ToInt32(reader["CuentaId"]),
                            Nombre = reader["NombreCuenta"].ToString()
                        },

                        Monto = Convert.ToDecimal(reader["Monto"]),
                        Movimiento = Convert.ToBoolean(reader["Movimiento"]),
                        Saldo = Convert.ToDecimal(reader["Saldo"]),         // saldo después del ajuste

                    };
                    listaAjustes.Add(ajuste);
                }
            }
            return listaAjustes;
        }

    }
}

