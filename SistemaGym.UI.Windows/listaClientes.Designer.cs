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
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            dgvlistaClientes = new DataGridView();
            IDCliente = new DataGridViewTextBoxColumn();
            IDUsuario = new DataGridViewTextBoxColumn();
            IDMembresia = new DataGridViewTextBoxColumn();
            TipoListaCliente = new DataGridViewTextBoxColumn();
            TipoCliente = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            TellCell = new DataGridViewTextBoxColumn();
            TellRes = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlistaClientes).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(818, 34);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 76);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dgvlistaClientes);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(818, 431);
            panel3.TabIndex = 4;
            // 
            // dgvlistaClientes
            // 
            dgvlistaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvlistaClientes.BackgroundColor = Color.White;
            dgvlistaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlistaClientes.Columns.AddRange(new DataGridViewColumn[] { IDCliente, IDUsuario, IDMembresia, TipoListaCliente, TipoCliente, Nombre, Apellido, TipoDocumento, Direccion, TellCell, TellRes, FechaRegistro, Estatus });
            dgvlistaClientes.Location = new Point(0, 0);
            dgvlistaClientes.Name = "dgvlistaClientes";
            dgvlistaClientes.RowHeadersVisible = false;
            dgvlistaClientes.RowTemplate.Height = 25;
            dgvlistaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvlistaClientes.Size = new Size(818, 443);
            dgvlistaClientes.TabIndex = 0;
            dgvlistaClientes.CellDoubleClick += dgvlistaClientes_CellDoubleClick;
            // 
            // IDCliente
            // 
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            IDCliente.Width = 80;
            // 
            // IDUsuario
            // 
            IDUsuario.HeaderText = "IDUsuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.Width = 83;
            // 
            // IDMembresia
            // 
            IDMembresia.HeaderText = "IDMembresia";
            IDMembresia.Name = "IDMembresia";
            IDMembresia.Width = 102;
            // 
            // TipoListaCliente
            // 
            TipoListaCliente.HeaderText = "TipoListaCliente";
            TipoListaCliente.Name = "TipoListaCliente";
            TipoListaCliente.Width = 116;
            // 
            // TipoCliente
            // 
            TipoCliente.HeaderText = "TipoCliente";
            TipoCliente.Name = "TipoCliente";
            TipoCliente.Width = 92;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 76;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.Width = 76;
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "TipoDocumento";
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.Width = 118;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.Width = 82;
            // 
            // TellCell
            // 
            TellCell.HeaderText = "TellCell";
            TellCell.Name = "TellCell";
            TellCell.Width = 69;
            // 
            // TellRes
            // 
            TellRes.HeaderText = "TellRes";
            TellRes.Name = "TellRes";
            TellRes.Width = 67;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.Width = 106;
            // 
            // Estatus
            // 
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.Width = 69;
            // 
            // listaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 541);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "listaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "listaClientes";
            Load += listaClientes_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvlistaClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private DataGridView dgvlistaClientes;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewTextBoxColumn IDUsuario;
        private DataGridViewTextBoxColumn IDMembresia;
        private DataGridViewTextBoxColumn TipoListaCliente;
        private DataGridViewTextBoxColumn TipoCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn TellCell;
        private DataGridViewTextBoxColumn TellRes;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estatus;
    }
}