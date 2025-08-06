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
    public partial class Frm_ConsultasCuentas : Form
    {
        public Frm_ConsultasCuentas()
        {
            InitializeComponent();
            CargarFilasYColumnasDGV();
            CargarDatosAlDGV();

            BttMenu.BackColor = Color.Coral;
        }

        //Metodo para cargar las columnas y filas Al DGV
        private void CargarFilasYColumnasDGV()
        {
            DgvConsulta.DataSource = null;
            DgvConsulta.Rows.Clear();
            DgvConsulta.Columns.Clear();

            //Columna ID
            DataGridViewColumn NuevaColumna = new DataGridViewColumn();
            DataGridViewCell NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Id";
            NuevaColumna.HeaderText = "Id";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;
            DgvConsulta.Columns.Add(NuevaColumna);

            //Columna Nombre
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Nombre";
            NuevaColumna.HeaderText = "Nombre";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;
            DgvConsulta.Columns.Add(NuevaColumna);

            //Columna Monto
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Monto";
            NuevaColumna.HeaderText = "Monto";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            DgvConsulta.Columns.Add(NuevaColumna);
        }

        //Metodo para cargar todos los datos al DGV
        private void CargarDatosAlDGV()
        {
            CapaLogicaNegocio.CuentasN cuentasN = new CapaLogicaNegocio.CuentasN();
            List<CapaEntidades.Cuentas> listaCuentas = cuentasN.ObtenerTodasLasCuentas();
            decimal Total= 0;
            foreach (var cuenta in listaCuentas)
            {
                DgvConsulta.Rows.Add(cuenta.Id, cuenta.Nombre, cuenta.Monto.ToString("N2"));
                Total += cuenta.Monto;
            }
            LblTotal.Text= Total.ToString("N2");
        }
        //Boton Menu
        private void BttMenu_Click(object sender, EventArgs e)
        {
            Frm_MenuPrincipal ventana = new Frm_MenuPrincipal();
            ventana.Show();
            this.Hide();
        }
    }
}
