using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaAccesoDatos.ServiciosAD;

namespace CapaLogicaNegocio
{
    public class ServiciosN
    {
        //Metodo para agregar un servicio
        public bool AgregarServicio(Servicios servicio)
        {
            ServiciosAD serviciosAD = new ServiciosAD();
            return serviciosAD.AgregarServicio(servicio);
        }
        
        //Metodo para obtener todos los servicios
        public List<Servicios> ObtenerTodosLosServicios()
        {
            ServiciosAD serviciosAD = new ServiciosAD();
            return serviciosAD.ObtenerTodosLosServicios();
        }

        //Metodo para obtener los Servicios pendientes
        public List<Servicios> ObtenerServiosPendientes()
        {
            ServiciosAD serviciosAD = new ServiciosAD();
            return serviciosAD.ObtenerServiciosPendientes();
        }

        //Metodo para obtener los servicios pagados
        public List<Servicios> ObtenerServiciosPagados()
        {
            ServiciosAD serviciosAD = new ServiciosAD();
            return serviciosAD.ObtenerServiosPagados();
        }

        //Metodo para actualizar el estado del servicio
        public bool ActualizarServicio(int idServicio, bool nuevoEstado)
        {
            ServiciosAD serviciosAD = new ServiciosAD();
            return serviciosAD.ActualizarEstadoServicio(idServicio, nuevoEstado);
        }

        //Metodo para obtener los servicios por mes
        public ResultadoMonto ObtenerMontosServiciosMes(int mes, int anio)
        {
            ServiciosAD serviciosAD = new ServiciosAD();
            return serviciosAD.ObtenerMontosServiciosMes(mes, anio);
        }
    }

}
