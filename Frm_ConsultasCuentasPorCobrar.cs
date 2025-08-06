using Capa_Logica_Negocio;
using CapaAccesoDatos;
using CapaEntidades;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Capa_Presentacion
{
    public partial class Frm_ConsultasCuentasPorCobrar : Form
    {

        public Frm_ConsultasCuentasPorCobrar()
        {
            InitializeComponent();
            CargarFilasYColumnasDGV();
            CargarTodosLosDatosAlDGV();
            //CargarPersonasCombobox();
            BttMenu.BackColor = Color.Coral;
        }
        //Metodo para crear y cargar las filas y columnas al DGV
        private void CargarFilasYColumnasDGV()
        {
            DgvConsulta.DataSource = null;
            DgvConsulta.Rows.Clear();
            DgvConsulta.Columns.Clear();

            //Colunma ID
            DataGridViewColumn NuevaColumna = new DataGridViewColumn();
            DataGridViewCell NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "ID";
            NuevaColumna.HeaderText = "ID";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;

            //Columna Persona
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Persona";
            NuevaColumna.HeaderText = "Persona";
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

            //Columna Monto
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Monto";
            NuevaColumna.HeaderText = "Monto";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;

            //Columna Descripcion
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Descripcion";
            NuevaColumna.HeaderText = "Descripcion";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;

            //Columna Movimiento
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Movimiento";
            NuevaColumna.HeaderText = "Movimiento";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;

            //Columna Total
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Total";
            NuevaColumna.HeaderText = "Total";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 50;

            DgvConsulta.Columns.Add(NuevaColumna);
        }

        //Metodo para cargar todos los datos al DGV
        private void CargarTodosLosDatosAlDGV()
        {
            CobrarN cobrarN = new CobrarN();
            List<Cobrar> listaCuentasPorCobrar = cobrarN.ObtenerTodasLasCuentasPorCobrar();

            foreach (var cobrar in listaCuentasPorCobrar)
            {
                string movimientoTexto = cobrar.Movimiento ? "Préstamo" : "Abono";
                string nombreCompleto = $"{cobrar.Persona.Nombre} {cobrar.Persona.PrimerApellido} {cobrar.Persona.SegundoApellido}";

                DgvConsulta.Rows.Add(
                    cobrar.Id,
                    nombreCompleto,
                    cobrar.Fecha.ToShortDateString(),
                    cobrar.Monto.ToString("N2"),
                    cobrar.Descripcion,
                    movimientoTexto,
                    cobrar.Saldo.ToString("N2")
                );
            }

        }
        //Metodo para cargar las personas en el Combobox
        private void CargarPersonasCombobox()
        {
            {
                PersonasN personaN = new PersonasN();
                List<Persona> listaPersonas = personaN.ObtenerTodasLasPersonas();

                //listaPersonas.Insert(0, new Persona { Id = 0, Nombre = "-- Todas las personas --" });


                CmbPersona.DataSource = listaPersonas;
                CmbPersona.DisplayMember = "Nombre";
                CmbPersona.ValueMember = "Id";
                CmbPersona.SelectedIndex = 0; // Para que no haya selección inicial
            }
        }
        //Metodo para cambiar los datos de acuerdo a la persona seleccionada en el cmb
        private void CmbPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPersona.SelectedItem == null)
                return;

            Persona personaSeleccionada = (Persona)CmbPersona.SelectedItem;
            CobrarN cobrarN = new CobrarN();

            // List<Cobrar> cobrosFiltrados = cobrarN.ObtenerCuentasPorCobrarPorPersona(personaSeleccionada.Id);

            DgvConsulta.Rows.Clear();

            List<Cobrar> ListaCobros;
            if (personaSeleccionada.Id == 0)
            {
                ListaCobros = cobrarN.ObtenerTodasLasCuentasPorCobrar();
            }
            else
            {
                ListaCobros = cobrarN.ObtenerCuentasPorCobrarPorPersona(personaSeleccionada.Id);
            }

            foreach (var cobrar in ListaCobros)
            {
                string movimientoTexto = cobrar.Movimiento ? "Préstamo" : "Abono";
                string nombreCompleto = $"{personaSeleccionada.Nombre} {personaSeleccionada.PrimerApellido} {personaSeleccionada.SegundoApellido}";

                DgvConsulta.Rows.Add(
                    cobrar.Id,
                    nombreCompleto,
                    cobrar.Fecha.ToShortDateString(),
                    cobrar.Monto.ToString("N2"),
                    cobrar.Descripcion,
                    movimientoTexto,
                    cobrar.Saldo.ToString("N2")
                );
            }
        }

        private void BttMenu_Click(object sender, EventArgs e)
        {
            Frm_MenuPrincipal ventana = new Frm_MenuPrincipal();
            ventana.Show();
            this.Close();
        }

        private void BttHabilitar_Click(object sender, EventArgs e)
        {
            CargarPersonasCombobox();
        }
    }
}
