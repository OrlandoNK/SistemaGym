namespace SistemaGym.UI.Windows
{
    partial class registrarProveedores
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvProveedores = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            chkEstatusProveedor = new CheckBox();
            btnGuardarProveedor = new Guna.UI2.WinForms.Guna2Button();
            TxbNombreProveedor = new TextBox();
            label3 = new Label();
            TxbDireccionProveedor = new TextBox();
            label2 = new Label();
            mskbxTellProveedor = new MaskedTextBox();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 65);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.btn_cerrar_ventana_x_x32;
            btnClose.Location = new Point(594, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 42);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(652, 40);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dgvProveedores);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(0, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(652, 366);
            panel3.TabIndex = 2;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AllowUserToDeleteRows = false;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvProveedores.BackgroundColor = Color.WhiteSmoke;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Telefono, Direccion, FechaRegistro, Estatus });
            dgvProveedores.Location = new Point(197, 0);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.RowTemplate.Height = 25;
            dgvProveedores.Size = new Size(455, 366);
            dgvProveedores.TabIndex = 9;
            // 
            // ID
            // 
            ID.DataPropertyName = "IDProveedor";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 46;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 82;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 84;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            Direccion.Width = 87;
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            FechaRegistro.Width = 115;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            Estatus.Width = 74;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(chkEstatusProveedor);
            panel4.Controls.Add(btnGuardarProveedor);
            panel4.Controls.Add(TxbNombreProveedor);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(TxbDireccionProveedor);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(mskbxTellProveedor);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 364);
            panel4.TabIndex = 8;
            // 
            // chkEstatusProveedor
            // 
            chkEstatusProveedor.CheckAlign = ContentAlignment.MiddleRight;
            chkEstatusProveedor.Cursor = Cursors.Hand;
            chkEstatusProveedor.ForeColor = Color.White;
            chkEstatusProveedor.Location = new Point(20, 211);
            chkEstatusProveedor.Name = "chkEstatusProveedor";
            chkEstatusProveedor.Size = new Size(160, 24);
            chkEstatusProveedor.TabIndex = 0;
            chkEstatusProveedor.Text = "Estatus";
            chkEstatusProveedor.UseVisualStyleBackColor = true;
            // 
            // btnGuardarProveedor
            // 
            btnGuardarProveedor.BorderColor = Color.Goldenrod;
            btnGuardarProveedor.BorderThickness = 1;
            btnGuardarProveedor.Cursor = Cursors.Hand;
            btnGuardarProveedor.CustomizableEdges = customizableEdges1;
            btnGuardarProveedor.DisabledState.BorderColor = Color.DarkGray;
            btnGuardarProveedor.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGuardarProveedor.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGuardarProveedor.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGuardarProveedor.FillColor = Color.Transparent;
            btnGuardarProveedor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarProveedor.ForeColor = Color.White;
            btnGuardarProveedor.HoverState.FillColor = Color.Goldenrod;
            btnGuardarProveedor.HoverState.ForeColor = Color.Black;
            btnGuardarProveedor.Image = Properties.Resources.button_for_saving_providers_x32;
            btnGuardarProveedor.Location = new Point(-1, 277);
            btnGuardarProveedor.Name = "btnGuardarProveedor";
            btnGuardarProveedor.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnGuardarProveedor.Size = new Size(198, 45);
            btnGuardarProveedor.TabIndex = 8;
            btnGuardarProveedor.Text = "&Guardar";
            btnGuardarProveedor.Click += btnGuardarProveedor_Click;
            // 
            // TxbNombreProveedor
            // 
            TxbNombreProveedor.Location = new Point(20, 56);
            TxbNombreProveedor.Name = "TxbNombreProveedor";
            TxbNombreProveedor.Size = new Size(160, 23);
            TxbNombreProveedor.TabIndex = 0;
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 138);
            label3.Name = "label3";
            label3.Size = new Size(160, 19);
            label3.TabIndex = 6;
            label3.Text = "Telefono del Proveedor";
            // 
            // TxbDireccionProveedor
            // 
            TxbDireccionProveedor.Location = new Point(20, 108);
            TxbDireccionProveedor.Name = "TxbDireccionProveedor";
            TxbDireccionProveedor.Size = new Size(160, 23);
            TxbDireccionProveedor.TabIndex = 1;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 86);
            label2.Name = "label2";
            label2.Size = new Size(160, 19);
            label2.TabIndex = 5;
            label2.Text = "Dirección del Proveedor";
            // 
            // mskbxTellProveedor
            // 
            mskbxTellProveedor.Location = new Point(20, 160);
            mskbxTellProveedor.Name = "mskbxTellProveedor";
            mskbxTellProveedor.Size = new Size(160, 23);
            mskbxTellProveedor.TabIndex = 2;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(160, 19);
            label1.TabIndex = 4;
            label1.Text = "Nombre del Proveedor";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // registrarProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 471);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registrarProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox TxbNombreProveedor;
        private MaskedTextBox mskbxTellProveedor;
        private TextBox TxbDireccionProveedor;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private DataGridView dgvProveedores;
        private Guna.UI2.WinForms.Guna2Button btnGuardarProveedor;
        private CheckBox chkEstatusProveedor;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estatus;
        private PictureBox btnClose;
    }
}