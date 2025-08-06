namespace Capa_Presentacion
{
    partial class Frm_AgregarAjustes
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
            DtpFecha = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtDescripcion = new TextBox();
            TxtMonto = new TextBox();
            CmbCuenta = new ComboBox();
            CmbMovimiento = new ComboBox();
            BttMenu = new Button();
            BttGuardar = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // DtpFecha
            // 
            DtpFecha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            DtpFecha.Location = new Point(195, 61);
            DtpFecha.Name = "DtpFecha";
            DtpFecha.Size = new Size(200, 24);
            DtpFecha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(43, 61);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Fecha Ajuste";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(43, 101);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripcion del Ajuste";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(43, 136);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Cuenta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(43, 173);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 4;
            label4.Text = "Monto del Ajuste";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(43, 203);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 5;
            label5.Text = "Movimiento";
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            TxtDescripcion.Location = new Point(195, 101);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(100, 24);
            TxtDescripcion.TabIndex = 6;
            // 
            // TxtMonto
            // 
            TxtMonto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            TxtMonto.Location = new Point(195, 173);
            TxtMonto.Name = "TxtMonto";
            TxtMonto.Size = new Size(100, 24);
            TxtMonto.TabIndex = 7;
            // 
            // CmbCuenta
            // 
            CmbCuenta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            CmbCuenta.FormattingEnabled = true;
            CmbCuenta.Location = new Point(195, 139);
            CmbCuenta.Name = "CmbCuenta";
            CmbCuenta.Size = new Size(121, 23);
            CmbCuenta.TabIndex = 8;
            // 
            // CmbMovimiento
            // 
            CmbMovimiento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            CmbMovimiento.FormattingEnabled = true;
            CmbMovimiento.Location = new Point(195, 213);
            CmbMovimiento.Name = "CmbMovimiento";
            CmbMovimiento.Size = new Size(121, 23);
            CmbMovimiento.TabIndex = 9;
            // 
            // BttMenu
            // 
            BttMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BttMenu.Location = new Point(82, 269);
            BttMenu.Name = "BttMenu";
            BttMenu.Size = new Size(75, 23);
            BttMenu.TabIndex = 10;
            BttMenu.Text = "Menu";
            BttMenu.UseVisualStyleBackColor = true;
            BttMenu.Click += BttMenu_Click;
            // 
            // BttGuardar
            // 
            BttGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BttGuardar.Location = new Point(263, 269);
            BttGuardar.Name = "BttGuardar";
            BttGuardar.Size = new Size(75, 23);
            BttGuardar.TabIndex = 11;
            BttGuardar.Text = "Guardar";
            BttGuardar.UseVisualStyleBackColor = true;
            BttGuardar.Click += BttGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(165, 22);
            label6.Name = "label6";
            label6.Size = new Size(130, 21);
            label6.TabIndex = 12;
            label6.Text = "Agregar Ajustes";
            // 
            // Frm_AgregarAjustes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(493, 302);
            Controls.Add(label6);
            Controls.Add(BttGuardar);
            Controls.Add(BttMenu);
            Controls.Add(CmbMovimiento);
            Controls.Add(CmbCuenta);
            Controls.Add(TxtMonto);
            Controls.Add(TxtDescripcion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DtpFecha);
            Name = "Frm_AgregarAjustes";
            Text = "Agregar Ajustes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DtpFecha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtDescripcion;
        private TextBox TxtMonto;
        private ComboBox CmbCuenta;
        private ComboBox CmbMovimiento;
        private Button BttMenu;
        private Button BttGuardar;
        private Label label6;
    }
}