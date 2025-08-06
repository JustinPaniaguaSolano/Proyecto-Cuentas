namespace Capa_Presentacion
{
    partial class Frm_AgregarCuentas
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
            TxtNombre = new TextBox();
            BttMenu = new Button();
            BttGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 22);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 0;
            label1.Text = "Agregar Cuentas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(11, 65);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre de la Cuenta:";
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            TxtNombre.Location = new Point(152, 56);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(166, 24);
            TxtNombre.TabIndex = 3;
            // 
            // BttMenu
            // 
            BttMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BttMenu.Location = new Point(62, 123);
            BttMenu.Name = "BttMenu";
            BttMenu.Size = new Size(75, 23);
            BttMenu.TabIndex = 4;
            BttMenu.Text = "Menu";
            BttMenu.UseVisualStyleBackColor = true;
            BttMenu.Click += BttMenu_Click;
            // 
            // BttGuardar
            // 
            BttGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BttGuardar.Location = new Point(222, 123);
            BttGuardar.Name = "BttGuardar";
            BttGuardar.Size = new Size(75, 23);
            BttGuardar.TabIndex = 5;
            BttGuardar.Text = "Guardar";
            BttGuardar.UseVisualStyleBackColor = true;
            BttGuardar.Click += BttGuardar_Click;
            // 
            // Frm_AgregarCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(330, 206);
            Controls.Add(BttGuardar);
            Controls.Add(BttMenu);
            Controls.Add(TxtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_AgregarCuentas";
            Text = "Agregar Cuentas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtNombre;
        private Button BttMenu;
        private Button BttGuardar;
    }
}