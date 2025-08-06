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
    public partial class Frm_ConsultasServicios : Form
    {
        public Frm_ConsultasServicios()
        {
            InitializeComponent();
            CargarFilasYColumnasAlDGV();
            CargarTodosLosDatosAlDGV();
            CargarCombobox();

            DtpFecha.Format = DateTimePickerFormat.Custom;
            DtpFecha.CustomFormat = "MM/yyyy";
            DtpFecha.ShowUpDown = true;

            BttMenu.BackColor= Color.Coral;
            BttCalcular.BackColor= Color.DarkGreen;
            BttPagar.BackColor= Color.DarkGreen;
        }
        //Metodo para cargar las filas y las columnas al DGV
        private void CargarFilasYColumnasAlDGV()
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

            //Columna Nombre
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Nombre";
            NuevaColumna.HeaderText = "Nombre";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;

            //Columna Nonto
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Monto";
            NuevaColumna.HeaderText = "Monto";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;

            //Columna Fecha
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Fecha";
            NuevaColumna.HeaderText = "Fecha";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;

            //ColumnaEstado
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Estado";
            NuevaColumna.HeaderText = "Estado";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;

            DgvConsulta.Columns.Add(NuevaColumna);
        }

        //Metodo para cargar todos los datos al DGV
        private void CargarTodosLosDatosAlDGV()
        {
            DgvConsulta.Rows.Clear();
            ServiciosN serviciosN = new ServiciosN();
            List<Servicios> listaServicios = serviciosN.ObtenerTodosLosServicios();
            foreach (var servicio in listaServicios)
            {
                DgvConsulta.Rows.Add(servicio.Id, servicio.Nombre, servicio.Monto.ToString("N2"), servicio.Fecha, servicio.Estado ? "Pagado" : "Pendiente");
            }
        }

        //Metodo para cargar los combobox
        private void CargarCombobox()
        {
            //Cargar cmb servicios
            CmbServicios.Items.Clear();
            CmbServicios.Items.Add("Todos");
            CmbServicios.Items.Add("Pagados");
            CmbServicios.Items.Add("Pendientes");
            CmbServicios.SelectedIndex = 0; // por defecto

            ServiciosN serviciosN = new ServiciosN();
            var pendientes = serviciosN.ObtenerServiosPendientes();
            //Cargar cmb Para pagar
            CmbPagar.DataSource = pendientes;
            CmbPagar.DisplayMember = "Nombre";
            CmbPagar.ValueMember = "Id";
            CmbPagar.SelectedIndex = -1;
        }
        //Metodo para cargar los datos al dgv de acuerdo al Cmb servicios
        private void CargarServiciosALDGV()
        {
            ServiciosN serviciosN = new ServiciosN();
            List<Servicios> lista;

            switch (CmbServicios.SelectedItem.ToString())
            {
                case "Pagados":
                    lista = serviciosN.ObtenerServiciosPagados();
                    break;
                case "Pendientes":
                    lista = serviciosN.ObtenerServiosPendientes();
                    break;
                default:
                    var pagados = serviciosN.ObtenerServiciosPagados();
                    var pendientes = serviciosN.ObtenerServiosPendientes();
                    lista = pagados.Concat(pendientes).ToList();
                    break;
            }

            DgvConsulta.Rows.Clear();
            foreach (var servicio in lista)
            {
                DgvConsulta.Rows.Add(servicio.Id, servicio.Nombre, servicio.Monto.ToString("N2"), servicio.Fecha, servicio.Estado ? "Pagado" : "Pendiente");
            }
        }

        //Cmb select 
        private void CmbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarServiciosALDGV();
        }
        
        //Boton Menu
        private void BttMenu_Click(object sender, EventArgs e)
        {
            Frm_MenuPrincipal ventana = new Frm_MenuPrincipal();
            ventana.Show();
            this.Close();
        }

        //Boton Calcular
        private void BttCalcular_Click(object sender, EventArgs e)
        {
            int mes = DtpFecha.Value.Month;
            int anio = DtpFecha.Value.Year;

            ServiciosN serviciosN = new ServiciosN();

            // Si usás la clase ResultadoMonto
            var resultado = serviciosN.ObtenerMontosServiciosMes(mes, anio);

            LblTotal.Text = $"{resultado.Total:C2}";
            LblCada.Text = $"{resultado.Mitad:C2}";
        }

        //Boton pagar
        private void BttPagar_Click(object sender, EventArgs e)
        {
            if (CmbPagar.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un servicio pendiente.");
                return;
            }

            int idServicio = Convert.ToInt32(CmbPagar.SelectedValue);
            ServiciosN serviciosN = new ServiciosN();

            bool exito = serviciosN.ActualizarServicio(idServicio, true); // true = pagado

            if (exito)
            {
                MessageBox.Show("Servicio marcado como pagado correctamente.");
                CargarCombobox();
                CmbPagar.Text = "";
                CargarServiciosALDGV();           
            }
            else
            {
                MessageBox.Show("Error al actualizar el servicio.");
            }
        }
    }
}
