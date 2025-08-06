namespace Capa_Presentacion
{
    partial class Frm_AgregarPersonas
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
            TxtNombre = new TextBox();
            TxtSegundoApellido = new TextBox();
            TxtPrimerApellido = new TextBox();
            BttMenu = new Button();
            BttGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 0;
            label1.Text = "Agregar Persona";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(16, 158);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 1;
            label2.Text = "Segundo Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(16, 112);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Primer Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(16, 60);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombre";
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            TxtNombre.Location = new Point(188, 66);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(128, 24);
            TxtNombre.TabIndex = 4;
            // 
            // TxtSegundoApellido
            // 
            TxtSegundoApellido.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            TxtSegundoApellido.Location = new Point(188, 158);
            TxtSegundoApellido.Name = "TxtSegundoApellido";
            TxtSegundoApellido.Size = new Size(128, 24);
            TxtSegundoApellido.TabIndex = 5;
            // 
            // TxtPrimerApellido
            // 
            TxtPrimerApellido.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            TxtPrimerApellido.Location = new Point(188, 109);
            TxtPrimerApellido.Name = "TxtPrimerApellido";
            TxtPrimerApellido.Size = new Size(128, 24);
            TxtPrimerApellido.TabIndex = 6;
            // 
            // BttMenu
            // 
            BttMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BttMenu.Location = new Point(112, 235);
            BttMenu.Name = "BttMenu";
            BttMenu.Size = new Size(75, 23);
            BttMenu.TabIndex = 7;
            BttMenu.Text = "Menu";
            BttMenu.UseVisualStyleBackColor = true;
            BttMenu.Click += BttMenu_Click;
            // 
            // BttGuardar
            // 
            BttGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BttGuardar.Location = new Point(226, 235);
            BttGuardar.Name = "BttGuardar";
            BttGuardar.Size = new Size(75, 23);
            BttGuardar.TabIndex = 8;
            BttGuardar.Text = "Guardar";
            BttGuardar.UseVisualStyleBackColor = true;
            BttGuardar.Click += BttGuardar_Click;
            // 
            // Frm_AgregarPersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(415, 270);
            Controls.Add(BttGuardar);
            Controls.Add(BttMenu);
            Controls.Add(TxtPrimerApellido);
            Controls.Add(TxtSegundoApellido);
            Controls.Add(TxtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_AgregarPersonas";
            Text = "Agregar Personas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtNombre;
        private TextBox TxtSegundoApellido;
        private TextBox TxtPrimerApellido;
        private Button BttMenu;
        private Button BttGuardar;
    }
}