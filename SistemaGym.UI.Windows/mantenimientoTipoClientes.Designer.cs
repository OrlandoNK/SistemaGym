namespace SistemaGym.UI.Windows
{
    partial class mantenimientoTipoClientes
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            panel1 = new Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel4 = new Panel();
            btnRefresh = new Button();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            panel5 = new Panel();
            TxbBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            panel6 = new Panel();
            dgvTipoCliente = new DataGridView();
            IDTipoCliente = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoCliente).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(1085, 33);
            panel2.TabIndex = 141;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 63);
            panel1.TabIndex = 140;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.Goldenrod;
            guna2HtmlLabel1.Location = new Point(73, 18);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(128, 25);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "Tipo de Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.customer_experience_12948497;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(1040, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnRefresh);
            panel4.Controls.Add(btnNuevo);
            panel4.Controls.Add(btnEliminar);
            panel4.Controls.Add(btnEditar);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 96);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 589);
            panel4.TabIndex = 142;
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Image = Properties.Resources.refresh_8677771;
            btnRefresh.Location = new Point(-1, 181);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(200, 45);
            btnRefresh.TabIndex = 139;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Image = Properties.Resources._NewFacturaProduct;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(-1, 126);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(200, 45);
            btnNuevo.TabIndex = 138;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = Properties.Resources._EliminarFacturaMembresia;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(-1, 291);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(200, 45);
            btnEliminar.TabIndex = 137;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = Properties.Resources._EditarFacturaMembresia;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(-1, 236);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(200, 45);
            btnEditar.TabIndex = 136;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 32, 39);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(TxbBuscar);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(200, 96);
            panel5.Name = "panel5";
            panel5.Size = new Size(885, 63);
            panel5.TabIndex = 143;
            // 
            // TxbBuscar
            // 
            TxbBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxbBuscar.BorderRadius = 20;
            TxbBuscar.CustomizableEdges = customizableEdges7;
            TxbBuscar.DefaultText = "";
            TxbBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbBuscar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.IconLeft = Properties.Resources._BusquedaBar__;
            TxbBuscar.Location = new Point(9, 10);
            TxbBuscar.Name = "TxbBuscar";
            TxbBuscar.PasswordChar = '\0';
            TxbBuscar.PlaceholderForeColor = Color.Silver;
            TxbBuscar.PlaceholderText = "Buscar";
            TxbBuscar.SelectedText = "";
            TxbBuscar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            TxbBuscar.Size = new Size(864, 41);
            TxbBuscar.TabIndex = 0;
            TxbBuscar.TextChanged += TxbBuscar_TextChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(dgvTipoCliente);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(200, 159);
            panel6.Name = "panel6";
            panel6.Size = new Size(885, 526);
            panel6.TabIndex = 144;
            // 
            // dgvTipoCliente
            // 
            dgvTipoCliente.AllowUserToAddRows = false;
            dgvTipoCliente.AllowUserToDeleteRows = false;
            dgvTipoCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipoCliente.BackgroundColor = Color.White;
            dgvTipoCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoCliente.Columns.AddRange(new DataGridViewColumn[] { IDTipoCliente, Nombre, Descripcion, FechaCreacion });
            dgvTipoCliente.Dock = DockStyle.Fill;
            dgvTipoCliente.Location = new Point(0, 0);
            dgvTipoCliente.Name = "dgvTipoCliente";
            dgvTipoCliente.RowHeadersVisible = false;
            dgvTipoCliente.RowTemplate.Height = 25;
            dgvTipoCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTipoCliente.Size = new Size(883, 524);
            dgvTipoCliente.TabIndex = 134;
            // 
            // IDTipoCliente
            // 
            IDTipoCliente.DataPropertyName = "IDTipoCliente";
            IDTipoCliente.HeaderText = "IDTipoCliente";
            IDTipoCliente.Name = "IDTipoCliente";
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // FechaCreacion
            // 
            FechaCreacion.DataPropertyName = "FechaCreacion";
            FechaCreacion.HeaderText = "FechaCreacion";
            FechaCreacion.Name = "FechaCreacion";
            // 
            // mantenimientoTipoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 685);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mantenimientoTipoClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mantenimientoTipoClientes";
            Load += mantenimientoTipoClientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTipoCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private PictureBox btnClose;
        private Panel panel4;
        private Button btnEliminar;
        private Button btnEditar;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox TxbBuscar;
        private Panel panel6;
        private DataGridView dgvTipoCliente;
        private DataGridViewTextBoxColumn IDTipoCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn FechaCreacion;
        private Button btnRefresh;
        private Button btnNuevo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private PictureBox pictureBox1;
    }
}