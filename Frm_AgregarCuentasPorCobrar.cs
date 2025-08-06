using Capa_Logica_Negocio;
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
    public partial class Frm_AgregarCuentasPorCobrar : Form
    {
        public Frm_AgregarCuentasPorCobrar()
        {
            InitializeComponent();
            CargarCombobox();

            BttGuardar.BackColor = Color.ForestGreen;
            BttMenu.BackColor = Color.Coral;
        }
        //Metodo para las validaciones
        private void Validaciones()
        {
            if (CmbPersona.SelectedIndex == -1)
            {
                MessageBox.Show("El campo Persona es obligatorio");
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtMonto.Text) || !decimal.TryParse(TxtMonto.Text.Replace(" ", ""), out _))
            {
                MessageBox.Show("El campo Monto es obligatorio y debe ser un número válido");
                return;
            }

            if (DtpFecha.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser mayor a la actual");
                return;
            }
            if (CmbMovimiento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un movimiento");
                return;
            }
            if (string.IsNullOrEmpty(TxtDescripcion.Text))
            {
                MessageBox.Show("Ingrese una descripción");
                return;
            }
            Cobrar Cobrar = new Cobrar
            {
                Persona = (Persona)CmbPersona.SelectedItem,
                Fecha = DtpFecha.Value,
                Monto = Convert.ToDecimal(TxtMonto.Text.Replace(" ", "")),
                Descripcion = TxtDescripcion.Text,
                Movimiento = CmbMovimiento.SelectedItem.ToString() == "Prestamo",
                Saldo = Convert.ToDecimal(TxtMonto.Text.Replace(" ", "")),
            };
            CobrarN cuentasPorCobrarN = new CobrarN();
            bool agregar = cuentasPorCobrarN.AgregarCuentaPorCobrar(Cobrar);
            if (agregar)
            {
                MessageBox.Show("Cuenta por cobrar agregada correctamente");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar la cuenta por cobrar");
            }
        }
        //Metodo para limpiar los campos
        private void LimpiarCampos()
        {
            CmbPersona.SelectedIndex = -1;
            DtpFecha.Value = DateTime.Now;
            TxtMonto.Clear();
            CmbMovimiento.SelectedIndex = -1;
            TxtDescripcion.Clear();
        }
        //Metodo para cargar los combobox
        private void CargarCombobox()
        {
            PersonasN personasN = new PersonasN();
            List<Persona> personas = personasN.ObtenerTodasLasPersonas();
            CmbPersona.DataSource = personas;
            CmbPersona.DisplayMember = "Nombre";
            CmbPersona.ValueMember = "Id";
            CmbPersona.SelectedIndex = -1;

            CmbMovimiento.Items.Clear();
            CmbMovimiento.Items.Add("Prestamo");
            CmbMovimiento.Items.Add("Abono");
            CmbMovimiento.SelectedIndex = -1;
        }
        //boton guardar
        private void BttGuardar_Click(object sender, EventArgs e)
        {
            Validaciones();
        }
        //Boton menu
        private void BttMenu_Click(object sender, EventArgs e)
        {
           Frm_MenuPrincipal ventana= new Frm_MenuPrincipal();
            ventana.Show();
            this.Hide();
        }
    }
}
