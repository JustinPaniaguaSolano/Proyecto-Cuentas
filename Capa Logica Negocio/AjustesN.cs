using Capa_Acceso_Datos;
using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class AjustesN
    {
        //Metodo para Agregar ajustes
        public bool AgregarAjustes(Ajustes ajustes)
        {
            bool RegistroExitoso = false;
            AjustesAD ajustesAD = new AjustesAD();
            List<Ajustes> listaAjustes = ajustesAD.ObtenerTodosLosAjustes();

            CuentasN cuentasN = new CuentasN();
            Cuentas cuentas = cuentasN.ObtenerCuentaPorID(ajustes.IdCuenta.Id);

            //Validacion del monto 
            if (!ajustes.Movimiento && ajustes.Monto > cuentas.Monto)
            {
                return false;
            }
            //validar guardar ajuste
            bool Exitoso = ajustesAD.AgregarAjuste(ajustes);
            if (Exitoso)
            {
                if (ajustes.Movimiento)
                {
                    cuentas.Monto += ajustes.Monto;//Entrada
                }
                else
                {
                    cuentas.Monto -= ajustes.Monto;//Salida
                }
                cuentasN.ActualizarSaldo(cuentas.Id, cuentas.Monto);//actualizar el saldo 
            }
            return Exitoso;
        }

        //Metodo para obtener todos los Ajustes
        public List<Ajustes> ObtenerTodosLosAjustes()
        {
            AjustesAD ajustesAD = new AjustesAD();
            List<Ajustes> listaAjustes = ajustesAD.ObtenerTodosLosAjustes();
            return ajustesAD.ObtenerTodosLosAjustes();

        }
        //Metodo para obtener los ajustes por mes
        public List<Ajustes> ObtenerAjustesPorMes(int mes, int ano)
        {
            AjustesAD ajustesAD = new AjustesAD();
            List<Ajustes> listaAjustes = ajustesAD.ObtenerTodosLosAjustes();
            return ajustesAD.ObtenerAjustesPorMes(mes, ano);
        }
    }
}

    

