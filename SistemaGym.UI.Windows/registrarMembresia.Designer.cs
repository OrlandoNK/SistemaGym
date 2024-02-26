namespace SistemaGym.UI.Windows
{
    partial class registrarMembresia
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            dgvMembresia = new DataGridView();
            IDMembresia = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            panel6 = new Panel();
            label2 = new Label();
            chkbxEstatus = new CheckBox();
            label3 = new Label();
            txtValor = new TextBox();
            label4 = new Label();
            txtDuracion = new TextBox();
            label5 = new Label();
            txtDescripcion = new RichTextBox();
            txtNombre = new TextBox();
            errorProvider = new ErrorProvider(components);
            btnClose = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembresia).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(571, 66);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(504, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(571, 35);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 444);
            panel3.Name = "panel3";
            panel3.Size = new Size(571, 66);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Goldenrod;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 409);
            panel4.Name = "panel4";
            panel4.Size = new Size(571, 35);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dgvMembresia);
            panel5.Controls.Add(btnSave);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 101);
            panel5.Name = "panel5";
            panel5.Size = new Size(571, 308);
            panel5.TabIndex = 4;
            // 
            // dgvMembresia
            // 
            dgvMembresia.AllowUserToAddRows = false;
            dgvMembresia.AllowUserToDeleteRows = false;
            dgvMembresia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvMembresia.BackgroundColor = Color.WhiteSmoke;
            dgvMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembresia.Columns.AddRange(new DataGridViewColumn[] { IDMembresia, Nombre, Descripcion, Duracion, Valor, FechaCreacion, Estatus });
            dgvMembresia.Location = new Point(215, -1);
            dgvMembresia.Name = "dgvMembresia";
            dgvMembresia.ReadOnly = true;
            dgvMembresia.RowHeadersVisible = false;
            dgvMembresia.RowTemplate.Height = 25;
            dgvMembresia.Size = new Size(355, 251);
            dgvMembresia.TabIndex = 36;
            // 
            // IDMembresia
            // 
            IDMembresia.DataPropertyName = "IDMembresia";
            IDMembresia.HeaderText = "IDMembresia";
            IDMembresia.Name = "IDMembresia";
            IDMembresia.ReadOnly = true;
            IDMembresia.Width = 102;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 76;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 94;
            // 
            // Duracion
            // 
            Duracion.DataPropertyName = "Duracion";
            Duracion.HeaderText = "Duracion";
            Duracion.Name = "Duracion";
            Duracion.ReadOnly = true;
            Duracion.Width = 80;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "Valor";
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Width = 58;
            // 
            // FechaCreacion
            // 
            FechaCreacion.DataPropertyName = "FechaCreacion";
            FechaCreacion.HeaderText = "FechaCreacion";
            FechaCreacion.Name = "FechaCreacion";
            FechaCreacion.ReadOnly = true;
            FechaCreacion.Width = 110;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            Estatus.Width = 69;
            // 
            // btnSave
            // 
            btnSave.BorderColor = Color.Goldenrod;
            btnSave.BorderThickness = 1;
            btnSave.CustomizableEdges = customizableEdges3;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.Transparent;
            btnSave.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Black;
            btnSave.HoverState.FillColor = Color.Black;
            btnSave.HoverState.ForeColor = Color.White;
            btnSave.Image = Properties.Resources.button_for_saving_membership_x32;
            btnSave.ImageSize = new Size(25, 25);
            btnSave.Location = new Point(221, 256);
            btnSave.Name = "btnSave";
            btnSave.PressedColor = Color.Transparent;
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSave.Size = new Size(344, 45);
            btnSave.TabIndex = 35;
            btnSave.Text = "&Guardar";
            btnSave.Click += btnSave_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(label2);
            panel6.Controls.Add(chkbxEstatus);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(txtValor);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(txtDuracion);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(txtDescripcion);
            panel6.Controls.Add(txtNombre);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(216, 306);
            panel6.TabIndex = 34;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 13);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 22;
            label2.Text = "Nombre";
            // 
            // chkbxEstatus
            // 
            chkbxEstatus.Anchor = AnchorStyles.None;
            chkbxEstatus.CheckAlign = ContentAlignment.MiddleRight;
            chkbxEstatus.ForeColor = Color.White;
            chkbxEstatus.Location = new Point(27, 269);
            chkbxEstatus.Name = "chkbxEstatus";
            chkbxEstatus.Size = new Size(163, 24);
            chkbxEstatus.TabIndex = 33;
            chkbxEstatus.Text = "Estatus";
            chkbxEstatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 177);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 23;
            label3.Text = "Descripcion";
            // 
            // txtValor
            // 
            txtValor.Anchor = AnchorStyles.None;
            txtValor.Location = new Point(27, 242);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(163, 21);
            txtValor.TabIndex = 32;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 60);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 24;
            label4.Text = "Duracion";
            // 
            // txtDuracion
            // 
            txtDuracion.Anchor = AnchorStyles.None;
            txtDuracion.Location = new Point(27, 195);
            txtDuracion.Multiline = true;
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(163, 21);
            txtDuracion.TabIndex = 31;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 219);
            label5.Name = "label5";
            label5.Size = new Size(163, 20);
            label5.TabIndex = 25;
            label5.Text = "Valor $";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.None;
            txtDescripcion.Location = new Point(27, 83);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(163, 91);
            txtDescripcion.TabIndex = 30;
            txtDescripcion.Text = "";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Location = new Point(27, 36);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(163, 21);
            txtNombre.TabIndex = 29;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.btn_close_cerrar_x32;
            btnClose.Location = new Point(504, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(53, 50);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // registrarMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 510);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registrarMembresia";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMembresia).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TextBox txtValor;
        private TextBox txtDuracion;
        private RichTextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox chkbxEstatus;
        private Panel panel6;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private DataGridView dgvMembresia;
        private DataGridViewTextBoxColumn IDMembresia;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn FechaCreacion;
        private DataGridViewTextBoxColumn Estatus;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider;
        private PictureBox btnClose;
    }
}