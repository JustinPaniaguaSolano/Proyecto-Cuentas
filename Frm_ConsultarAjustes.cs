using CapaEntidades;
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
    public partial class Frm_ConsultarAjustes : Form
    {
        public Frm_ConsultarAjustes()
        {
            InitializeComponent();
            CargarFilasYColumnasDVG();
            CargarTodosLosDatosDVG();

            BttMenu.BackColor = Color.Coral;
            BttFiltrar.BackColor = Color.Magenta;

            DtpFiltrar.Format = DateTimePickerFormat.Custom;
            DtpFiltrar.CustomFormat = "MM/yyyy";
            DtpFiltrar.ShowUpDown = true;

        }
        //Metodo para cargar las filas y columnas al DVG
        private void CargarFilasYColumnasDVG()
        {
            DgvConsulta.DataSource = null;
            DgvConsulta.Rows.Clear();
            DgvConsulta.Columns.Clear();

            //Celda ID
            DataGridViewColumn NuevaColumna = new DataGridViewColumn();
            DataGridViewCell NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Id";
            NuevaColumna.HeaderText = "Id";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;

            //Celda Fecha
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Fecha";
            NuevaColumna.HeaderText = "Fecha";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;

            //Celda Descripcion
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Descripcion";
            NuevaColumna.HeaderText = "Descripcion";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 250;

            //Celda Cuenta
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Cuenta";
            NuevaColumna.HeaderText = "Cuenta";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;

            //Celda Monto
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Monto";
            NuevaColumna.HeaderText = "Monto";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;

            //Celda Movimiento
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Movimiento";
            NuevaColumna.HeaderText = "Movimiento";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;

            //Celda Saldo
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Saldo";
            NuevaColumna.HeaderText = "Saldo";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;

            DgvConsulta.Columns.Add(NuevaColumna);
        }

        //Metodo para cargar los datos al DVG
        private void CargarTodosLosDatosDVG()
        {
            DgvConsulta.Rows.Clear();
            CapaLogicaNegocio.AjustesN ajustesN = new CapaLogicaNegocio.AjustesN();
            List<CapaEntidades.Ajustes> listaAjustes = ajustesN.ObtenerTodosLosAjustes();
            foreach (var ajustes in listaAjustes)
            {
                string movimientoTexto = ajustes.Movimiento ? "Entrada" : "Salida";

                DgvConsulta.Rows.Add(
                    ajustes.Id,
                    ajustes.Fecha.ToShortDateString(),
                    ajustes.Descripcion,
                    ajustes.IdCuenta.Nombre,
                    ajustes.Monto.ToString("N2"),
                    movimientoTexto,
                    ajustes.Saldo.ToString("N2")
                );
            }
        }

        private void CargarAjustesFiltradosPorMesYAño()
        {
            //obtener el mes y el año 
            int mes = DtpFiltrar.Value.Month;
            int anio = DtpFiltrar.Value.Year;


            var ajustesN = new CapaLogicaNegocio.AjustesN();
            //Llamado de la funcion
            List<Ajustes> listaAjustes = ajustesN.ObtenerAjustesPorMes(mes, anio);


            DgvConsulta.Rows.Clear();

            //Se muestra en el DGV
            foreach (var ajuste in listaAjustes)
            {
                string movimientoTexto = ajuste.Movimiento ? "Entrada" : "Salida";

                DgvConsulta.Rows.Add(
                    ajuste.Id,
                    ajuste.Fecha.ToShortDateString(),
                    ajuste.Descripcion,
                    ajuste.IdCuenta.Nombre,
                    ajuste.Monto,
                    movimientoTexto,
                    ajuste.Saldo
                );
            }
        }

        private void BttMenu_Click(object sender, EventArgs e)
        {
            Frm_MenuPrincipal ventana = new Frm_MenuPrincipal();
            ventana.Show();
            this.Close();
        }

        private void BttFiltrar_Click(object sender, EventArgs e)
        {

            CargarAjustesFiltradosPorMesYAño();
        }
    }
}
