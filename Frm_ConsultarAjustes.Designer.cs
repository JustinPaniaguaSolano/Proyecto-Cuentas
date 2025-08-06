namespace Capa_Presentacion
{
    partial class Frm_ConsultarAjustes
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
            DgvConsulta = new DataGridView();
            BttMenu = new Button();
            label1 = new Label();
            DtpFiltrar = new DateTimePicker();
            BttFiltrar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // DgvConsulta
            // 
            DgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConsulta.Location = new Point(12, 68);
            DgvConsulta.Name = "DgvConsulta";
            DgvConsulta.Size = new Size(776, 228);
            DgvConsulta.TabIndex = 0;
            // 
            // BttMenu
            // 
            BttMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BttMenu.Location = new Point(359, 358);
            BttMenu.Name = "BttMenu";
            BttMenu.Size = new Size(75, 23);
            BttMenu.TabIndex = 1;
            BttMenu.Text = "Menu";
            BttMenu.UseVisualStyleBackColor = true;
            BttMenu.Click += BttMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(348, 24);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 2;
            label1.Text = "Consultas Ajustes";
            // 
            // DtpFiltrar
            // 
            DtpFiltrar.Location = new Point(12, 358);
            DtpFiltrar.Name = "DtpFiltrar";
            DtpFiltrar.Size = new Size(200, 23);
            DtpFiltrar.TabIndex = 3;
            // 
            // BttFiltrar
            // 
            BttFiltrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BttFiltrar.Location = new Point(247, 359);
            BttFiltrar.Name = "BttFiltrar";
            BttFiltrar.Size = new Size(75, 23);
            BttFiltrar.TabIndex = 4;
            BttFiltrar.Text = "Filtrar";
            BttFiltrar.UseVisualStyleBackColor = true;
            BttFiltrar.Click += BttFiltrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 333);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 5;
            label2.Text = "Filtrar por mes y año";
            // 
            // Frm_ConsultarAjustes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 414);
            Controls.Add(label2);
            Controls.Add(BttFiltrar);
            Controls.Add(DtpFiltrar);
            Controls.Add(label1);
            Controls.Add(BttMenu);
            Controls.Add(DgvConsulta);
            Name = "Frm_ConsultarAjustes";
            Text = "Consultas Ajustes";
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvConsulta;
        private Button BttMenu;
        private Label label1;
        private DateTimePicker DtpFiltrar;
        private Button BttFiltrar;
        private Label label2;
    }
}