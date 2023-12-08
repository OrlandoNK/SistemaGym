namespace SistemaGym.UI.Windows
{
    partial class frmBuscarCliente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvBuscarClientes = new DataGridView();
            IDCliente = new DataGridViewTextBoxColumn();
            IDUsuario = new DataGridViewComboBoxColumn();
            IDMembresia = new DataGridViewComboBoxColumn();
            IDTipoListaCliente = new DataGridViewComboBoxColumn();
            IDTipoCliente = new DataGridViewComboBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            TelCell = new DataGridViewTextBoxColumn();
            TelRes = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            txtBuscarCliente = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 35);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca los datos a buscar";
            // 
            // dgvBuscarClientes
            // 
            dgvBuscarClientes.AllowUserToAddRows = false;
            dgvBuscarClientes.AllowUserToDeleteRows = false;
            dgvBuscarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscarClientes.Columns.AddRange(new DataGridViewColumn[] { IDCliente, IDUsuario, IDMembresia, IDTipoListaCliente, IDTipoCliente, Nombre, Apellido, TipoDocumento, Documento, Direccion, TelCell, TelRes, FechaRegistro, Estatus });
            dgvBuscarClientes.Location = new Point(12, 58);
            dgvBuscarClientes.Name = "dgvBuscarClientes";
            dgvBuscarClientes.ReadOnly = true;
            dgvBuscarClientes.RowTemplate.Height = 25;
            dgvBuscarClientes.Size = new Size(896, 456);
            dgvBuscarClientes.TabIndex = 1;
            dgvBuscarClientes.CellDoubleClick += dgvBuscarClientes_CellDoubleClick;
            // 
            // IDCliente
            // 
            IDCliente.DataPropertyName = "IDCliente";
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            IDCliente.ReadOnly = true;
            // 
            // IDUsuario
            // 
            IDUsuario.DataPropertyName = "IDUsuario";
            IDUsuario.HeaderText = "Usuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.ReadOnly = true;
            IDUsuario.Resizable = DataGridViewTriState.True;
            IDUsuario.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDMembresia
            // 
            IDMembresia.DataPropertyName = "IDMembresia";
            IDMembresia.HeaderText = "Membresia";
            IDMembresia.Name = "IDMembresia";
            IDMembresia.ReadOnly = true;
            IDMembresia.Resizable = DataGridViewTriState.True;
            IDMembresia.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDTipoListaCliente
            // 
            IDTipoListaCliente.DataPropertyName = "IDTipoListaCliente";
            IDTipoListaCliente.HeaderText = "Tipo Lista";
            IDTipoListaCliente.Name = "IDTipoListaCliente";
            IDTipoListaCliente.ReadOnly = true;
            IDTipoListaCliente.Resizable = DataGridViewTriState.True;
            IDTipoListaCliente.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDTipoCliente
            // 
            IDTipoCliente.DataPropertyName = "IDTipoCliente";
            IDTipoCliente.HeaderText = "TipoCliente";
            IDTipoCliente.Name = "IDTipoCliente";
            IDTipoCliente.ReadOnly = true;
            IDTipoCliente.Resizable = DataGridViewTriState.True;
            IDTipoCliente.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            TipoDocumento.DataPropertyName = "TipoDocumento";
            TipoDocumento.HeaderText = "Tipo Documento";
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.ReadOnly = true;
            // 
            // Documento
            // 
            Documento.DataPropertyName = "Documento";
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // TelCell
            // 
            TelCell.DataPropertyName = "TelCell";
            TelCell.HeaderText = "TelCell";
            TelCell.Name = "TelCell";
            TelCell.ReadOnly = true;
            // 
            // TelRes
            // 
            TelRes.DataPropertyName = "TelRes";
            TelRes.HeaderText = "TelRes";
            TelRes.Name = "TelRes";
            TelRes.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            FechaRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(257, 32);
            txtBuscarCliente.Multiline = true;
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(354, 20);
            txtBuscarCliente.TabIndex = 2;
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            // 
            // frmBuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 547);
            Controls.Add(txtBuscarCliente);
            Controls.Add(dgvBuscarClientes);
            Controls.Add(label1);
            Name = "frmBuscarCliente";
            Text = "frmBuscarCliente";
            Load += frmBuscarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuscarClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvBuscarClientes;
        private TextBox txtBuscarCliente;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewComboBoxColumn IDUsuario;
        private DataGridViewComboBoxColumn IDMembresia;
        private DataGridViewComboBoxColumn IDTipoListaCliente;
        private DataGridViewComboBoxColumn IDTipoCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn TelCell;
        private DataGridViewTextBoxColumn TelRes;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estatus;
    }
}