namespace SistemaGym.UI.Windows
{
    partial class frmTipoActividades
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIDTipoActividad = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            btnNuevo = new Button();
            btnCancelar = new Button();
            dgvTipoActividades = new DataGridView();
            IDTipoActividad = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvTipoActividades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 30);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "ID TipoActividad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 80);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 137);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // txtIDTipoActividad
            // 
            txtIDTipoActividad.Location = new Point(172, 27);
            txtIDTipoActividad.Name = "txtIDTipoActividad";
            txtIDTipoActividad.Size = new Size(44, 23);
            txtIDTipoActividad.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(172, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(172, 137);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(141, 231);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(15, 231);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(264, 231);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvTipoActividades
            // 
            dgvTipoActividades.AllowUserToAddRows = false;
            dgvTipoActividades.AllowUserToDeleteRows = false;
            dgvTipoActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoActividades.Columns.AddRange(new DataGridViewColumn[] { IDTipoActividad, Nombre, Descripcion });
            dgvTipoActividades.Location = new Point(362, 41);
            dgvTipoActividades.Name = "dgvTipoActividades";
            dgvTipoActividades.ReadOnly = true;
            dgvTipoActividades.RowTemplate.Height = 25;
            dgvTipoActividades.Size = new Size(383, 246);
            dgvTipoActividades.TabIndex = 9;
            dgvTipoActividades.CellContentClick += dgvTipoActividades_CellContentClick;
            // 
            // IDTipoActividad
            // 
            IDTipoActividad.HeaderText = "IDTipoActividad";
            IDTipoActividad.Name = "IDTipoActividad";
            IDTipoActividad.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmTipoActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTipoActividades);
            Controls.Add(btnCancelar);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtIDTipoActividad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTipoActividades";
            Text = "frmTipoActividades";
            ((System.ComponentModel.ISupportInitialize)dgvTipoActividades).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIDTipoActividad;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Button btnGuardar;
        private Button btnNuevo;
        private Button btnCancelar;
        private DataGridView dgvTipoActividades;
        private DataGridViewTextBoxColumn IDTipoActividad;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private ErrorProvider errorProvider1;
    }
}