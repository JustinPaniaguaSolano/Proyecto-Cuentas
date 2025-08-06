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
    public partial class Frm_AgregarPersonas : Form
    {
        public Frm_AgregarPersonas()
        {
            InitializeComponent();
            BttGuardar.BackColor = Color.ForestGreen;
            BttMenu.BackColor = Color.Coral;
        }
        //Metodo para validar los campos
        private bool Validaciones()
        {
            if (TxtNombre.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre");
                return false;
            }
            if (TxtPrimerApellido.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un primer apellido");
                return false;
            }
            if (TxtSegundoApellido.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un segundo apellido");
                return false;
            }

            Persona persona = new Persona
            {
                Nombre = TxtNombre.Text,
                PrimerApellido = TxtPrimerApellido.Text,
                SegundoApellido = TxtSegundoApellido.Text
            };

            bool agregar = new PersonasN().AgregarPersona(persona);
            if (agregar)
            {
                MessageBox.Show("Persona agregada exitosamente");
                LimpiarCampos();
                return true;
            }
            else
            {
                MessageBox.Show("La persona ya existe");
                return false;
            }
        }
        //Metodo para limpiar los campos
        private void LimpiarCampos()
        {
            TxtNombre.Clear();
            TxtPrimerApellido.Clear();
            TxtSegundoApellido.Clear();
        }
        //Boton Menu
        private void BttMenu_Click(object sender, EventArgs e)
        {
            Frm_MenuPrincipal ventana = new Frm_MenuPrincipal();
            ventana.Show();
            this.Hide();
        }
        //Boton guardar
        private void BttGuardar_Click(object sender, EventArgs e)
        {
            Validaciones();
        }
    }
}

