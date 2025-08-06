using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class CuentasN
    {
        //Metodo para agregar una cuenta
        public bool AgregarCuenta(Cuentas cuenta)
        {
            bool RegistroExitoso = false;
            CuentasAD cuentasAD = new CuentasAD();
            List<Cuentas> listaCuentas = cuentasAD.ObtenerTodasLasCuentas();
            if (listaCuentas.Any(c => c.Nombre == cuenta.Nombre))
            {
                return false; // Cuenta ya existe
            }
            else
            {
                return cuentasAD.AgregarCuenta(cuenta);
            }
        }

        //Metodo para obtener todas las cuentas
        public List<Cuentas> ObtenerTodasLasCuentas()
        {
            CuentasAD cuentasAD = new CuentasAD();
            List<Cuentas> listaCuentas = cuentasAD.ObtenerTodasLasCuentas();
            return listaCuentas;
        }

        //Metodo para actualizar el saldo
        public void ActualizarSaldo(int idCuenta, decimal nuevoSaldo)
        {
            CuentasAD cuentasAD = new CuentasAD();
            cuentasAD.ActualizarSaldo(idCuenta, nuevoSaldo);
        }

        //Metodo para obtener la cuenta por el ID
        public Cuentas ObtenerCuentaPorID(int idCuenta)
        {
            CuentasAD cuentasAD = new CuentasAD();
            List<Cuentas> listaCuentas = cuentasAD.ObtenerTodasLasCuentas();
            return listaCuentas.FirstOrDefault(c => c.Id == idCuenta);
        }
    }
}
