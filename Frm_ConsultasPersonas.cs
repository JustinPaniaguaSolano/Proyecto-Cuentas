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
    public partial class Frm_ConsultasPersonas : Form
    {
        public Frm_ConsultasPersonas()
        {
            InitializeComponent();
            CargarFilasYColumnasAlDGV();
            CargarTodosLosDatosAlDGV();

            BttMenu.BackColor=Color.Coral;
        }
        //Metodo para cargar las filas y las columnas al dgv
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

            //Columna Primer Apellido
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Primer Apellido";
            NuevaColumna.HeaderText = "Primer Apellido";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;
            DgvConsulta.Columns.Add(NuevaColumna);

            //Columna Segundo Apellido
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.Name = "Segundo Apellido";
            NuevaColumna.HeaderText = "Segundo Apellido";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            DgvConsulta.Columns.Add(NuevaColumna);
        }

        //Metodo para cargar todos los datos al dgv
        private void CargarTodosLosDatosAlDGV()
        {
            CapaLogicaNegocio.PersonasN personasN = new CapaLogicaNegocio.PersonasN();
            List<CapaEntidades.Persona> listaPersonas = personasN.ObtenerTodasLasPersonas();
            foreach (var persona in listaPersonas)
            {
                DgvConsulta.Rows.Add(persona.Id, persona.Nombre, persona.PrimerApellido, persona.SegundoApellido);
            }
        }
        //Boton Menu
        private void BttMenu_Click(object sender, EventArgs e)
        {
            Frm_MenuPrincipal ventana=new Frm_MenuPrincipal();
            ventana.Show();
            this.Close();
        }
    }
}
