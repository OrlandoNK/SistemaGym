﻿namespace SistemaGym.UI.Windows
{
    partial class frmMembresia
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtID = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new RichTextBox();
            txtDuracion = new TextBox();
            txtValor = new TextBox();
            dgvMembresia = new DataGridView();
            cbEstatus = new ComboBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            errorProvider = new ErrorProvider(components);
            dtpFechaCreacion = new DateTimePicker();
            IDMembresia = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMembresia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 62);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Membresia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 90);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 118);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 179);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Duracion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 212);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Valor $";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 246);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha Creacion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 277);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 6;
            label7.Text = "Estatus";
            // 
            // txtID
            // 
            txtID.Location = new Point(154, 54);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(28, 23);
            txtID.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(154, 84);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 21);
            txtNombre.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(154, 111);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(156, 47);
            txtDescripcion.TabIndex = 9;
            txtDescripcion.Text = "";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(154, 173);
            txtDuracion.Multiline = true;
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(100, 21);
            txtDuracion.TabIndex = 10;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(154, 212);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 21);
            txtValor.TabIndex = 11;
            // 
            // dgvMembresia
            // 
            dgvMembresia.AllowUserToAddRows = false;
            dgvMembresia.AllowUserToDeleteRows = false;
            dgvMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembresia.Columns.AddRange(new DataGridViewColumn[] { IDMembresia, Nombre, Descripcion, Duracion, Valor, FechaCreacion, Estatus });
            dgvMembresia.Location = new Point(316, 54);
            dgvMembresia.Name = "dgvMembresia";
            dgvMembresia.ReadOnly = true;
            dgvMembresia.RowTemplate.Height = 25;
            dgvMembresia.Size = new Size(741, 356);
            dgvMembresia.TabIndex = 14;
            dgvMembresia.CellClick += dgvMembresia_CellClick;
            // 
            // cbEstatus
            // 
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbEstatus.Location = new Point(154, 277);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(100, 23);
            cbEstatus.TabIndex = 16;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(48, 332);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 17;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(129, 332);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(210, 332);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // dtpFechaCreacion
            // 
            dtpFechaCreacion.Location = new Point(152, 248);
            dtpFechaCreacion.Name = "dtpFechaCreacion";
            dtpFechaCreacion.Size = new Size(158, 23);
            dtpFechaCreacion.TabIndex = 20;
            // 
            // IDMembresia
            // 
            IDMembresia.DataPropertyName = "IDMembresia";
            IDMembresia.HeaderText = "ID Membresia";
            IDMembresia.Name = "IDMembresia";
            IDMembresia.ReadOnly = true;
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
            // Duracion
            // 
            Duracion.DataPropertyName = "Duracion";
            Duracion.HeaderText = "Duracion";
            Duracion.Name = "Duracion";
            Duracion.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            Valor.DefaultCellStyle = dataGridViewCellStyle1;
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            FechaCreacion.DataPropertyName = "FechaCreacion";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            FechaCreacion.DefaultCellStyle = dataGridViewCellStyle2;
            FechaCreacion.HeaderText = "Fecha Creacion";
            FechaCreacion.Name = "FechaCreacion";
            FechaCreacion.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // frmMembresia
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1065, 530);
            Controls.Add(dtpFechaCreacion);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(cbEstatus);
            Controls.Add(dgvMembresia);
            Controls.Add(txtValor);
            Controls.Add(txtDuracion);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmMembresia";
            Text = "Membresias";
            Load += frmMembresia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembresia).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtID;
        private TextBox txtNombre;
        private RichTextBox txtDescripcion;
        private TextBox txtDuracion;
        private TextBox txtValor;
        private DataGridView dgvMembresia;
        private ComboBox cbEstatus;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnCancelar;
        private ErrorProvider errorProvider;
        private DateTimePicker dtpFechaCreacion;
        private DataGridViewTextBoxColumn IDMembresia;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn FechaCreacion;
        private DataGridViewTextBoxColumn Estatus;
    }
}