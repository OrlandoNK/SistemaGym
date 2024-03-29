namespace SistemaGym.UI.Windows
{
    partial class mantenimientoListaClientes
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            panel3 = new Panel();
            dgvListaCliente = new DataGridView();
            IdListaCliente = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Descripciones = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaCliente).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(817, 33);
            panel2.TabIndex = 143;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 63);
            panel1.TabIndex = 142;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.Goldenrod;
            guna2HtmlLabel1.Location = new Point(73, 18);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(102, 25);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "Lista Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mantenimiento_TipoCliente_x32__;
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
            btnClose.Location = new Point(772, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 32, 39);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnRefresh);
            panel4.Controls.Add(btnNuevo);
            panel4.Controls.Add(btnEliminar);
            panel4.Controls.Add(btnEditar);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 96);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 462);
            panel4.TabIndex = 144;
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
            btnRefresh.Location = new Point(-1, 113);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(200, 45);
            btnRefresh.TabIndex = 139;
            btnRefresh.UseVisualStyleBackColor = true;
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
            btnNuevo.Location = new Point(-1, 62);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(200, 45);
            btnNuevo.TabIndex = 138;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
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
            btnEliminar.Location = new Point(-1, 215);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(200, 45);
            btnEliminar.TabIndex = 137;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
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
            btnEditar.Location = new Point(-1, 164);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(200, 45);
            btnEditar.TabIndex = 136;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(TxbBuscar);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(200, 96);
            panel5.Name = "panel5";
            panel5.Size = new Size(617, 63);
            panel5.TabIndex = 145;
            // 
            // TxbBuscar
            // 
            TxbBuscar.BorderRadius = 20;
            TxbBuscar.CustomizableEdges = customizableEdges3;
            TxbBuscar.DefaultText = "";
            TxbBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbBuscar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.IconLeft = Properties.Resources._BusquedaBar__;
            TxbBuscar.Location = new Point(2, 10);
            TxbBuscar.Name = "TxbBuscar";
            TxbBuscar.PasswordChar = '\0';
            TxbBuscar.PlaceholderForeColor = Color.Silver;
            TxbBuscar.PlaceholderText = "Buscar";
            TxbBuscar.SelectedText = "";
            TxbBuscar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TxbBuscar.Size = new Size(610, 41);
            TxbBuscar.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(dgvListaCliente);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 159);
            panel3.Name = "panel3";
            panel3.Size = new Size(617, 399);
            panel3.TabIndex = 146;
            // 
            // dgvListaCliente
            // 
            dgvListaCliente.AllowUserToAddRows = false;
            dgvListaCliente.AllowUserToDeleteRows = false;
            dgvListaCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaCliente.BackgroundColor = Color.WhiteSmoke;
            dgvListaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCliente.Columns.AddRange(new DataGridViewColumn[] { IdListaCliente, Nombres, Descripciones });
            dgvListaCliente.Location = new Point(0, 0);
            dgvListaCliente.Name = "dgvListaCliente";
            dgvListaCliente.ReadOnly = true;
            dgvListaCliente.RowHeadersVisible = false;
            dgvListaCliente.RowTemplate.Height = 25;
            dgvListaCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaCliente.Size = new Size(617, 399);
            dgvListaCliente.TabIndex = 7;
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
            // mantenimientoListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 558);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mantenimientoListaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Load += mantenimientoListaClientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private PictureBox pictureBox1;
        private PictureBox btnClose;
        private Panel panel4;
        private Button btnRefresh;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnEditar;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox TxbBuscar;
        private Panel panel3;
        private DataGridView dgvListaCliente;
        private DataGridViewTextBoxColumn IdListaCliente;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Descripciones;
    }
}