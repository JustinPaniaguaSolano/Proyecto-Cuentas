namespace Capa_Presentacion
{
    partial class Frm_MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            BttAgregarAjustes = new Button();
            BttConsultasAjustes = new Button();
            BttAgregarCuentas = new Button();
            BttAgregarPersonas = new Button();
            BttAgregarCuentasPorCobrar = new Button();
            BttAgregarServicios = new Button();
            BttConsultarCuentas = new Button();
            BttConsultarPersonas = new Button();
            BttConsultasCuentasPorCobrar = new Button();
            BttConsultarServicios = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(21, 73);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Ajustes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(21, 101);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Cuentas por Cobrar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(21, 132);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Personas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(21, 160);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Cuentas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(21, 196);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Servicios";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(185, 30);
            label6.Name = "label6";
            label6.Size = new Size(126, 21);
            label6.TabIndex = 5;
            label6.Text = "Menu Principal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(201, 7);
            label7.Name = "label7";
            label7.Size = new Size(71, 21);
            label7.TabIndex = 6;
            label7.Text = "Cuentas";
            // 
            // BttAgregarAjustes
            // 
            BttAgregarAjustes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            BttAgregarAjustes.Location = new Point(191, 71);
            BttAgregarAjustes.Name = "BttAgregarAjustes";
            BttAgregarAjustes.Size = new Size(75, 23);
            BttAgregarAjustes.TabIndex = 7;
            BttAgregarAjustes.Text = "Agregar";
            BttAgregarAjustes.UseVisualStyleBackColor = true;
            BttAgregarAjustes.Click += BttAgregarAjustes_Click;
            // 
            // BttConsultasAjustes
            // 
            BttConsultasAjustes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            BttConsultasAjustes.Location = new Point(298, 73);
            BttConsultasAjustes.Name = "BttConsultasAjustes";
            BttConsultasAjustes.Size = new Size(75, 23);
            BttConsultasAjustes.TabIndex = 8;
            BttConsultasAjustes.Text = "Consultar";
            BttConsultasAjustes.UseVisualStyleBackColor = true;
            BttConsultasAjustes.Click += BttConsultasAjustes_Click;
            // 
            // BttAgregarCuentas
            // 
            BttAgregarCuentas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            BttAgregarCuentas.Location = new Point(191, 161);
            BttAgregarCuentas.Name = "BttAgregarCuentas";
            BttAgregarCuentas.Size = new Size(75, 23);
            BttAgregarCuentas.TabIndex = 9;
            BttAgregarCuentas.Text = "Agregar";
            BttAgregarCuentas.UseVisualStyleBackColor = true;
            BttAgregarCuentas.Click += BttAgregarCuentas_Click;
            // 
            // BttAgregarPersonas
            // 
            BttAgregarPersonas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            BttAgregarPersonas.Location = new Point(191, 132);
            BttAgregarPersonas.Name = "BttAgregarPersonas";
            BttAgregarPersonas.Size = new Size(75, 23);
            BttAgregarPersonas.TabIndex = 10;
            BttAgregarPersonas.Text = "Agregar";
            BttAgregarPersonas.UseVisualStyleBackColor = true;
            BttAgregarPersonas.Click += BttAgregarPersonas_Click;
            // 
            // BttAgregarCuentasPorCobrar
            // 
            BttAgregarCuentasPorCobrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            BttAgregarCuentasPorCobrar.Location = new Point(191, 103);
            BttAgregarCuentasPorCobrar.Name = "BttAgregarCuentasPorCobrar";
            BttAgregarCuentasPorCobrar.Size = new Size(75, 23);
            BttAgregarCuentasPorCobrar.TabIndex = 11;
            BttAgregarCuentasPorCobrar.Text = "Agregar";
            BttAgregarCuentasPorCobrar.UseVisualStyleBackColor = true;
            BttAgregarCuentasPorCobrar.Click += BttAgregarCuentasPorCobrar_Click;
            // 
            // BttAgregarServicios
            // 
            BttAgregarServicios.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            BttAgregarServicios.Location = new Point(191, 196);
            BttAgregarServicios.Name = "BttAgregarServicios";
            BttAgregarServicios.Size = new Size(75, 23);
            BttAgregarServicios.TabIndex = 12;
            BttAgregarServicios.Text = "Agregar";
            BttAgregarServicios.UseVisualStyleBackColor = true;
            BttAgregarServicios.Click += BttAgregarServicios_Click;
            // 
            // BttConsultarCuentas
            // 
            BttConsultarCuentas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            BttConsultarCuentas.Location = new Point(298, 161);
            BttConsultarCuentas.Name = "BttConsultarCuentas";
            BttConsultarCuentas.Size = new Size(75, 23);
            BttConsultarCuentas.TabIndex = 13;
            BttConsultarCuentas.Text = "Consultar";
            BttConsultarCuentas.UseVisualStyleBackColor = true;
            BttConsultarCuentas.Click += BttConsultarCuentas_Click;
            // 
            // BttConsultarPersonas
            // 
            BttConsultarPersonas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            BttConsultarPersonas.Location = new Point(298, 132);
            BttConsultarPersonas.Name = "BttConsultarPersonas";
            BttConsultarPersonas.Size = new Size(75, 23);
            BttConsultarPersonas.TabIndex = 14;
            BttConsultarPersonas.Text = "Consultar";
            BttConsultarPersonas.UseVisualStyleBackColor = true;
            BttConsultarPersonas.Click += BttConsultarPersonas_Click;
            // 
            // BttConsultasCuentasPorCobrar
            // 
            BttConsultasCuentasPorCobrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            BttConsultasCuentasPorCobrar.Location = new Point(298, 103);
            BttConsultasCuentasPorCobrar.Name = "BttConsultasCuentasPorCobrar";
            BttConsultasCuentasPorCobrar.Size = new Size(75, 23);
            BttConsultasCuentasPorCobrar.TabIndex = 15;
            BttConsultasCuentasPorCobrar.Text = "Consultar";
            BttConsultasCuentasPorCobrar.UseVisualStyleBackColor = true;
            BttConsultasCuentasPorCobrar.Click += BttConsultasCuentasPorCobrar_Click;
            // 
            // BttConsultarServicios
            // 
            BttConsultarServicios.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            BttConsultarServicios.Location = new Point(298, 196);
            BttConsultarServicios.Name = "BttConsultarServicios";
            BttConsultarServicios.Size = new Size(75, 23);
            BttConsultarServicios.TabIndex = 16;
            BttConsultarServicios.Text = "Consultar";
            BttConsultarServicios.UseVisualStyleBackColor = true;
            BttConsultarServicios.Click += BttConsultarServicios_Click;
            // 
            // Frm_MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(460, 250);
            Controls.Add(BttConsultarServicios);
            Controls.Add(BttConsultasCuentasPorCobrar);
            Controls.Add(BttConsultarPersonas);
            Controls.Add(BttConsultarCuentas);
            Controls.Add(BttAgregarServicios);
            Controls.Add(BttAgregarCuentasPorCobrar);
            Controls.Add(BttAgregarPersonas);
            Controls.Add(BttAgregarCuentas);
            Controls.Add(BttConsultasAjustes);
            Controls.Add(BttAgregarAjustes);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_MenuPrincipal";
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button BttAgregarAjustes;
        private Button BttConsultasAjustes;
        private Button BttAgregarCuentas;
        private Button BttAgregarPersonas;
        private Button BttAgregarCuentasPorCobrar;
        private Button BttAgregarServicios;
        private Button BttConsultarCuentas;
        private Button BttConsultarPersonas;
        private Button BttConsultasCuentasPorCobrar;
        private Button BttConsultarServicios;
    }
}