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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox1 = new ComboBox();
            lblIDMembresia = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            dgvFacturaMembresia = new DataGridView();
            btnAgregar = new Button();
            btnGuardar = new Button();
            IDFactura = new DataGridViewTextBoxColumn();
            IDMembresia = new DataGridViewTextBoxColumn();
            IDCliente = new DataGridViewTextBoxColumn();
            IDUsuario = new DataGridViewTextBoxColumn();
            CargoCredito = new DataGridViewTextBoxColumn();
            CargoDebito = new DataGridViewTextBoxColumn();
            NCF = new DataGridViewTextBoxColumn();
            ValorFactura = new DataGridViewTextBoxColumn();
            FechaEmision = new DataGridViewTextBoxColumn();
            FechaVencimiento = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturaMembresia).BeginInit();
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(166, 35);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(337, 35);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(508, 35);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(22, 113);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(156, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(184, 113);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(156, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(22, 190);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(156, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(184, 190);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(156, 23);
            textBox7.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(22, 272);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(156, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(184, 272);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(156, 23);
            dateTimePicker2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 369);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 23);
            comboBox1.TabIndex = 9;
            // 
            // lblIDMembresia
            // 
            lblIDMembresia.Anchor = AnchorStyles.None;
            lblIDMembresia.Location = new Point(166, 9);
            lblIDMembresia.Name = "lblIDMembresia";
            lblIDMembresia.Size = new Size(100, 23);
            lblIDMembresia.TabIndex = 10;
            lblIDMembresia.Text = "IDMembresia";
            lblIDMembresia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Location = new Point(337, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 11;
            label1.Text = "IDCliente";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Location = new Point(508, 9);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 12;
            label2.Text = "IDUsuario";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(22, 87);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 13;
            label3.Text = "CargoCredito";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new Point(184, 87);
            label4.Name = "label4";
            label4.Size = new Size(156, 23);
            label4.TabIndex = 14;
            label4.Text = "CargoDebito";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(22, 164);
            label5.Name = "label5";
            label5.Size = new Size(156, 23);
            label5.TabIndex = 15;
            label5.Text = "NCF";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new Point(184, 164);
            label6.Name = "label6";
            label6.Size = new Size(156, 23);
            label6.TabIndex = 16;
            label6.Text = "Valor de Factura";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Location = new Point(22, 246);
            label7.Name = "label7";
            label7.Size = new Size(156, 23);
            label7.TabIndex = 17;
            label7.Text = "Fecha de Emision";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Location = new Point(184, 246);
            label8.Name = "label8";
            label8.Size = new Size(156, 23);
            label8.TabIndex = 18;
            label8.Text = "Fecha de Vencimiento";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Location = new Point(22, 343);
            label9.Name = "label9";
            label9.Size = new Size(156, 23);
            label9.TabIndex = 19;
            label9.Text = "Estatus";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Gold;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gold;
            button1.Image = Properties.Resources.loupe_216463;
            button1.Location = new Point(272, 21);
            button1.Name = "button1";
            button1.Size = new Size(59, 49);
            button1.TabIndex = 20;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Black;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Gold;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Gold;
            button2.Image = Properties.Resources.loupe_216463;
            button2.Location = new Point(443, 21);
            button2.Name = "button2";
            button2.Size = new Size(59, 49);
            button2.TabIndex = 21;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.Black;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.Gold;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Gold;
            button3.Image = Properties.Resources.loupe_216463;
            button3.Location = new Point(614, 21);
            button3.Name = "button3";
            button3.Size = new Size(59, 49);
            button3.TabIndex = 22;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGoldenrodYellow;
            panel4.Controls.Add(btnAgregar);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(textBox6);
            panel4.Controls.Add(textBox7);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(dateTimePicker2);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(comboBox1);
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
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(btnEliminar);
            panel5.Controls.Add(btnGuardar);
            panel5.Controls.Add(dgvFacturaMembresia);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(lblIDMembresia);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(button1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(363, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(679, 479);
            panel5.TabIndex = 24;
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
            dgvFacturaMembresia.Location = new Point(0, 87);
            dgvFacturaMembresia.Name = "dgvFacturaMembresia";
            dgvFacturaMembresia.ReadOnly = true;
            dgvFacturaMembresia.RowHeadersVisible = false;
            dgvFacturaMembresia.RowTemplate.Height = 25;
            dgvFacturaMembresia.Size = new Size(679, 305);
            dgvFacturaMembresia.TabIndex = 23;
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
            btnAgregar.Location = new Point(184, 357);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(156, 35);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "&Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregar.UseVisualStyleBackColor = false;
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
            btnGuardar.Image = Properties.Resources.guardar_grupoMembresia;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(395, 398);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(136, 46);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
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
            IDMembresia.Width = 102;
            // 
            // IDCliente
            // 
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            IDCliente.ReadOnly = true;
            IDCliente.Width = 80;
            // 
            // IDUsuario
            // 
            IDUsuario.HeaderText = "IDUsuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.ReadOnly = true;
            IDUsuario.Width = 83;
            // 
            // CargoCredito
            // 
            CargoCredito.HeaderText = "CargoCredito";
            CargoCredito.Name = "CargoCredito";
            CargoCredito.ReadOnly = true;
            CargoCredito.Width = 103;
            // 
            // CargoDebito
            // 
            CargoDebito.HeaderText = "CargoDebito";
            CargoDebito.Name = "CargoDebito";
            CargoDebito.ReadOnly = true;
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
            btnEliminar.Image = Properties.Resources.eliminar_grupoMembresia;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(537, 398);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 46);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
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
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturaMembresia).EndInit();
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
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button3;
        private Button button2;
        private Panel panel4;
        private Panel panel5;
        private DataGridView dgvFacturaMembresia;
        private Button btnAgregar;
        private Button btnGuardar;
        private DataGridViewTextBoxColumn IDFactura;
        private DataGridViewTextBoxColumn IDMembresia;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewTextBoxColumn IDUsuario;
        private DataGridViewTextBoxColumn CargoCredito;
        private DataGridViewTextBoxColumn CargoDebito;
        private DataGridViewTextBoxColumn NCF;
        private DataGridViewTextBoxColumn ValorFactura;
        private DataGridViewTextBoxColumn FechaEmision;
        private DataGridViewTextBoxColumn FechaVencimiento;
        private DataGridViewTextBoxColumn Estatus;
        private Button btnEliminar;
    }
}