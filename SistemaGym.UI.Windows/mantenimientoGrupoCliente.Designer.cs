namespace SistemaGym.UI.Windows
{
    partial class mantenimientoGrupoCliente
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
            TxbIDGrupoMembresia = new TextBox();
            TxbIDCliente = new TextBox();
            lblIDGrupoMembresia = new Label();
            lblIDCliente = new Label();
            btnBuscarIDGrupoMembresia = new Button();
            btnBuscarIDCliente = new Button();
            dgvGrupoClientes = new DataGridView();
            IDGrupoCliente = new DataGridViewTextBoxColumn();
            IDGrupoMembresia = new DataGridViewTextBoxColumn();
            IDCliente = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnClose = new PictureBox();
            panel3 = new Panel();
            panel1 = new Panel();
            btnagregargrupomembresia = new Button();
            panel4 = new Panel();
            btnTraerClientes = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvGrupoClientes).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // TxbIDGrupoMembresia
            // 
            TxbIDGrupoMembresia.Anchor = AnchorStyles.None;
            TxbIDGrupoMembresia.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbIDGrupoMembresia.Location = new Point(21, 116);
            TxbIDGrupoMembresia.Name = "TxbIDGrupoMembresia";
            TxbIDGrupoMembresia.ReadOnly = true;
            TxbIDGrupoMembresia.Size = new Size(126, 23);
            TxbIDGrupoMembresia.TabIndex = 0;
            // 
            // TxbIDCliente
            // 
            TxbIDCliente.Anchor = AnchorStyles.None;
            TxbIDCliente.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbIDCliente.Location = new Point(21, 273);
            TxbIDCliente.Name = "TxbIDCliente";
            TxbIDCliente.ReadOnly = true;
            TxbIDCliente.Size = new Size(126, 23);
            TxbIDCliente.TabIndex = 1;
            // 
            // lblIDGrupoMembresia
            // 
            lblIDGrupoMembresia.Anchor = AnchorStyles.None;
            lblIDGrupoMembresia.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblIDGrupoMembresia.Location = new Point(21, 90);
            lblIDGrupoMembresia.Name = "lblIDGrupoMembresia";
            lblIDGrupoMembresia.Size = new Size(126, 23);
            lblIDGrupoMembresia.TabIndex = 2;
            lblIDGrupoMembresia.Text = "IDGrupoMembresia";
            lblIDGrupoMembresia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIDCliente
            // 
            lblIDCliente.Anchor = AnchorStyles.None;
            lblIDCliente.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblIDCliente.Location = new Point(21, 247);
            lblIDCliente.Name = "lblIDCliente";
            lblIDCliente.Size = new Size(126, 23);
            lblIDCliente.TabIndex = 3;
            lblIDCliente.Text = "IDCliente";
            lblIDCliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBuscarIDGrupoMembresia
            // 
            btnBuscarIDGrupoMembresia.Anchor = AnchorStyles.None;
            btnBuscarIDGrupoMembresia.BackColor = Color.Black;
            btnBuscarIDGrupoMembresia.Cursor = Cursors.Hand;
            btnBuscarIDGrupoMembresia.FlatAppearance.BorderColor = Color.Gold;
            btnBuscarIDGrupoMembresia.FlatAppearance.BorderSize = 2;
            btnBuscarIDGrupoMembresia.FlatAppearance.MouseOverBackColor = Color.LightYellow;
            btnBuscarIDGrupoMembresia.FlatStyle = FlatStyle.Flat;
            btnBuscarIDGrupoMembresia.Image = Properties.Resources.buscar__1_;
            btnBuscarIDGrupoMembresia.Location = new Point(153, 90);
            btnBuscarIDGrupoMembresia.Name = "btnBuscarIDGrupoMembresia";
            btnBuscarIDGrupoMembresia.Size = new Size(59, 49);
            btnBuscarIDGrupoMembresia.TabIndex = 4;
            btnBuscarIDGrupoMembresia.UseVisualStyleBackColor = false;
            btnBuscarIDGrupoMembresia.Click += btnBuscarIDGrupoMembresia_Click;
            // 
            // btnBuscarIDCliente
            // 
            btnBuscarIDCliente.Anchor = AnchorStyles.None;
            btnBuscarIDCliente.BackColor = Color.Black;
            btnBuscarIDCliente.Cursor = Cursors.Hand;
            btnBuscarIDCliente.FlatAppearance.BorderColor = Color.Gold;
            btnBuscarIDCliente.FlatAppearance.BorderSize = 2;
            btnBuscarIDCliente.FlatAppearance.MouseOverBackColor = Color.LightYellow;
            btnBuscarIDCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarIDCliente.Image = Properties.Resources.buscar__1_;
            btnBuscarIDCliente.Location = new Point(153, 247);
            btnBuscarIDCliente.Name = "btnBuscarIDCliente";
            btnBuscarIDCliente.Size = new Size(59, 49);
            btnBuscarIDCliente.TabIndex = 5;
            btnBuscarIDCliente.UseVisualStyleBackColor = false;
            btnBuscarIDCliente.Click += btnBuscarIDCliente_Click;
            // 
            // dgvGrupoClientes
            // 
            dgvGrupoClientes.AllowUserToAddRows = false;
            dgvGrupoClientes.AllowUserToDeleteRows = false;
            dgvGrupoClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvGrupoClientes.BackgroundColor = Color.White;
            dgvGrupoClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupoClientes.Columns.AddRange(new DataGridViewColumn[] { IDGrupoCliente, IDGrupoMembresia, IDCliente, FechaRegistro, Estatus });
            dgvGrupoClientes.Location = new Point(0, 88);
            dgvGrupoClientes.Name = "dgvGrupoClientes";
            dgvGrupoClientes.ReadOnly = true;
            dgvGrupoClientes.RowHeadersVisible = false;
            dgvGrupoClientes.RowTemplate.Height = 25;
            dgvGrupoClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrupoClientes.Size = new Size(490, 267);
            dgvGrupoClientes.TabIndex = 6;
            // 
            // IDGrupoCliente
            // 
            IDGrupoCliente.DataPropertyName = "IDGrupoCliente";
            IDGrupoCliente.HeaderText = "IDGrupoCliente";
            IDGrupoCliente.Name = "IDGrupoCliente";
            IDGrupoCliente.ReadOnly = true;
            IDGrupoCliente.Width = 113;
            // 
            // IDGrupoMembresia
            // 
            IDGrupoMembresia.DataPropertyName = "IDGrupoMembresia";
            IDGrupoMembresia.HeaderText = "IDGrupoMembresia";
            IDGrupoMembresia.Name = "IDGrupoMembresia";
            IDGrupoMembresia.ReadOnly = true;
            IDGrupoMembresia.Width = 135;
            // 
            // IDCliente
            // 
            IDCliente.DataPropertyName = "IDCliente";
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            IDCliente.ReadOnly = true;
            IDCliente.Width = 80;
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            FechaRegistro.Width = 106;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            Estatus.Width = 69;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 79);
            panel2.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.close_button__x64_;
            btnClose.Location = new Point(682, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(66, 61);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 7;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(760, 33);
            panel3.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.Controls.Add(btnagregargrupomembresia);
            panel1.Controls.Add(TxbIDCliente);
            panel1.Controls.Add(lblIDCliente);
            panel1.Controls.Add(btnBuscarIDGrupoMembresia);
            panel1.Controls.Add(TxbIDGrupoMembresia);
            panel1.Controls.Add(lblIDGrupoMembresia);
            panel1.Controls.Add(btnBuscarIDCliente);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 449);
            panel1.TabIndex = 10;
            // 
            // btnagregargrupomembresia
            // 
            btnagregargrupomembresia.BackColor = Color.Black;
            btnagregargrupomembresia.Cursor = Cursors.Hand;
            btnagregargrupomembresia.FlatAppearance.BorderColor = Color.Gold;
            btnagregargrupomembresia.FlatAppearance.BorderSize = 2;
            btnagregargrupomembresia.FlatAppearance.MouseOverBackColor = Color.LightYellow;
            btnagregargrupomembresia.FlatStyle = FlatStyle.Flat;
            btnagregargrupomembresia.Image = Properties.Resources.nuevaMembresia;
            btnagregargrupomembresia.Location = new Point(21, 145);
            btnagregargrupomembresia.Name = "btnagregargrupomembresia";
            btnagregargrupomembresia.Size = new Size(191, 36);
            btnagregargrupomembresia.TabIndex = 12;
            btnagregargrupomembresia.UseVisualStyleBackColor = false;
            btnagregargrupomembresia.Click += btnagregargrupomembresia_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnTraerClientes);
            panel4.Controls.Add(btnEliminar);
            panel4.Controls.Add(btnGuardar);
            panel4.Controls.Add(dgvGrupoClientes);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(270, 112);
            panel4.Name = "panel4";
            panel4.Size = new Size(490, 449);
            panel4.TabIndex = 11;
            // 
            // btnTraerClientes
            // 
            btnTraerClientes.Anchor = AnchorStyles.None;
            btnTraerClientes.BackColor = Color.Black;
            btnTraerClientes.Cursor = Cursors.Hand;
            btnTraerClientes.FlatAppearance.BorderColor = Color.Gold;
            btnTraerClientes.FlatAppearance.BorderSize = 2;
            btnTraerClientes.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;
            btnTraerClientes.FlatStyle = FlatStyle.Flat;
            btnTraerClientes.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTraerClientes.ForeColor = Color.Gold;
            btnTraerClientes.Image = Properties.Resources.traerMemberGrupo;
            btnTraerClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnTraerClientes.Location = new Point(266, 40);
            btnTraerClientes.Name = "btnTraerClientes";
            btnTraerClientes.Padding = new Padding(4, 0, 0, 0);
            btnTraerClientes.Size = new Size(218, 42);
            btnTraerClientes.TabIndex = 9;
            btnTraerClientes.Text = "&Traer Datos de Clientes";
            btnTraerClientes.TextAlign = ContentAlignment.MiddleRight;
            btnTraerClientes.UseVisualStyleBackColor = false;
            btnTraerClientes.Click += btnTraerClientes_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.Black;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Gold;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Gold;
            btnEliminar.Image = Properties.Resources.eliminar_grupoMembresia;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(367, 361);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(4, 0, 0, 0);
            btnEliminar.Size = new Size(117, 42);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.Black;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Gold;
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.Gold;
            btnGuardar.Image = Properties.Resources.guardar_grupoMembresia;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(244, 361);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(4, 0, 0, 0);
            btnGuardar.Size = new Size(117, 42);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // mantenimientoGrupoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 561);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mantenimientoGrupoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dgvGrupoClientes).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TxbIDGrupoMembresia;
        private TextBox TxbIDCliente;
        private Label lblIDGrupoMembresia;
        private Label lblIDCliente;
        private Button btnBuscarIDGrupoMembresia;
        private Button btnBuscarIDCliente;
        private DataGridView dgvGrupoClientes;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Panel panel4;
        private PictureBox btnClose;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnTraerClientes;
        private DataGridViewTextBoxColumn IDGrupoCliente;
        private DataGridViewTextBoxColumn IDGrupoMembresia;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estatus;
        private Button btnagregargrupomembresia;
        private ErrorProvider errorProvider;
    }
}