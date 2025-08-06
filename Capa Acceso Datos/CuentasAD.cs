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
    public class CuentasAD
    {
        public CuentasAD()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBaseDatos"].ToString();
        }
        private string CadenaConexion = string.Empty;
       
        //Metodo para agregar una cuenta
        public bool AgregarCuenta(Cuentas cuenta)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            bool RegistroExitoso = false;
            using (conexion = new SqlConnection(CadenaConexion))
                {
                string sentencia = "INSERT INTO Cuentas (Nombre, Monto) VALUES (@Nombre, @Monto)";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;
                comando.Parameters.AddWithValue("@Nombre", cuenta.Nombre);
                comando.Parameters.AddWithValue("@Monto", cuenta.Monto);
                comando.Connection.Open();
                RegistroExitoso = comando.ExecuteNonQuery() > 0;
            }
            return RegistroExitoso;
        }
        //Metodo para obtener todas las cuentas
        public List<Cuentas> ObtenerTodasLasCuentas()
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            List<CapaEntidades.Cuentas> listaCuentas = new List<CapaEntidades.Cuentas>();
            using (conexion = new SqlConnection(CadenaConexion))
            {
                string sentencia = "SELECT Id, Nombre, Monto FROM Cuentas";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;
                comando.Connection.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    CapaEntidades.Cuentas cuenta = new CapaEntidades.Cuentas
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        Monto = Convert.ToDecimal(reader["Monto"])
                    };
                    listaCuentas.Add(cuenta);
                }
            }
            return listaCuentas;
        }
        //Metodo para actualizar el saldo de la cuenta
        public void ActualizarSaldo(int cuentaId, decimal nuevoSaldo)
        {

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                string query = "UPDATE Cuentas SET Monto = @Monto WHERE Id = @Id";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Monto", nuevoSaldo);
                comando.Parameters.AddWithValue("@Id", cuentaId);
                comando.ExecuteNonQuery();
            }
        }
        //Metodo para Obtener la cuenta por medio del ID
        public Cuentas ObtenerCuentaPorId(int idCuenta)
        {
            Cuentas cuenta = null;
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                string query = "SELECT Id, Nombre, Monto FROM Cuentas WHERE Id = @Id";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Id", idCuenta);
                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    cuenta = new Cuentas
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Monto = reader.GetDecimal(2)
                    };
                }
            }
            return cuenta;
        }
    }
}
