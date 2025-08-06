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
    public partial class Frm_MenuPrincipal : Form
    {
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
            ConfigurarBotonesAgregar();
            ConfigurarBotonesConsultas();
        }
        //Metodo par configurar los botones agregar
        private void ConfigurarBotonesAgregar()
        {
            BttAgregarAjustes.BackColor = Color.SkyBlue;
            BttAgregarCuentas.BackColor = Color.SkyBlue;
            BttAgregarCuentasPorCobrar.BackColor = Color.SkyBlue;
            BttAgregarPersonas.BackColor = Color.SkyBlue;
            BttAgregarServicios.BackColor = Color.SkyBlue;
        }

        //Metodo para configurar los botones Consultas
        private void ConfigurarBotonesConsultas()
        {
            BttConsultarCuentas.BackColor = Color.ForestGreen;
            BttConsultarPersonas.BackColor = Color.ForestGreen;
            BttConsultarServicios.BackColor = Color.ForestGreen;
            BttConsultasAjustes.BackColor = Color.ForestGreen;
            BttConsultasCuentasPorCobrar.BackColor = Color.ForestGreen;
        }

        #region Botones Agregar
        //Boton agregar ajustes
        private void BttAgregarAjustes_Click(object sender, EventArgs e)
        {
            Frm_AgregarAjustes ventana = new Frm_AgregarAjustes();
            ventana.Show();
            this.Hide();
        }
        //boton Agregar cuentas por cobrar
        private void BttAgregarCuentasPorCobrar_Click(object sender, EventArgs e)
        {
            Frm_AgregarCuentasPorCobrar ventana = new Frm_AgregarCuentasPorCobrar();
            ventana.Show();
            this.Hide();
        }
        //boton agregar cuentas
        private void BttAgregarCuentas_Click(object sender, EventArgs e)
        {
            Frm_AgregarCuentas ventana = new Frm_AgregarCuentas();
            ventana.Show();
            this.Hide();
        }
        //Boton agregar personas
        private void BttAgregarPersonas_Click(object sender, EventArgs e)
        {
            Frm_AgregarPersonas ventana = new Frm_AgregarPersonas();
            ventana.Show();
            this.Hide();
        }

        //Boton agregar servicios
        private void BttAgregarServicios_Click(object sender, EventArgs e)
        {
            Frm_AgregarServicios ventana = new Frm_AgregarServicios();
            ventana.Show();
            this.Hide();

        }
        #endregion

        #region Botones consultas
        //Boton consultas ajustes
        private void BttConsultasAjustes_Click(object sender, EventArgs e)
        {
            Frm_ConsultarAjustes ventana = new Frm_ConsultarAjustes();
            ventana.Show();
            this.Hide();
        }

        //Boton consultas cuentas por cobrar
        private void BttConsultasCuentasPorCobrar_Click(object sender, EventArgs e)
        {
            Frm_ConsultasCuentasPorCobrar ventana = new Frm_ConsultasCuentasPorCobrar();
            ventana.Show();
            this.Hide();
        }

        //Boton consultas Personas
        private void BttConsultarPersonas_Click(object sender, EventArgs e)
        {
            Frm_ConsultasPersonas ventana = new Frm_ConsultasPersonas();
            ventana.Show();
            this.Hide();
        }

        //Boton consultas Cuentas
        private void BttConsultarCuentas_Click(object sender, EventArgs e)
        {
            Frm_ConsultasCuentas ventana = new Frm_ConsultasCuentas();
            ventana.Show();
            this.Hide();
        }

        //Boton consultas Servicios
        private void BttConsultarServicios_Click(object sender, EventArgs e)
        {
            Frm_ConsultasServicios ventana=new Frm_ConsultasServicios();
            ventana.Show();
            this.Hide();
        }
        #endregion
    }
}
