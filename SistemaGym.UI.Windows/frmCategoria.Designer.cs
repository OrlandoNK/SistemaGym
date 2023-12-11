namespace SistemaGym.UI.Windows
{
    partial class frmCategoria
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
            dgvCategoria = new DataGridView();
            IDCategoria = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIDCategoria = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // dgvCategoria
            // 
            dgvCategoria.AllowUserToAddRows = false;
            dgvCategoria.AllowUserToDeleteRows = false;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Columns.AddRange(new DataGridViewColumn[] { IDCategoria, Nombre, Descripcion });
            dgvCategoria.Location = new Point(378, 33);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.ReadOnly = true;
            dgvCategoria.RowTemplate.Height = 25;
            dgvCategoria.Size = new Size(341, 299);
            dgvCategoria.TabIndex = 0;
            dgvCategoria.CellClick += dgvCategoria_CellClick;
            // 
            // IDCategoria
            // 
            IDCategoria.DataPropertyName = "IDCategoria";
            IDCategoria.HeaderText = "ID";
            IDCategoria.Name = "IDCategoria";
            IDCategoria.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(56, 335);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(151, 335);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(252, 335);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 98);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 141);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 177);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Descripcion";
            // 
            // txtIDCategoria
            // 
            txtIDCategoria.Location = new Point(126, 95);
            txtIDCategoria.Name = "txtIDCategoria";
            txtIDCategoria.Size = new Size(72, 23);
            txtIDCategoria.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(126, 141);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(126, 174);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 9;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 539);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtIDCategoria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvCategoria);
            Name = "frmCategoria";
            Text = "frmCategoria";
            Load += frmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategoria;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIDCategoria;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private DataGridViewTextBoxColumn IDCategoria;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private ErrorProvider errorProvider;
    }
}