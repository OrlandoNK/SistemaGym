﻿namespace SistemaGym.UI.Windows
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
            dgvListaCliente = new DataGridView();
            IdListaCliente = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Descripciones = new DataGridViewTextBoxColumn();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaCliente).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(48, 52);
            label.Name = "label";
            label.Size = new Size(79, 15);
            label.TabIndex = 0;
            label.Text = "IDListaCliente";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(48, 111);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // Descripcion
            // 
            Descripcion.AutoSize = true;
            Descripcion.Location = new Point(48, 173);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(69, 15);
            Descripcion.TabIndex = 2;
            Descripcion.Text = "Descripcion";
            // 
            // txtID
            // 
            txtID.Location = new Point(164, 52);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(164, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(164, 173);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dgvListaCliente
            // 
            dgvListaCliente.AllowUserToAddRows = false;
            dgvListaCliente.AllowUserToDeleteRows = false;
            dgvListaCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCliente.Columns.AddRange(new DataGridViewColumn[] { IdListaCliente, Nombres, Descripciones });
            dgvListaCliente.Location = new Point(301, 52);
            dgvListaCliente.Name = "dgvListaCliente";
            dgvListaCliente.ReadOnly = true;
            dgvListaCliente.RowHeadersVisible = false;
            dgvListaCliente.RowTemplate.Height = 25;
            dgvListaCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaCliente.Size = new Size(450, 188);
            dgvListaCliente.TabIndex = 6;
            dgvListaCliente.CellContentClick += dgvListaCliente_CellContentClick;
            // 
            // IdListaCliente
            // 
            IdListaCliente.DataPropertyName = "IDTipoListaCliente";
            IdListaCliente.HeaderText = "IdListaCliente";
            IdListaCliente.Name = "IdListaCliente";
            IdListaCliente.ReadOnly = true;
            // 
            // Nombres
            // 
            Nombres.DataPropertyName = "Nombre";
            Nombres.HeaderText = "Nombre";
            Nombres.Name = "Nombres";
            Nombres.ReadOnly = true;
            // 
            // Descripciones
            // 
            Descripciones.DataPropertyName = "Descripcion";
            Descripciones.HeaderText = "Descripcion";
            Descripciones.Name = "Descripciones";
            Descripciones.ReadOnly = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(454, 246);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(95, 30);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(555, 246);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 30);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(656, 246);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 30);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmListaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvListaCliente);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(Descripcion);
            Controls.Add(Nombre);
            Controls.Add(label);
            Name = "frmListaCliente";
            Text = "frmListaCliente";
            Load += frmListaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaCliente).EndInit();
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
        private DataGridView dgvListaCliente;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridViewTextBoxColumn IdListaCliente;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Descripciones;
    }
}