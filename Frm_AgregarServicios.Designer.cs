namespace Capa_Presentacion
{
    partial class Frm_AgregarServicios
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
            BttMenu = new Button();
            BttGuardar = new Button();
            TxtNombre = new TextBox();
            TxtMonto = new TextBox();
            DtpFecha = new DateTimePicker();
            CmbEstado = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(155, 21);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 0;
            label1.Text = "Agregar Servicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(34, 86);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Monto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(34, 119);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(35, 149);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(34, 59);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Nombre";
            // 
            // BttMenu
            // 
            BttMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BttMenu.Location = new Point(89, 200);
            BttMenu.Name = "BttMenu";
            BttMenu.Size = new Size(75, 23);
            BttMenu.TabIndex = 5;
            BttMenu.Text = "Menu";
            BttMenu.UseVisualStyleBackColor = true;
            BttMenu.Click += BttMenu_Click;
            // 
            // BttGuardar
            // 
            BttGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BttGuardar.Location = new Point(214, 200);
            BttGuardar.Name = "BttGuardar";
            BttGuardar.Size = new Size(75, 23);
            BttGuardar.TabIndex = 6;
            BttGuardar.Text = "Guardar";
            BttGuardar.UseVisualStyleBackColor = true;
            BttGuardar.Click += BttGuardar_Click;
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            TxtNombre.Location = new Point(164, 51);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(200, 24);
            TxtNombre.TabIndex = 7;
            // 
            // TxtMonto
            // 
            TxtMonto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            TxtMonto.Location = new Point(164, 86);
            TxtMonto.Name = "TxtMonto";
            TxtMonto.Size = new Size(200, 24);
            TxtMonto.TabIndex = 8;
            // 
            // DtpFecha
            // 
            DtpFecha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            DtpFecha.Location = new Point(164, 120);
            DtpFecha.Name = "DtpFecha";
            DtpFecha.Size = new Size(200, 24);
            DtpFecha.TabIndex = 9;
            // 
            // CmbEstado
            // 
            CmbEstado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            CmbEstado.FormattingEnabled = true;
            CmbEstado.Location = new Point(166, 152);
            CmbEstado.Name = "CmbEstado";
            CmbEstado.Size = new Size(198, 23);
            CmbEstado.TabIndex = 10;
            // 
            // Frm_AgregarServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(446, 259);
            Controls.Add(CmbEstado);
            Controls.Add(DtpFecha);
            Controls.Add(TxtMonto);
            Controls.Add(TxtNombre);
            Controls.Add(BttGuardar);
            Controls.Add(BttMenu);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_AgregarServicios";
            Text = "Agregar Servicios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BttMenu;
        private Button BttGuardar;
        private TextBox TxtNombre;
        private TextBox TxtMonto;
        private DateTimePicker DtpFecha;
        private ComboBox CmbEstado;
    }
}