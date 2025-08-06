namespace Capa_Presentacion
{
    partial class Frm_ConsultasServicios
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
            DgvConsulta = new DataGridView();
            CmbServicios = new ComboBox();
            DtpFecha = new DateTimePicker();
            BttMenu = new Button();
            BttCalcular = new Button();
            BttPagar = new Button();
            CmbPagar = new ComboBox();
            labelE2 = new Label();
            LblTotal = new Label();
            label4 = new Label();
            LblCada = new Label();
            label6 = new Label();
            label2 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(369, 26);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 0;
            label1.Text = "Consultas Servicios";
            // 
            // DgvConsulta
            // 
            DgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConsulta.Location = new Point(22, 65);
            DgvConsulta.Name = "DgvConsulta";
            DgvConsulta.Size = new Size(841, 224);
            DgvConsulta.TabIndex = 1;
            // 
            // CmbServicios
            // 
            CmbServicios.FormattingEnabled = true;
            CmbServicios.Location = new Point(123, 295);
            CmbServicios.Name = "CmbServicios";
            CmbServicios.Size = new Size(138, 25);
            CmbServicios.TabIndex = 2;
            CmbServicios.SelectedIndexChanged += CmbServicios_SelectedIndexChanged;
            // 
            // DtpFecha
            // 
            DtpFecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DtpFecha.Location = new Point(102, 345);
            DtpFecha.Name = "DtpFecha";
            DtpFecha.Size = new Size(228, 25);
            DtpFecha.TabIndex = 3;
            // 
            // BttMenu
            // 
            BttMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BttMenu.Location = new Point(400, 470);
            BttMenu.Name = "BttMenu";
            BttMenu.Size = new Size(86, 26);
            BttMenu.TabIndex = 4;
            BttMenu.Text = "Menu";
            BttMenu.UseVisualStyleBackColor = true;
            BttMenu.Click += BttMenu_Click;
            // 
            // BttCalcular
            // 
            BttCalcular.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BttCalcular.Location = new Point(337, 345);
            BttCalcular.Name = "BttCalcular";
            BttCalcular.Size = new Size(86, 26);
            BttCalcular.TabIndex = 5;
            BttCalcular.Text = "Calcular";
            BttCalcular.UseVisualStyleBackColor = true;
            BttCalcular.Click += BttCalcular_Click;
            // 
            // BttPagar
            // 
            BttPagar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BttPagar.Location = new Point(743, 349);
            BttPagar.Name = "BttPagar";
            BttPagar.Size = new Size(86, 26);
            BttPagar.TabIndex = 6;
            BttPagar.Text = "Pagar";
            BttPagar.UseVisualStyleBackColor = true;
            BttPagar.Click += BttPagar_Click;
            // 
            // CmbPagar
            // 
            CmbPagar.FormattingEnabled = true;
            CmbPagar.Location = new Point(747, 314);
            CmbPagar.Name = "CmbPagar";
            CmbPagar.Size = new Size(138, 25);
            CmbPagar.TabIndex = 7;
            // 
            // labelE2
            // 
            labelE2.AutoSize = true;
            labelE2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            labelE2.Location = new Point(3, 351);
            labelE2.Name = "labelE2";
            labelE2.Size = new Size(88, 17);
            labelE2.TabIndex = 8;
            labelE2.Text = "Escoja el mes:";
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            LblTotal.Location = new Point(130, 424);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(43, 17);
            LblTotal.TabIndex = 9;
            LblTotal.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(34, 424);
            label4.Name = "label4";
            label4.Size = new Size(90, 17);
            label4.TabIndex = 10;
            label4.Text = "Total a Pagar:";
            // 
            // LblCada
            // 
            LblCada.AutoSize = true;
            LblCada.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            LblCada.Location = new Point(123, 460);
            LblCada.Name = "LblCada";
            LblCada.Size = new Size(43, 17);
            LblCada.TabIndex = 11;
            LblCada.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(46, 460);
            label6.Name = "label6";
            label6.Size = new Size(68, 17);
            label6.TabIndex = 12;
            label6.Text = "Cada Uno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(3, 298);
            label2.Name = "label2";
            label2.Size = new Size(112, 17);
            label2.TabIndex = 13;
            label2.Text = "Escoja el Servicio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(627, 323);
            label7.Name = "label7";
            label7.Size = new Size(111, 17);
            label7.TabIndex = 14;
            label7.Text = "Pagar el Servicio:";
            // 
            // Frm_ConsultasServicios
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 510);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(LblCada);
            Controls.Add(label4);
            Controls.Add(LblTotal);
            Controls.Add(labelE2);
            Controls.Add(CmbPagar);
            Controls.Add(BttPagar);
            Controls.Add(BttCalcular);
            Controls.Add(BttMenu);
            Controls.Add(DtpFecha);
            Controls.Add(CmbServicios);
            Controls.Add(DgvConsulta);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Name = "Frm_ConsultasServicios";
            Text = "Consultas Servicios";
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DgvConsulta;
        private ComboBox CmbServicios;
        private DateTimePicker DtpFecha;
        private Button BttMenu;
        private Button BttCalcular;
        private Button BttPagar;
        private ComboBox CmbPagar;
        private Label labelE2;
        private Label LblTotal;
        private Label label4;
        private Label LblCada;
        private Label label6;
        private Label label2;
        private Label label7;
    }
}