using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cobrar
    {
        public int Id{ get; set; }//Id de la transacion
        public Persona Persona{ get; set; }//Persona a cobrar
        public DateTime Fecha{ get; set; }//fecha del cobro
        public decimal Monto{ get; set; }//Monto del cobro
        public string Descripcion{ get; set; }//Descripcion del cobro
        public bool Movimiento{ get; set; } // Pendiente, Pagado, Cancelado
        public decimal Saldo{ get; set; } //Total de la cuenta
    }
}
