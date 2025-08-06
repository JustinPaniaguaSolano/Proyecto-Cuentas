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
    public partial class Frm_AgregarAjustes : Form
    {
        //Instancias
        private AjustesN ajustesN = new AjustesN();
        private CuentasN cuentasN = new CuentasN();

        public Frm_AgregarAjustes()
        {
            InitializeComponent();
            CargarCombobox();

            BttGuardar.BackColor=Color.ForestGreen;
            BttMenu.BackColor=Color.Coral;
        }
        //Metodo para validar los campos y guardar el ajuste
        private void Validaciones()
        {
            //Validar descripcion
            if (TxtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una descripcion");
                return;
            }
            //validar cuenta
            if (CmbCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una cuenta");
                return;
            }
            //Validar movimiento
            if (CmbMovimiento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un movimiento");
                return;
            }
            //Validar monto
            string montoTexto = TxtMonto.Text.Replace(" ", "");
            if (string.IsNullOrWhiteSpace(montoTexto) || !decimal.TryParse(montoTexto, out decimal montoDecimal))
            {
                MessageBox.Show("Ingrese un monto válido");
                return;
            }


            //validar fecha
            if (DtpFecha.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser mayor a la actual");
                return;
            }

            Ajustes Ajustes = new Ajustes
            {
                Descripcion = TxtDescripcion.Text,
                IdCuenta = (Cuentas)CmbCuenta.SelectedItem,
                Movimiento = CmbMovimiento.SelectedItem.ToString() == "Entrada",
                Monto = montoDecimal,
                Fecha = DtpFecha.Value
            };
            //guardar el ajuste
            bool agregar = ajustesN.AgregarAjustes(Ajustes);
            if (agregar)
            {
                MessageBox.Show("Ajuste agregado correctamente");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al Monto insuficiente el ajuste");
            }
        }
        //Metodo para limpiar los campos
        private void LimpiarCampos()
        {
            TxtDescripcion.Clear();
            CmbCuenta.SelectedIndex = -1;
            CmbMovimiento.SelectedIndex = -1;
            TxtMonto.Clear();
            DtpFecha.Value = DateTime.Now;
        }
        //Metodo para cargar los Combobox
        private void CargarCombobox()
        {
            CmbCuenta.DataSource = cuentasN.ObtenerTodasLasCuentas();
            CmbCuenta.DisplayMember = "Nombre";
            CmbCuenta.SelectedIndex = -1;

            CmbCuenta.SelectedIndex = -1;
            CmbMovimiento.Items.Add("Entrada");
            CmbMovimiento.Items.Add("Salida");
            CmbMovimiento.SelectedIndex = -1;
        }

        private void BttMenu_Click(object sender, EventArgs e)
        {
            Frm_MenuPrincipal ventana = new Frm_MenuPrincipal();
            this.Hide();
            ventana.Show();
        }

        private void BttGuardar_Click(object sender, EventArgs e)
        {
            Validaciones();
        }
    }
}
