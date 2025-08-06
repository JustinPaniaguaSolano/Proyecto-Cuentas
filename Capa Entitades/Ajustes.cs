using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Ajustes
    {
        public int Id { get; set; }//Id de la transacion
        public DateTime Fecha { get; set; }//Fecha del ajuste
        public string Descripcion { get; set; }//descripcion del ajuste
        public Cuentas IdCuenta{ get; set; } //Cuenta del ajuste
        public decimal Monto { get; set; }//Monto de la transacion
        public bool Movimiento { get; set; } //Entrada-Salida
        public decimal Saldo { get; set; } // Saldo actual de la cuenta después del ajuste
    }
        
    }

