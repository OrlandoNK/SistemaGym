namespace SistemaGym.UI.Windows
{
    partial class MantenimientoTipoActividades
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
            lblIDTipoActividades = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dgvTipoActividades = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTipoActividades).BeginInit();
            SuspendLayout();
            // 
            // lblIDTipoActividades
            // 
            lblIDTipoActividades.AutoSize = true;
            lblIDTipoActividades.Location = new Point(34, 15);
            lblIDTipoActividades.Name = "lblIDTipoActividades";
            lblIDTipoActividades.Size = new Size(108, 15);
            lblIDTipoActividades.TabIndex = 0;
            lblIDTipoActividades.Text = "ID Tipo Actividades";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(34, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(34, 108);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(41, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 5;
            // 
            // dgvTipoActividades
            // 
            dgvTipoActividades.AllowUserToAddRows = false;
            dgvTipoActividades.AllowUserToDeleteRows = false;
            dgvTipoActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoActividades.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Descripcion });
            dgvTipoActividades.Location = new Point(398, 12);
            dgvTipoActividades.Name = "dgvTipoActividades";
            dgvTipoActividades.ReadOnly = true;
            dgvTipoActividades.RowTemplate.Height = 25;
            dgvTipoActividades.Size = new Size(379, 190);
            dgvTipoActividades.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(398, 333);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 40);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(510, 333);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 40);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(618, 333);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 40);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(715, 333);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 40);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
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
            // MantenimientoTipoActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 529);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvTipoActividades);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(lblIDTipoActividades);
            Name = "MantenimientoTipoActividades";
            Text = "MantenimientoTipoActividades";
            ((System.ComponentModel.ISupportInitialize)dgvTipoActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIDTipoActividades;
        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dgvTipoActividades;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
    }
}