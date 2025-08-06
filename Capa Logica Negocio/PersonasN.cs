using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class PersonasN
    {
        //Metodo para agregar una persona
        public bool AgregarPersona(Persona persona)
        {
            bool RegistroExitoso = false;
            PersonaAD personasAD = new PersonaAD();
            List<Persona> listaPersonas = personasAD.ObtenerTodasLasPersonas();
            if (listaPersonas.Any(p => p.Nombre == persona.Nombre && p.PrimerApellido == persona.SegundoApellido))
            {
                return false; // Persona ya existe
            }
            else
            {
                return personasAD.AgregarPersona(persona);
            }
        }
        //Metodo para obtener todas las personas
        public List<Persona> ObtenerTodasLasPersonas()
        {
            PersonaAD personasAD = new PersonaAD();
            List<Persona> listaPersonas = personasAD.ObtenerTodasLasPersonas();
            return listaPersonas;
        
        }
    }   
}
