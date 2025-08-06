namespace Capa_Presentacion
{
    partial class Frm_ConsultasCuentasPorCobrar
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
            CmbPersona = new ComboBox();
            label2 = new Label();
            BttMenu = new Button();
            BttHabilitar = new Button();
            DgvConsulta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 24);
            label1.Name = "label1";
            label1.Size = new Size(227, 21);
            label1.TabIndex = 0;
            label1.Text = "Consulta Cuentas por Cobrar";
            // 
            // CmbPersona
            // 
            CmbPersona.FormattingEnabled = true;
            CmbPersona.Location = new Point(44, 314);
            CmbPersona.Name = "CmbPersona";
            CmbPersona.Size = new Size(152, 23);
            CmbPersona.TabIndex = 2;
            CmbPersona.SelectedIndexChanged += CmbPersona_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 287);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 3;
            label2.Text = "Escoja la persona";
            // 
            // BttMenu
            // 
            BttMenu.Location = new Point(366, 313);
            BttMenu.Name = "BttMenu";
            BttMenu.Size = new Size(75, 23);
            BttMenu.TabIndex = 4;
            BttMenu.Text = "Menu";
            BttMenu.UseVisualStyleBackColor = true;
            BttMenu.Click += BttMenu_Click;
            // 
            // BttHabilitar
            // 
            BttHabilitar.Location = new Point(216, 314);
            BttHabilitar.Name = "BttHabilitar";
            BttHabilitar.Size = new Size(75, 23);
            BttHabilitar.TabIndex = 5;
            BttHabilitar.Text = "Habilitar";
            BttHabilitar.UseVisualStyleBackColor = true;
            BttHabilitar.Click += BttHabilitar_Click;
            // 
            // DgvConsulta
            // 
            DgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConsulta.Location = new Point(23, 68);
            DgvConsulta.Name = "DgvConsulta";
            DgvConsulta.Size = new Size(749, 205);
            DgvConsulta.TabIndex = 1;
            // 
            // Frm_ConsultasCuentasPorCobrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BttHabilitar);
            Controls.Add(BttMenu);
            Controls.Add(label2);
            Controls.Add(CmbPersona);
            Controls.Add(DgvConsulta);
            Controls.Add(label1);
            Name = "Frm_ConsultasCuentasPorCobrar";
            Text = "Consultas cuentas por cobrar";
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DgvConsulta;
        private ComboBox CmbPersona;
        private Label label2;
        private Button BttMenu;
        private Button BttHabilitar;
    }
}