using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class PersonaAD
    {
        public PersonaAD()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBaseDatos"].ToString();
        }
        private string CadenaConexion = string.Empty;
       
        //Metodo para agregar personas
         public bool AgregarPersona(Persona persona)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            bool RegistroExitoso = false;
            using (conexion = new SqlConnection(CadenaConexion))
            {
                 string sentencia = "INSERT INTO Persona (Nombre, PrimerApellido,SegundoApellido) " +
                                 "VALUES (@Nombre, @PrimerApellido,@SegundoApellido)";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;
                comando.Parameters.AddWithValue("@Nombre", persona.Nombre);
                comando.Parameters.AddWithValue("@PrimerApellido", persona.PrimerApellido);
                comando.Parameters.AddWithValue("@SegundoApellido", persona.SegundoApellido);
                comando.Connection.Open();
                RegistroExitoso = comando.ExecuteNonQuery() > 0;
            }    
            return RegistroExitoso;
        }

        //Metodo para Obtener todas las personas
        public List<Persona> ObtenerTodasLasPersonas()
        {  
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            List<Persona> listaPersonas = new List<Persona>();
            using (conexion = new SqlConnection(CadenaConexion))
            {
                string sentencia = "SELECT Id, Nombre, PrimerApellido, SegundoApellido FROM Persona";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;
                comando.Connection.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Persona persona = new Persona
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        PrimerApellido = reader["PrimerApellido"].ToString(),
                        SegundoApellido = reader["SegundoApellido"].ToString()
                    };
                    listaPersonas.Add(persona);
                }
            }
            return listaPersonas;
        }
    }
}
