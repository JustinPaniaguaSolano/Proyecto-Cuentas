namespace Capa_Presentacion
{
    partial class Frm_AgregarCuentasPorCobrar
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
            BttMenu = new Button();
            BttGuardar = new Button();
            CmbPersona = new ComboBox();
            CmbMovimiento = new ComboBox();
            TxtDescripcion = new TextBox();
            TxtMonto = new TextBox();
            DtpFecha = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(130, 19);
            label1.Name = "label1";
            label1.Size = new Size(221, 21);
            label1.TabIndex = 0;
            label1.Text = "Agregar Cuentas Por Cobrar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(33, 62);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Persona";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(33, 127);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(33, 94);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(33, 162);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 4;
            label5.Text = "Descripcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(33, 199);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 5;
            label6.Text = "Moviminto";
            // 
            // BttMenu
            // 
            BttMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BttMenu.Location = new Point(115, 266);
            BttMenu.Name = "BttMenu";
            BttMenu.Size = new Size(75, 23);
            BttMenu.TabIndex = 6;
            BttMenu.Text = "Menu";
            BttMenu.UseVisualStyleBackColor = true;
            BttMenu.Click += BttMenu_Click;
            // 
            // BttGuardar
            // 
            BttGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BttGuardar.Location = new Point(230, 264);
            BttGuardar.Name = "BttGuardar";
            BttGuardar.Size = new Size(75, 23);
            BttGuardar.TabIndex = 7;
            BttGuardar.Text = "Guardar";
            BttGuardar.UseVisualStyleBackColor = true;
            BttGuardar.Click += BttGuardar_Click;
            // 
            // CmbPersona
            // 
            CmbPersona.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            CmbPersona.FormattingEnabled = true;
            CmbPersona.Location = new Point(152, 54);
            CmbPersona.Name = "CmbPersona";
            CmbPersona.Size = new Size(199, 23);
            CmbPersona.TabIndex = 8;
            // 
            // CmbMovimiento
            // 
            CmbMovimiento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            CmbMovimiento.FormattingEnabled = true;
            CmbMovimiento.Location = new Point(152, 196);
            CmbMovimiento.Name = "CmbMovimiento";
            CmbMovimiento.Size = new Size(199, 23);
            CmbMovimiento.TabIndex = 9;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            TxtDescripcion.Location = new Point(154, 162);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(197, 24);
            TxtDescripcion.TabIndex = 10;
            // 
            // TxtMonto
            // 
            TxtMonto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            TxtMonto.Location = new Point(154, 124);
            TxtMonto.Name = "TxtMonto";
            TxtMonto.Size = new Size(197, 24);
            TxtMonto.TabIndex = 11;
            // 
            // DtpFecha
            // 
            DtpFecha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            DtpFecha.Location = new Point(151, 93);
            DtpFecha.Name = "DtpFecha";
            DtpFecha.Size = new Size(200, 24);
            DtpFecha.TabIndex = 12;
            // 
            // Frm_AgregarCuentasPorCobrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(483, 299);
            Controls.Add(DtpFecha);
            Controls.Add(TxtMonto);
            Controls.Add(TxtDescripcion);
            Controls.Add(CmbMovimiento);
            Controls.Add(CmbPersona);
            Controls.Add(BttGuardar);
            Controls.Add(BttMenu);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_AgregarCuentasPorCobrar";
            Text = "Agregar Cuentas Por Cobrar";
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
        private Button BttMenu;
        private Button BttGuardar;
        private ComboBox CmbPersona;
        private ComboBox CmbMovimiento;
        private TextBox TxtDescripcion;
        private TextBox TxtMonto;
        private DateTimePicker DtpFecha;
    }
}