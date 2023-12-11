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
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            btnBuscarMembresia = new Button();
            lblIDMembresia = new Label();
            TxbIDMembresia = new TextBox();
            label1 = new Label();
            TxbMembresia = new TextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            TxbDoc = new TextBox();
            btnBuscarCliente = new Button();
            TxbTipoDoc = new TextBox();
            label2 = new Label();
            TxbCliente = new TextBox();
            label3 = new Label();
            TxbIDCliente = new TextBox();
            groupBox3 = new GroupBox();
            label15 = new Label();
            TxbUsuarioID = new TextBox();
            btnAgregar = new Button();
            label14 = new Label();
            button2 = new Button();
            label13 = new Label();
            label12 = new Label();
            TxbValorFactura = new TextBox();
            TxbCargoDebito = new ComboBox();
            TxbCargoCredito = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            TxbEstatus = new ComboBox();
            label9 = new Label();
            dtpFechaVencimiento = new DateTimePicker();
            dtpFechaEmision = new DateTimePicker();
            label8 = new Label();
            TxbNCF = new TextBox();
            label7 = new Label();
            TxbUsuario = new TextBox();
            label6 = new Label();
            TxbIDFactura = new TextBox();
            panel3 = new Panel();
            btnGuardar = new Button();
            dgvFacturaMembresia = new DataGridView();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturaMembresia).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1240, 62);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(1240, 31);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnBuscarMembresia);
            groupBox1.Controls.Add(lblIDMembresia);
            groupBox1.Controls.Add(TxbIDMembresia);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxbMembresia);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(3, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 104);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Membresia";
            // 
            // btnBuscarMembresia
            // 
            btnBuscarMembresia.Anchor = AnchorStyles.None;
            btnBuscarMembresia.BackColor = Color.Black;
            btnBuscarMembresia.FlatAppearance.BorderColor = Color.Gold;
            btnBuscarMembresia.FlatAppearance.BorderSize = 2;
            btnBuscarMembresia.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnBuscarMembresia.FlatStyle = FlatStyle.Flat;
            btnBuscarMembresia.Image = Properties.Resources.loupe_216463;
            btnBuscarMembresia.Location = new Point(226, 33);
            btnBuscarMembresia.Name = "btnBuscarMembresia";
            btnBuscarMembresia.Size = new Size(56, 46);
            btnBuscarMembresia.TabIndex = 4;
            btnBuscarMembresia.UseVisualStyleBackColor = false;
            btnBuscarMembresia.Click += btnBuscarMembresia_Click;
            // 
            // lblIDMembresia
            // 
            lblIDMembresia.Anchor = AnchorStyles.None;
            lblIDMembresia.ForeColor = Color.Black;
            lblIDMembresia.Location = new Point(14, 33);
            lblIDMembresia.Name = "lblIDMembresia";
            lblIDMembresia.Size = new Size(100, 19);
            lblIDMembresia.TabIndex = 2;
            lblIDMembresia.Text = "IDMembresia";
            lblIDMembresia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbIDMembresia
            // 
            TxbIDMembresia.Anchor = AnchorStyles.None;
            TxbIDMembresia.ForeColor = Color.Black;
            TxbIDMembresia.Location = new Point(14, 55);
            TxbIDMembresia.Name = "TxbIDMembresia";
            TxbIDMembresia.ReadOnly = true;
            TxbIDMembresia.Size = new Size(100, 24);
            TxbIDMembresia.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(120, 33);
            label1.Name = "label1";
            label1.Size = new Size(100, 19);
            label1.TabIndex = 3;
            label1.Text = "Membresia";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbMembresia
            // 
            TxbMembresia.Anchor = AnchorStyles.None;
            TxbMembresia.ForeColor = Color.Black;
            TxbMembresia.Location = new Point(120, 55);
            TxbMembresia.Name = "TxbMembresia";
            TxbMembresia.ReadOnly = true;
            TxbMembresia.Size = new Size(100, 24);
            TxbMembresia.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(TxbDoc);
            groupBox2.Controls.Add(btnBuscarCliente);
            groupBox2.Controls.Add(TxbTipoDoc);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(TxbCliente);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(TxbIDCliente);
            groupBox2.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(306, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(597, 104);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Cliente";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(376, 29);
            label5.Name = "label5";
            label5.Size = new Size(131, 19);
            label5.TabIndex = 10;
            label5.Text = "Tipo Documento";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(239, 29);
            label4.Name = "label4";
            label4.Size = new Size(131, 19);
            label4.TabIndex = 8;
            label4.Text = "Documento";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbDoc
            // 
            TxbDoc.Anchor = AnchorStyles.None;
            TxbDoc.ForeColor = Color.Black;
            TxbDoc.Location = new Point(239, 51);
            TxbDoc.Name = "TxbDoc";
            TxbDoc.ReadOnly = true;
            TxbDoc.Size = new Size(131, 24);
            TxbDoc.TabIndex = 7;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Anchor = AnchorStyles.None;
            btnBuscarCliente.BackColor = Color.Black;
            btnBuscarCliente.FlatAppearance.BorderColor = Color.Gold;
            btnBuscarCliente.FlatAppearance.BorderSize = 2;
            btnBuscarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.Image = Properties.Resources.loupe_216463;
            btnBuscarCliente.Location = new Point(513, 29);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(56, 46);
            btnBuscarCliente.TabIndex = 5;
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // TxbTipoDoc
            // 
            TxbTipoDoc.Anchor = AnchorStyles.None;
            TxbTipoDoc.ForeColor = Color.Black;
            TxbTipoDoc.Location = new Point(376, 51);
            TxbTipoDoc.Name = "TxbTipoDoc";
            TxbTipoDoc.ReadOnly = true;
            TxbTipoDoc.Size = new Size(131, 24);
            TxbTipoDoc.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(133, 29);
            label2.Name = "label2";
            label2.Size = new Size(100, 19);
            label2.TabIndex = 6;
            label2.Text = "Cliente";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbCliente
            // 
            TxbCliente.Anchor = AnchorStyles.None;
            TxbCliente.ForeColor = Color.Black;
            TxbCliente.Location = new Point(133, 51);
            TxbCliente.Name = "TxbCliente";
            TxbCliente.ReadOnly = true;
            TxbCliente.Size = new Size(100, 24);
            TxbCliente.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(27, 29);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 5;
            label3.Text = "IDCliente";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbIDCliente
            // 
            TxbIDCliente.Anchor = AnchorStyles.None;
            TxbIDCliente.ForeColor = Color.Black;
            TxbIDCliente.Location = new Point(27, 51);
            TxbIDCliente.Name = "TxbIDCliente";
            TxbIDCliente.ReadOnly = true;
            TxbIDCliente.Size = new Size(100, 24);
            TxbIDCliente.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Black;
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(TxbUsuarioID);
            groupBox3.Controls.Add(btnAgregar);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(TxbValorFactura);
            groupBox3.Controls.Add(TxbCargoDebito);
            groupBox3.Controls.Add(TxbCargoCredito);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(TxbEstatus);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(dtpFechaVencimiento);
            groupBox3.Controls.Add(dtpFechaEmision);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(TxbNCF);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(TxbUsuario);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(TxbIDFactura);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.Gold;
            groupBox3.Location = new Point(909, 93);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(331, 555);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos de Factura";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.Location = new Point(31, 118);
            label15.Name = "label15";
            label15.Size = new Size(100, 19);
            label15.TabIndex = 30;
            label15.Text = "IDUsuario";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbUsuarioID
            // 
            TxbUsuarioID.Anchor = AnchorStyles.None;
            TxbUsuarioID.ForeColor = Color.Black;
            TxbUsuarioID.Location = new Point(31, 140);
            TxbUsuarioID.Name = "TxbUsuarioID";
            TxbUsuarioID.ReadOnly = true;
            TxbUsuarioID.Size = new Size(100, 24);
            TxbUsuarioID.TabIndex = 29;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.BackColor = Color.Black;
            btnAgregar.FlatAppearance.BorderColor = Color.Gold;
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Image = Properties.Resources.add_9794721__1_;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(31, 457);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(262, 46);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar Nuevo";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.Location = new Point(31, 392);
            label14.Name = "label14";
            label14.Size = new Size(128, 19);
            label14.TabIndex = 28;
            label14.Text = "ValorFactura";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderColor = Color.Gold;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.loupe_216463;
            button2.Location = new Point(244, 118);
            button2.Name = "button2";
            button2.Size = new Size(56, 46);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.Location = new Point(172, 322);
            label13.Name = "label13";
            label13.Size = new Size(128, 19);
            label13.TabIndex = 27;
            label13.Text = "CargoDebito";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.Location = new Point(31, 322);
            label12.Name = "label12";
            label12.Size = new Size(128, 19);
            label12.TabIndex = 26;
            label12.Text = "CargoCredito";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbValorFactura
            // 
            TxbValorFactura.Anchor = AnchorStyles.None;
            TxbValorFactura.ForeColor = Color.Black;
            TxbValorFactura.Location = new Point(31, 414);
            TxbValorFactura.Name = "TxbValorFactura";
            TxbValorFactura.Size = new Size(128, 24);
            TxbValorFactura.TabIndex = 25;
            // 
            // TxbCargoDebito
            // 
            TxbCargoDebito.Anchor = AnchorStyles.None;
            TxbCargoDebito.ForeColor = Color.Black;
            TxbCargoDebito.FormattingEnabled = true;
            TxbCargoDebito.Location = new Point(172, 344);
            TxbCargoDebito.Name = "TxbCargoDebito";
            TxbCargoDebito.Size = new Size(128, 27);
            TxbCargoDebito.TabIndex = 24;
            // 
            // TxbCargoCredito
            // 
            TxbCargoCredito.Anchor = AnchorStyles.None;
            TxbCargoCredito.ForeColor = Color.Black;
            TxbCargoCredito.FormattingEnabled = true;
            TxbCargoCredito.Location = new Point(31, 344);
            TxbCargoCredito.Name = "TxbCargoCredito";
            TxbCargoCredito.Size = new Size(128, 27);
            TxbCargoCredito.TabIndex = 23;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.Location = new Point(172, 392);
            label11.Name = "label11";
            label11.Size = new Size(128, 19);
            label11.TabIndex = 22;
            label11.Text = "Estatus";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.Location = new Point(172, 247);
            label10.Name = "label10";
            label10.Size = new Size(128, 19);
            label10.TabIndex = 20;
            label10.Text = "FechaVencimiento";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbEstatus
            // 
            TxbEstatus.Anchor = AnchorStyles.None;
            TxbEstatus.ForeColor = Color.Black;
            TxbEstatus.FormattingEnabled = true;
            TxbEstatus.Location = new Point(172, 414);
            TxbEstatus.Name = "TxbEstatus";
            TxbEstatus.Size = new Size(128, 27);
            TxbEstatus.TabIndex = 21;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.Location = new Point(31, 247);
            label9.Name = "label9";
            label9.Size = new Size(128, 19);
            label9.TabIndex = 19;
            label9.Text = "FechaEmision";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Anchor = AnchorStyles.None;
            dtpFechaVencimiento.Format = DateTimePickerFormat.Short;
            dtpFechaVencimiento.Location = new Point(172, 269);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(128, 24);
            dtpFechaVencimiento.TabIndex = 18;
            // 
            // dtpFechaEmision
            // 
            dtpFechaEmision.Anchor = AnchorStyles.None;
            dtpFechaEmision.Format = DateTimePickerFormat.Short;
            dtpFechaEmision.Location = new Point(31, 269);
            dtpFechaEmision.Name = "dtpFechaEmision";
            dtpFechaEmision.Size = new Size(128, 24);
            dtpFechaEmision.TabIndex = 17;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Location = new Point(31, 183);
            label8.Name = "label8";
            label8.Size = new Size(269, 19);
            label8.TabIndex = 16;
            label8.Text = "NCF";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbNCF
            // 
            TxbNCF.Anchor = AnchorStyles.None;
            TxbNCF.ForeColor = Color.Black;
            TxbNCF.Location = new Point(31, 205);
            TxbNCF.Name = "TxbNCF";
            TxbNCF.Size = new Size(269, 24);
            TxbNCF.TabIndex = 15;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Location = new Point(137, 118);
            label7.Name = "label7";
            label7.Size = new Size(100, 19);
            label7.TabIndex = 14;
            label7.Text = "Usuario";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbUsuario
            // 
            TxbUsuario.Anchor = AnchorStyles.None;
            TxbUsuario.ForeColor = Color.Black;
            TxbUsuario.Location = new Point(137, 140);
            TxbUsuario.Name = "TxbUsuario";
            TxbUsuario.ReadOnly = true;
            TxbUsuario.Size = new Size(100, 24);
            TxbUsuario.TabIndex = 13;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.Location = new Point(31, 52);
            label6.Name = "label6";
            label6.Size = new Size(100, 19);
            label6.TabIndex = 12;
            label6.Text = "IDFactura";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbIDFactura
            // 
            TxbIDFactura.Anchor = AnchorStyles.None;
            TxbIDFactura.ForeColor = Color.Black;
            TxbIDFactura.Location = new Point(31, 74);
            TxbIDFactura.Name = "TxbIDFactura";
            TxbIDFactura.ReadOnly = true;
            TxbIDFactura.Size = new Size(100, 24);
            TxbIDFactura.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(dgvFacturaMembresia);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(909, 555);
            panel3.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.Black;
            btnGuardar.FlatAppearance.BorderColor = Color.Gold;
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Image = Properties.Resources.guardar_grupoMembresia;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(3, 490);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(4, 0, 0, 0);
            btnGuardar.Size = new Size(193, 53);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dgvFacturaMembresia
            // 
            dgvFacturaMembresia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvFacturaMembresia.BackgroundColor = Color.White;
            dgvFacturaMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturaMembresia.Columns.AddRange(new DataGridViewColumn[] { IDFactura, IDMembresia, IDCliente, IDUsuario, CargoCredito, CargoDebito, NCF, ValorFactura, FechaEmision, FechaVencimiento, Estatus });
            dgvFacturaMembresia.Location = new Point(0, 183);
            dgvFacturaMembresia.Name = "dgvFacturaMembresia";
            dgvFacturaMembresia.RowHeadersVisible = false;
            dgvFacturaMembresia.RowTemplate.Height = 25;
            dgvFacturaMembresia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturaMembresia.Size = new Size(909, 301);
            dgvFacturaMembresia.TabIndex = 4;
            // 
            // IDFactura
            // 
            IDFactura.DataPropertyName = "IDFactura";
            IDFactura.HeaderText = "IDFactura";
            IDFactura.Name = "IDFactura";
            IDFactura.Width = 82;
            // 
            // IDMembresia
            // 
            IDMembresia.DataPropertyName = "IDMembresia";
            IDMembresia.HeaderText = "IDMembresia";
            IDMembresia.Name = "IDMembresia";
            IDMembresia.Resizable = DataGridViewTriState.True;
            IDMembresia.SortMode = DataGridViewColumnSortMode.Automatic;
            IDMembresia.Width = 102;
            // 
            // IDCliente
            // 
            IDCliente.DataPropertyName = "IDCliente";
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            IDCliente.Resizable = DataGridViewTriState.True;
            IDCliente.SortMode = DataGridViewColumnSortMode.Automatic;
            IDCliente.Width = 80;
            // 
            // IDUsuario
            // 
            IDUsuario.DataPropertyName = "IDUsuario";
            IDUsuario.HeaderText = "IDUsuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.Resizable = DataGridViewTriState.True;
            IDUsuario.SortMode = DataGridViewColumnSortMode.Automatic;
            IDUsuario.Width = 83;
            // 
            // CargoCredito
            // 
            CargoCredito.DataPropertyName = "CargoCredito";
            CargoCredito.HeaderText = "CargoCredito";
            CargoCredito.Name = "CargoCredito";
            CargoCredito.Resizable = DataGridViewTriState.True;
            CargoCredito.SortMode = DataGridViewColumnSortMode.Automatic;
            CargoCredito.Width = 103;
            // 
            // CargoDebito
            // 
            CargoDebito.DataPropertyName = "CargoDebito";
            CargoDebito.HeaderText = "CargoDebito";
            CargoDebito.Name = "CargoDebito";
            CargoDebito.Resizable = DataGridViewTriState.True;
            CargoDebito.SortMode = DataGridViewColumnSortMode.Automatic;
            CargoDebito.Width = 99;
            // 
            // NCF
            // 
            NCF.DataPropertyName = "NCF";
            NCF.HeaderText = "NCF";
            NCF.Name = "NCF";
            NCF.Width = 55;
            // 
            // ValorFactura
            // 
            ValorFactura.DataPropertyName = "ValorFactura";
            ValorFactura.HeaderText = "ValorFactura";
            ValorFactura.Name = "ValorFactura";
            ValorFactura.Width = 97;
            // 
            // FechaEmision
            // 
            FechaEmision.DataPropertyName = "FechaEmision";
            FechaEmision.HeaderText = "FechaEmision";
            FechaEmision.Name = "FechaEmision";
            FechaEmision.Width = 105;
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.DataPropertyName = "FechaVencimiento";
            FechaVencimiento.HeaderText = "FechaVencimiento";
            FechaVencimiento.Name = "FechaVencimiento";
            FechaVencimiento.Width = 129;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.Width = 69;
            // 
            // mantenimientoFacturaMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 648);
            Controls.Add(panel3);
            Controls.Add(groupBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Gold;
            FormBorderStyle = FormBorderStyle.None;
            Name = "mantenimientoFacturaMembresia";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFacturaMembresia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblIDMembresia;
        private TextBox TxbMembresia;
        private TextBox TxbIDMembresia;
        private Button btnBuscarMembresia;
        private GroupBox groupBox2;
        private TextBox TxbCliente;
        private TextBox TxbIDCliente;
        private Button btnBuscarCliente;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox TxbTipoDoc;
        private Label label4;
        private TextBox TxbDoc;
        private GroupBox groupBox3;
        private Label label10;
        private Label label9;
        private DateTimePicker dtpFechaVencimiento;
        private DateTimePicker dtpFechaEmision;
        private Label label8;
        private TextBox TxbNCF;
        private Button button2;
        private Label label7;
        private TextBox TxbUsuario;
        private Label label6;
        private TextBox TxbIDFactura;
        private Label label11;
        private ComboBox TxbEstatus;
        private Panel panel3;
        private DataGridView dgvFacturaMembresia;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox TxbValorFactura;
        private ComboBox TxbCargoDebito;
        private ComboBox TxbCargoCredito;
        private Button btnAgregar;
        private Button btnGuardar;
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
        private Label label15;
        private TextBox TxbUsuarioID;
    }
}