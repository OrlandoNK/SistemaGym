namespace SistemaGym.UI.Windows
{
    partial class listaClientes
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
            panel3 = new Panel();
            panel2 = new Panel();
            btnClose = new PictureBox();
            panel1 = new Panel();
            TxbBusqueda = new TextBox();
            panel4 = new Panel();
            dgvListaClientes = new DataGridView();
            IDCliente = new DataGridViewTextBoxColumn();
            IDUsuario = new DataGridViewTextBoxColumn();
            IDMembresia = new DataGridViewTextBoxColumn();
            TipoListaCliente = new DataGridViewTextBoxColumn();
            TipoCliente = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            TellCell = new DataGridViewTextBoxColumn();
            TellRes = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(731, 33);
            panel3.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(731, 79);
            panel2.TabIndex = 12;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.close_button__x64_;
            btnClose.Location = new Point(653, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(66, 61);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 7;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(TxbBusqueda);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 77);
            panel1.TabIndex = 14;
            // 
            // TxbBusqueda
            // 
            TxbBusqueda.Location = new Point(12, 18);
            TxbBusqueda.Multiline = true;
            TxbBusqueda.Name = "TxbBusqueda";
            TxbBusqueda.Size = new Size(719, 41);
            TxbBusqueda.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvListaClientes);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 189);
            panel4.Name = "panel4";
            panel4.Size = new Size(731, 352);
            panel4.TabIndex = 15;
            // 
            // dgvListaClientes
            // 
            dgvListaClientes.AllowUserToAddRows = false;
            dgvListaClientes.AllowUserToDeleteRows = false;
            dgvListaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaClientes.Columns.AddRange(new DataGridViewColumn[] { IDCliente, IDUsuario, IDMembresia, TipoListaCliente, TipoCliente, Nombre, Apellido, TipoDocumento, Documento, Direccion, TellCell, TellRes, FechaRegistro, Estatus });
            dgvListaClientes.Location = new Point(12, 17);
            dgvListaClientes.Name = "dgvListaClientes";
            dgvListaClientes.ReadOnly = true;
            dgvListaClientes.RowHeadersVisible = false;
            dgvListaClientes.RowTemplate.Height = 25;
            dgvListaClientes.Size = new Size(707, 318);
            dgvListaClientes.TabIndex = 0;
            dgvListaClientes.CellDoubleClick += dgvLIstaClientes_CellDoubleClick;
            // 
            // IDCliente
            // 
            IDCliente.DataPropertyName = "IDCliente";
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            IDCliente.ReadOnly = true;
            IDCliente.Width = 80;
            // 
            // IDUsuario
            // 
            IDUsuario.DataPropertyName = "IDUsuario";
            IDUsuario.HeaderText = "IDUsuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.ReadOnly = true;
            IDUsuario.Width = 83;
            // 
            // IDMembresia
            // 
            IDMembresia.DataPropertyName = "IDMembresia";
            IDMembresia.HeaderText = "IDMembresia";
            IDMembresia.Name = "IDMembresia";
            IDMembresia.ReadOnly = true;
            IDMembresia.Width = 102;
            // 
            // TipoListaCliente
            // 
            TipoListaCliente.DataPropertyName = "TipoListaCliente";
            TipoListaCliente.HeaderText = "TipoListaCliente";
            TipoListaCliente.Name = "TipoListaCliente";
            TipoListaCliente.ReadOnly = true;
            TipoListaCliente.Width = 116;
            // 
            // TipoCliente
            // 
            TipoCliente.DataPropertyName = "TipoCliente";
            TipoCliente.HeaderText = "TipoCliente";
            TipoCliente.Name = "TipoCliente";
            TipoCliente.ReadOnly = true;
            TipoCliente.Width = 92;
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
            // listaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(731, 541);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "listaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Load += listaClientes_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private PictureBox btnClose;
        private Panel panel1;
        private TextBox TxbBusqueda;
        private Panel panel4;
        private DataGridView dgvListaClientes;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewTextBoxColumn IDUsuario;
        private DataGridViewTextBoxColumn IDMembresia;
        private DataGridViewTextBoxColumn TipoListaCliente;
        private DataGridViewTextBoxColumn TipoCliente;
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