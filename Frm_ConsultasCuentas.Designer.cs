namespace Capa_Presentacion
{
    partial class Frm_ConsultasCuentas
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
            label2 = new Label();
            LblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // DgvConsulta
            // 
            DgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConsulta.Location = new Point(12, 52);
            DgvConsulta.Name = "DgvConsulta";
            DgvConsulta.Size = new Size(757, 228);
            DgvConsulta.TabIndex = 0;
            // 
            // BttMenu
            // 
            BttMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BttMenu.Location = new Point(347, 309);
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(328, 25);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 2;
            label1.Text = "Consultas Cuentas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(536, 285);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 3;
            label2.Text = "Total:";
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblTotal.Location = new Point(615, 285);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(57, 21);
            LblTotal.TabIndex = 4;
            LblTotal.Text = "label3";
            // 
            // Frm_ConsultasCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(LblTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BttMenu);
            Controls.Add(DgvConsulta);
            Name = "Frm_ConsultasCuentas";
            Text = "Consultas Cuentas";
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvConsulta;
        private Button BttMenu;
        private Label label1;
        private Label label2;
        private Label LblTotal;
    }
}