namespace SistemaGym.UI.Windows
{
    partial class frmClientes
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvCliente = new DataGridView();
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
            btnGuardar = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.ColumnHeadersHeight = 22;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { IDCliente, IDUsuario, IDMembresia, IDTipoListaCliente, IDTipoCliente, Nombre, Apellido, TipoDocumento, Documento, Direccion, TelCell, TelRes, FechaRegistro, Estatus });
            dgvCliente.Location = new Point(285, 48);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowHeadersVisible = false;
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.Size = new Size(702, 410);
            dgvCliente.TabIndex = 72;
            dgvCliente.CellClick += dgvCliente_CellClick;
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
            IDUsuario.HeaderText = "Usuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.ReadOnly = true;
            IDUsuario.Resizable = DataGridViewTriState.True;
            IDUsuario.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDMembresia
            // 
            IDMembresia.HeaderText = "Membresia";
            IDMembresia.Name = "IDMembresia";
            IDMembresia.ReadOnly = true;
            IDMembresia.Resizable = DataGridViewTriState.True;
            IDMembresia.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDTipoListaCliente
            // 
            IDTipoListaCliente.HeaderText = "Tipo Lista Cliente";
            IDTipoListaCliente.Name = "IDTipoListaCliente";
            IDTipoListaCliente.ReadOnly = true;
            IDTipoListaCliente.Resizable = DataGridViewTriState.True;
            IDTipoListaCliente.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDTipoCliente
            // 
            IDTipoCliente.HeaderText = "Tipo Cliente";
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
            TipoDocumento.HeaderText = "TipoDocumento";
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
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            FechaRegistro.DefaultCellStyle = dataGridViewCellStyle2;
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
            // btnGuardar
            // 
            btnGuardar.Location = new Point(96, 482);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 94;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 526);
            Controls.Add(btnGuardar);
            Controls.Add(dgvCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClientes";
            Text = "Clientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvCliente;
        private Button btnGuardar;
        private ErrorProvider errorProvider;
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