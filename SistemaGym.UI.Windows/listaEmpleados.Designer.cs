namespace SistemaGym.UI.Windows
{
    partial class listaEmpleados
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnclose = new PictureBox();
            panel2 = new Panel();
            panel5 = new Panel();
            TxbBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            panel3 = new Panel();
            dgvEmpleados = new DataGridView();
            IDEmpleado = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            TellCell = new DataGridViewTextBoxColumn();
            TellRes = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnclose).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnclose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 62);
            panel1.TabIndex = 0;
            // 
            // btnclose
            // 
            btnclose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnclose.Cursor = Cursors.Hand;
            btnclose.Image = Properties.Resources._BotonXcerrarVentana;
            btnclose.Location = new Point(813, 14);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(32, 32);
            btnclose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnclose.TabIndex = 1;
            btnclose.TabStop = false;
            btnclose.Click += btnclose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(858, 33);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(TxbBuscar);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 95);
            panel5.Name = "panel5";
            panel5.Size = new Size(858, 68);
            panel5.TabIndex = 124;
            // 
            // TxbBuscar
            // 
            TxbBuscar.BorderRadius = 20;
            TxbBuscar.CustomizableEdges = customizableEdges5;
            TxbBuscar.DefaultText = "";
            TxbBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbBuscar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.IconLeft = Properties.Resources._BusquedaBar__;
            TxbBuscar.Location = new Point(8, 14);
            TxbBuscar.Name = "TxbBuscar";
            TxbBuscar.PasswordChar = '\0';
            TxbBuscar.PlaceholderForeColor = Color.Silver;
            TxbBuscar.PlaceholderText = "Buscar";
            TxbBuscar.SelectedText = "";
            TxbBuscar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TxbBuscar.Size = new Size(822, 39);
            TxbBuscar.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dgvEmpleados);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(858, 369);
            panel3.TabIndex = 125;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvEmpleados.BackgroundColor = Color.WhiteSmoke;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { IDEmpleado, Nombre, Apellido, TipoDocumento, Documento, Direccion, TellCell, TellRes, FechaRegistro, Estatus });
            dgvEmpleados.Dock = DockStyle.Fill;
            dgvEmpleados.Location = new Point(0, 0);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.RowTemplate.Height = 25;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(856, 367);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.CellDoubleClick += dgvEmpleados_CellDoubleClick;
            // 
            // IDEmpleado
            // 
            IDEmpleado.DataPropertyName = "IDEmpleado";
            IDEmpleado.HeaderText = "IDEmpleado";
            IDEmpleado.Name = "IDEmpleado";
            IDEmpleado.ReadOnly = true;
            IDEmpleado.Width = 96;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 76;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 76;
            // 
            // TipoDocumento
            // 
            TipoDocumento.DataPropertyName = "TipoDocumento";
            TipoDocumento.HeaderText = "TipoDocumento";
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.ReadOnly = true;
            TipoDocumento.Width = 118;
            // 
            // Documento
            // 
            Documento.DataPropertyName = "Documento";
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 95;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            Direccion.Width = 82;
            // 
            // TellCell
            // 
            TellCell.DataPropertyName = "TellCell";
            TellCell.HeaderText = "TellCell";
            TellCell.Name = "TellCell";
            TellCell.ReadOnly = true;
            TellCell.Width = 69;
            // 
            // TellRes
            // 
            TellRes.DataPropertyName = "TellRes";
            TellRes.HeaderText = "TellRes";
            TellRes.Name = "TellRes";
            TellRes.ReadOnly = true;
            TellRes.Width = 67;
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
            // listaEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 532);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "listaEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "listaEmpleados";
            Load += listaEmpleados_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnclose).EndInit();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox TxbBuscar;
        private PictureBox btnclose;
        private Panel panel3;
        private DataGridView dgvEmpleados;
        private DataGridViewTextBoxColumn IDEmpleado;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn TellCell;
        private DataGridViewTextBoxColumn TellRes;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estatus;
    }
}