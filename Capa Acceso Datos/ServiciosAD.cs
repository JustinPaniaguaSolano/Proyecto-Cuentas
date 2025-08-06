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
    public class ServiciosAD
    {
        public ServiciosAD()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBaseDatos"].ToString();
        }
        private string CadenaConexion =string.Empty;

        //Metodo para agregar un servicio
        public bool AgregarServicio(Servicios servicio)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            bool RegistroExitoso = false;
            using (conexion = new SqlConnection(CadenaConexion))
            {
                string sentencia = "INSERT INTO Servicios (Nombre, Monto, Fecha,Estado) VALUES (@Nombre, @Monto,@Fecha,@Estado)";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;
                comando.Parameters.AddWithValue("@Nombre",servicio.Nombre);
                comando.Parameters.AddWithValue("@Monto", servicio.Monto);
                comando.Parameters.AddWithValue("@Fecha", servicio.Fecha);
                comando.Parameters.AddWithValue("@Estado", servicio.Estado);

                comando.Connection.Open();
                RegistroExitoso = comando.ExecuteNonQuery() > 0;
            }
            return RegistroExitoso;
        }
        //Metodo para obtener todos los servicios
        public List<Servicios> ObtenerTodosLosServicios()
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Servicios> listaServicios = new List<Servicios>();
            using (conexion = new SqlConnection(CadenaConexion))
            {
                string sentencia = "SELECT Id, Nombre, Monto, Fecha, Estado FROM Servicios";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;
                comando.Connection.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Servicios servicio = new Servicios
                    {
                        Id = Convert.ToInt32(lector["Id"]),
                        Nombre = lector["Nombre"].ToString(),
                        Monto = Convert.ToDecimal(lector["Monto"]),
                        Fecha = Convert.ToDateTime(lector["Fecha"]),
                        Estado = Convert.ToBoolean(lector["Estado"])
                    };
                    listaServicios.Add(servicio);
                }
            }
            return listaServicios;
        }
        //Metodo para obtener solamente los servicios pagados
        public List<Servicios>ObtenerServiosPagados()
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Servicios> listaServicios = new List<Servicios>();
            using (conexion = new SqlConnection(CadenaConexion))
            {
                string sentencia = "SELECT Id, Nombre, Monto, Fecha, Estado FROM Servicios WHERE Estado = 1";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;
                comando.Connection.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Servicios servicio = new Servicios
                    {
                        Id = Convert.ToInt32(lector["Id"]),
                        Nombre = lector["Nombre"].ToString(),
                        Monto = Convert.ToDecimal(lector["Monto"]),
                        Fecha = Convert.ToDateTime(lector["Fecha"]),
                        Estado = Convert.ToBoolean(lector["Estado"])
                    };
                    listaServicios.Add(servicio);
                }
            }
            return listaServicios;
        }
        //Metodo para obtener solamente los servicios pendientes
        public List<Servicios> ObtenerServiciosPendientes()
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Servicios> listaServicios = new List<Servicios>();
            using (conexion = new SqlConnection(CadenaConexion))
            {
                string sentencia = "SELECT Id, Nombre, Monto, Fecha, Estado FROM Servicios WHERE Estado = 0";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;
                comando.Connection.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Servicios servicio = new Servicios
                    {
                        Id = Convert.ToInt32(lector["Id"]),
                        Nombre = lector["Nombre"].ToString(),
                        Monto = Convert.ToDecimal(lector["Monto"]),
                        Fecha = Convert.ToDateTime(lector["Fecha"]),
                        Estado = Convert.ToBoolean(lector["Estado"])
                    };
                    listaServicios.Add(servicio);
                }
            }
            return listaServicios;
        }

        //Metodo para actualizar el estado del servicio
        public bool ActualizarEstadoServicio(int idServicio, bool nuevoEstado)
        {
            bool actualizado = false;
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                string sentencia = "UPDATE Servicios SET Estado = @Estado WHERE Id = @Id";
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                comando.Parameters.AddWithValue("@Estado", nuevoEstado);
                comando.Parameters.AddWithValue("@Id", idServicio);
                conexion.Open();
                actualizado = comando.ExecuteNonQuery() > 0;
            }
            return actualizado;
        }
        //Clase para tener los resultados
        public class ResultadoMonto
        {
            public decimal Total { get; set; }
            public decimal Mitad { get; set; }
        }
        //Metodo para obtener los servios por mes
        public ResultadoMonto ObtenerMontosServiciosMes(int mes, int anio)
        {
            ResultadoMonto resultado = new ResultadoMonto();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                string consulta = @"SELECT SUM(Monto) AS TotalMes
                            FROM Servicios
                            WHERE YEAR(Fecha) = @anio AND MONTH(Fecha) = @mes";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@anio", anio);
                comando.Parameters.AddWithValue("@mes", mes);

                conexion.Open();
                object valor = comando.ExecuteScalar();
                if (valor != DBNull.Value)
                {
                    decimal total = Convert.ToDecimal(valor);
                    resultado.Total = total;
                    resultado.Mitad = total / 2;
                }
            }
            return resultado;
        }

    }
}
