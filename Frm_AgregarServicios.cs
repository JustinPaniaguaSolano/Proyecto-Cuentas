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
    public partial class Frm_AgregarServicios : Form
    {
        public Frm_AgregarServicios()
        {
            InitializeComponent();
            CargarCombobox();
        }
        //Metodo para las validaciones
        private void Validaciones()
        {
            if (TxtNombre.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre");
                return;
            }

            string montoTexto = TxtMonto.Text.Replace(" ", "");
            if (string.IsNullOrWhiteSpace(montoTexto) || !decimal.TryParse(montoTexto, out decimal montoDecimal))
            {
                MessageBox.Show("Ingrese un monto válido");
                return;
            }

            if (CmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un estado");
            }
            Servicios servicios = new Servicios
            {
                Nombre = TxtNombre.Text,
                Monto = montoDecimal,
                Fecha = DtpFecha.Value,
                Estado = CmbEstado.SelectedItem.ToString() == "Pagado"
            };
            ServiciosN serviciosN = new ServiciosN();
            bool Agregar = serviciosN.AgregarServicio(servicios);

            if (Agregar)
            {
                MessageBox.Show("Servicio agregado correctamente");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el servicio");
            }
        }
        //Metodo para limpiar los campos
        private void LimpiarCampos()
        {
            TxtNombre.Clear();
            TxtMonto.Clear();
            CmbEstado.SelectedIndex = -1;
            DtpFecha.Value = DateTime.Now;
        }
        //Metodo para cargar el combobox
        private void CargarCombobox()
        {
            CmbEstado.Items.Add("Pendiente");
            CmbEstado.Items.Add("Pagado");
            CmbEstado.SelectedIndex = 0; // Selecciona el primer elemento por defecto
        }
        //boton menu
        private void BttMenu_Click(object sender, EventArgs e)
        {
            Frm_MenuPrincipal ventana = new Frm_MenuPrincipal();
            ventana.Show();
            this.Hide();
        }
        //boton guardar
        private void BttGuardar_Click(object sender, EventArgs e)
        {
            Validaciones();
        }
    }

}
