using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica_Negocio
{
    public class CobrarN
    {
        //Metodo para Agregar un cobro
        public bool AgregarCuentaPorCobrar(Cobrar cobrar)
        {
            bool RegistroExitoso = false;
            CobrarAD cobrarAD = new CobrarAD();
            List<Cobrar> listaAjustes = cobrarAD.ObtenerTodosLosCobros();
            return cobrarAD.AgregarCobro(cobrar);
            
        }

        //Metodo para obtener todas las cuentas por cobrar
        public List<Cobrar> ObtenerTodasLasCuentasPorCobrar()
        {
            CobrarAD cobrarAD = new CobrarAD();
            List<Cobrar> listaCuentasPorCobrar = cobrarAD.ObtenerTodosLosCobros();
            return listaCuentasPorCobrar;
        }

        //Metodo para obtener las cuentas por cobrar por persona
        public List<Cobrar> ObtenerCuentasPorCobrarPorPersona(int personaId)
        {
            CobrarAD cobrarAD = new CobrarAD();
            List<Cobrar> listaCuentasPorCobrar = cobrarAD.ObtenerCobrosPorPersona(personaId);
            return listaCuentasPorCobrar;
        }
    }
}
