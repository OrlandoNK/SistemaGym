namespace SistemaGym.UI.Windows
{
    partial class frmListaCliente
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
            components = new System.ComponentModel.Container();
            label = new Label();
            Nombre = new Label();
            Descripcion = new Label();
            txtID = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            btnNuevo = new Button();
            btnGuardar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.Location = new Point(251, 151);
            label.Name = "label";
            label.Size = new Size(79, 23);
            label.TabIndex = 0;
            label.Text = "IDListaCliente";
            label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(251, 210);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(142, 23);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            Nombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Descripcion
            // 
            Descripcion.Location = new Point(251, 272);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(142, 23);
            Descripcion.TabIndex = 2;
            Descripcion.Text = "Descripcion";
            Descripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtID
            // 
            txtID.Location = new Point(251, 177);
            txtID.Name = "txtID";
            txtID.Size = new Size(79, 23);
            txtID.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(251, 236);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(142, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(251, 298);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(142, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(251, 349);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(142, 30);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(251, 385);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(142, 30);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 63);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(519, 33);
            panel2.TabIndex = 10;
            // 
            // frmListaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(Descripcion);
            Controls.Add(Nombre);
            Controls.Add(label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListaCliente";
            Text = "frmListaCliente";
            Load += frmListaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label Nombre;
        private Label Descripcion;
        private TextBox txtID;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private ErrorProvider errorProvider1;
        private Button btnGuardar;
        private Button btnNuevo;
        private Panel panel2;
        private Panel panel1;
    }
}