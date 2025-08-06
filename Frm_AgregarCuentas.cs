using CapaEntidades;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Frm_AgregarCuentas : Form
    {
        public Frm_AgregarCuentas()
        {
            InitializeComponent();

            BttGuardar.BackColor = Color.ForestGreen;
            BttMenu.BackColor = Color.Coral;
        }

        //Metodo para validar los campos
        private void Validaciones()
        {
            if (TxtNombre.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre");
                return;
            }
            Cuentas cuentas = new Cuentas
            {
                Nombre = TxtNombre.Text,
                Monto = 0
            };
            CuentasN cuentasN = new CuentasN();
            bool agregar = cuentasN.AgregarCuenta(cuentas);
            if (agregar)
            {
                MessageBox.Show("Cuenta agregada exitosamente");
                TxtNombre.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("La cuenta ya existe");
            }
        }

        #region Botones
        //Boton menu
        private void BttMenu_Click(object sender, EventArgs e)
        {
            Frm_MenuPrincipal ventana = new Frm_MenuPrincipal();
            ventana.Show();
            this.Close();
        }
        //Boton guardar
        private void BttGuardar_Click(object sender, EventArgs e)
        {
            Validaciones();
        }
        #endregion
    }
}
