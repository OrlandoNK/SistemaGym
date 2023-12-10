namespace SistemaGym.UI.Windows
{
    partial class mantenimientoFacturaMembresia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mantenimientoFacturaMembresia));
            panel1 = new Panel();
            btnCerrar = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            btnEliminar = new Button();
            btnGuardar = new Button();
            dgvFacturaMembresia = new DataGridView();
            panel4 = new Panel();
            TxbIDCliente = new ComboBox();
            this.TxbIDMembresia = new ComboBox();
            TxbCargoDebito = new ComboBox();
            TxbCargoCredito = new ComboBox();
            btnAgregar = new Button();
            TxbNCF = new TextBox();
            TxbValorFactura = new TextBox();
            label2 = new Label();
            label9 = new Label();
            label1 = new Label();
            dtpFechaEmision = new DateTimePicker();
            lblIDMembresia = new Label();
            label8 = new Label();
            dtpFechaVencimiento = new DateTimePicker();
            label7 = new Label();
            TxbEstatus = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label10 = new Label();
            TxbIDFactura = new TextBox();
            TxbIDUsuario = new ComboBox();
            IDFactura = new DataGridViewTextBoxColumn();
            IDMembresia = new DataGridViewComboBoxColumn();
            IDCliente = new DataGridViewComboBoxColumn();
            IDUsuario = new DataGridViewComboBoxColumn();
            CargoCredito = new DataGridViewComboBoxColumn();
            CargoDebito = new DataGridViewComboBoxColumn();
            NCF = new DataGridViewTextBoxColumn();
            ValorFactura = new DataGridViewTextBoxColumn();
            FechaEmision = new DataGridViewTextBoxColumn();
            FechaVencimiento = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturaMembresia).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 61);
            panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(974, 6);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(56, 48);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 2;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(1042, 23);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(1042, 479);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(btnEliminar);
            panel5.Controls.Add(btnGuardar);
            panel5.Controls.Add(dgvFacturaMembresia);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(363, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(679, 479);
            panel5.TabIndex = 24;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.Black;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Gold;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Gold;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(567, 398);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 56);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.Black;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Gold;
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.Gold;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(455, 398);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 56);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dgvFacturaMembresia
            // 
            dgvFacturaMembresia.AllowUserToAddRows = false;
            dgvFacturaMembresia.AllowUserToDeleteRows = false;
            dgvFacturaMembresia.Anchor = AnchorStyles.None;
            dgvFacturaMembresia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvFacturaMembresia.BackgroundColor = Color.White;
            dgvFacturaMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturaMembresia.Columns.AddRange(new DataGridViewColumn[] { IDFactura, IDMembresia, IDCliente, IDUsuario, CargoCredito, CargoDebito, NCF, ValorFactura, FechaEmision, FechaVencimiento, Estatus });
            dgvFacturaMembresia.Location = new Point(0, 61);
            dgvFacturaMembresia.Name = "dgvFacturaMembresia";
            dgvFacturaMembresia.ReadOnly = true;
            dgvFacturaMembresia.RowHeadersVisible = false;
            dgvFacturaMembresia.RowTemplate.Height = 25;
            dgvFacturaMembresia.Size = new Size(679, 331);
            dgvFacturaMembresia.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGoldenrodYellow;
            panel4.Controls.Add(TxbIDUsuario);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(TxbIDFactura);
            panel4.Controls.Add(TxbIDCliente);
            panel4.Controls.Add(this.TxbIDMembresia);
            panel4.Controls.Add(TxbCargoDebito);
            panel4.Controls.Add(TxbCargoCredito);
            panel4.Controls.Add(btnAgregar);
            panel4.Controls.Add(TxbNCF);
            panel4.Controls.Add(TxbValorFactura);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(dtpFechaEmision);
            panel4.Controls.Add(lblIDMembresia);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(dtpFechaVencimiento);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(TxbEstatus);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(363, 479);
            panel4.TabIndex = 23;
            // 
            // TxbIDCliente
            // 
            TxbIDCliente.FormattingEnabled = true;
            TxbIDCliente.Location = new Point(184, 139);
            TxbIDCliente.Name = "TxbIDCliente";
            TxbIDCliente.Size = new Size(156, 23);
            TxbIDCliente.TabIndex = 24;
            // 
            // TxbIDMembresia
            // 
            this.TxbIDMembresia.FormattingEnabled = true;
            this.TxbIDMembresia.Location = new Point(22, 139);
            this.TxbIDMembresia.Name = "TxbIDMembresia";
            this.TxbIDMembresia.Size = new Size(156, 23);
            this.TxbIDMembresia.TabIndex = 23;
            // 
            // TxbCargoDebito
            // 
            TxbCargoDebito.FormattingEnabled = true;
            TxbCargoDebito.Location = new Point(184, 207);
            TxbCargoDebito.Name = "TxbCargoDebito";
            TxbCargoDebito.Size = new Size(156, 23);
            TxbCargoDebito.TabIndex = 22;
            // 
            // TxbCargoCredito
            // 
            TxbCargoCredito.FormattingEnabled = true;
            TxbCargoCredito.Location = new Point(22, 207);
            TxbCargoCredito.Name = "TxbCargoCredito";
            TxbCargoCredito.Size = new Size(156, 23);
            TxbCargoCredito.TabIndex = 21;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Black;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = Color.Gold;
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.Gold;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleRight;
            btnAgregar.Location = new Point(242, 398);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 39);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "&Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // TxbNCF
            // 
            TxbNCF.Location = new Point(22, 273);
            TxbNCF.Name = "TxbNCF";
            TxbNCF.Size = new Size(156, 23);
            TxbNCF.TabIndex = 5;
            // 
            // TxbValorFactura
            // 
            TxbValorFactura.Location = new Point(184, 273);
            TxbValorFactura.Name = "TxbValorFactura";
            TxbValorFactura.Size = new Size(156, 23);
            TxbValorFactura.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Location = new Point(184, 35);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 12;
            label2.Text = "IDUsuario";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Location = new Point(22, 388);
            label9.Name = "label9";
            label9.Size = new Size(156, 23);
            label9.TabIndex = 19;
            label9.Text = "Estatus";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Location = new Point(184, 113);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 11;
            label1.Text = "IDCliente";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpFechaEmision
            // 
            dtpFechaEmision.Format = DateTimePickerFormat.Short;
            dtpFechaEmision.Location = new Point(22, 341);
            dtpFechaEmision.Name = "dtpFechaEmision";
            dtpFechaEmision.Size = new Size(156, 23);
            dtpFechaEmision.TabIndex = 7;
            // 
            // lblIDMembresia
            // 
            lblIDMembresia.Anchor = AnchorStyles.None;
            lblIDMembresia.Location = new Point(22, 113);
            lblIDMembresia.Name = "lblIDMembresia";
            lblIDMembresia.Size = new Size(100, 23);
            lblIDMembresia.TabIndex = 10;
            lblIDMembresia.Text = "IDMembresia";
            lblIDMembresia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Location = new Point(184, 315);
            label8.Name = "label8";
            label8.Size = new Size(156, 23);
            label8.TabIndex = 18;
            label8.Text = "Fecha de Vencimiento";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Format = DateTimePickerFormat.Short;
            dtpFechaVencimiento.Location = new Point(184, 341);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(156, 23);
            dtpFechaVencimiento.TabIndex = 8;
            // 
            // label7
            // 
            label7.Location = new Point(22, 315);
            label7.Name = "label7";
            label7.Size = new Size(156, 23);
            label7.TabIndex = 17;
            label7.Text = "Fecha de Emision";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbEstatus
            // 
            TxbEstatus.FormattingEnabled = true;
            TxbEstatus.Location = new Point(22, 414);
            TxbEstatus.Name = "TxbEstatus";
            TxbEstatus.Size = new Size(156, 23);
            TxbEstatus.TabIndex = 9;
            // 
            // label6
            // 
            label6.Location = new Point(184, 247);
            label6.Name = "label6";
            label6.Size = new Size(156, 23);
            label6.TabIndex = 16;
            label6.Text = "Valor de Factura";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(22, 181);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 13;
            label3.Text = "CargoCredito";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(22, 247);
            label5.Name = "label5";
            label5.Size = new Size(156, 23);
            label5.TabIndex = 15;
            label5.Text = "NCF";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new Point(184, 181);
            label4.Name = "label4";
            label4.Size = new Size(156, 23);
            label4.TabIndex = 14;
            label4.Text = "CargoDebito";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.Location = new Point(22, 35);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 26;
            label10.Text = "IDFactura";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbIDFactura
            // 
            TxbIDFactura.Anchor = AnchorStyles.None;
            TxbIDFactura.Location = new Point(22, 61);
            TxbIDFactura.Name = "TxbIDFactura";
            TxbIDFactura.ReadOnly = true;
            TxbIDFactura.Size = new Size(100, 23);
            TxbIDFactura.TabIndex = 25;
            // 
            // TxbIDUsuario
            // 
            TxbIDUsuario.FormattingEnabled = true;
            TxbIDUsuario.Location = new Point(184, 61);
            TxbIDUsuario.Name = "TxbIDUsuario";
            TxbIDUsuario.Size = new Size(156, 23);
            TxbIDUsuario.TabIndex = 27;
            // 
            // IDFactura
            // 
            IDFactura.HeaderText = "IDFactura";
            IDFactura.Name = "IDFactura";
            IDFactura.ReadOnly = true;
            IDFactura.Width = 82;
            // 
            // IDMembresia
            // 
            IDMembresia.HeaderText = "IDMembresia";
            IDMembresia.Name = "IDMembresia";
            IDMembresia.ReadOnly = true;
            IDMembresia.Resizable = DataGridViewTriState.True;
            IDMembresia.SortMode = DataGridViewColumnSortMode.Automatic;
            IDMembresia.Width = 102;
            // 
            // IDCliente
            // 
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            IDCliente.ReadOnly = true;
            IDCliente.Resizable = DataGridViewTriState.True;
            IDCliente.SortMode = DataGridViewColumnSortMode.Automatic;
            IDCliente.Width = 80;
            // 
            // IDUsuario
            // 
            IDUsuario.HeaderText = "IDUsuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.ReadOnly = true;
            IDUsuario.Resizable = DataGridViewTriState.True;
            IDUsuario.SortMode = DataGridViewColumnSortMode.Automatic;
            IDUsuario.Width = 83;
            // 
            // CargoCredito
            // 
            CargoCredito.HeaderText = "CargoCredito";
            CargoCredito.Name = "CargoCredito";
            CargoCredito.ReadOnly = true;
            CargoCredito.Resizable = DataGridViewTriState.True;
            CargoCredito.SortMode = DataGridViewColumnSortMode.Automatic;
            CargoCredito.Width = 103;
            // 
            // CargoDebito
            // 
            CargoDebito.HeaderText = "CargoDebito";
            CargoDebito.Name = "CargoDebito";
            CargoDebito.ReadOnly = true;
            CargoDebito.Resizable = DataGridViewTriState.True;
            CargoDebito.SortMode = DataGridViewColumnSortMode.Automatic;
            CargoDebito.Width = 99;
            // 
            // NCF
            // 
            NCF.HeaderText = "NCF";
            NCF.Name = "NCF";
            NCF.ReadOnly = true;
            NCF.Width = 55;
            // 
            // ValorFactura
            // 
            ValorFactura.HeaderText = "ValorFactura";
            ValorFactura.Name = "ValorFactura";
            ValorFactura.ReadOnly = true;
            ValorFactura.Width = 97;
            // 
            // FechaEmision
            // 
            FechaEmision.HeaderText = "FechaEmision";
            FechaEmision.Name = "FechaEmision";
            FechaEmision.ReadOnly = true;
            FechaEmision.Width = 105;
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.HeaderText = "FechaVencimiento";
            FechaVencimiento.Name = "FechaVencimiento";
            FechaVencimiento.ReadOnly = true;
            FechaVencimiento.Width = 129;
            // 
            // Estatus
            // 
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            Estatus.Width = 69;
            // 
            // mantenimientoFacturaMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 563);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mantenimientoFacturaMembresia";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFacturaMembresia).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnCerrar;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Label lblIDMembresia;
        private ComboBox TxbEstatus;
        private DateTimePicker dtpFechaVencimiento;
        private DateTimePicker dtpFechaEmision;
        private TextBox TxbValorFactura;
        private TextBox TxbNCF;
        private TextBox textBox3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private Panel panel5;
        private DataGridView dgvFacturaMembresia;
        private Button btnAgregar;
        private Button btnGuardar;
        private Button btnEliminar;
        private ComboBox TxbCargoDebito;
        private ComboBox TxbCargoCredito;
        private ComboBox TxbIDCliente;
        private ComboBox comboBox2;
        private Label label10;
        private TextBox TxbIDFactura;
        private ComboBox TxbIDUsuario;
        private DataGridViewTextBoxColumn IDFactura;
        private DataGridViewComboBoxColumn IDMembresia;
        private DataGridViewComboBoxColumn IDCliente;
        private DataGridViewComboBoxColumn IDUsuario;
        private DataGridViewComboBoxColumn CargoCredito;
        private DataGridViewComboBoxColumn CargoDebito;
        private DataGridViewTextBoxColumn NCF;
        private DataGridViewTextBoxColumn ValorFactura;
        private DataGridViewTextBoxColumn FechaEmision;
        private DataGridViewTextBoxColumn FechaVencimiento;
        private DataGridViewTextBoxColumn Estatus;
    }
}