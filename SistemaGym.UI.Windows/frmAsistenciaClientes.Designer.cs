namespace SistemaGym.UI.Windows
{
    partial class frmAsistenciaClientes
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
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtCliente = new TextBox();
            txtIDAsistenciaCliente = new TextBox();
            lbl2 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtFechaAsistencia = new TextBox();
            label4 = new Label();
            chbAsistencia = new CheckBox();
            IDAsistenciaCliente = new DataGridViewTextBoxColumn();
            IDCliente = new DataGridViewTextBoxColumn();
            Asistencia = new DataGridViewTextBoxColumn();
            FechaAsistencia = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(212, 189);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 150;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(120, 189);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 149;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(28, 189);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 148;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(136, 100);
            txtCliente.Multiline = true;
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 20);
            txtCliente.TabIndex = 147;
            // 
            // txtIDAsistenciaCliente
            // 
            txtIDAsistenciaCliente.Location = new Point(136, 62);
            txtIDAsistenciaCliente.Multiline = true;
            txtIDAsistenciaCliente.Name = "txtIDAsistenciaCliente";
            txtIDAsistenciaCliente.Size = new Size(29, 25);
            txtIDAsistenciaCliente.TabIndex = 145;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(38, 103);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(44, 15);
            lbl2.TabIndex = 144;
            lbl2.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 131);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 143;
            label2.Text = "Asistencia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 72);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 142;
            label1.Text = "ID Asistencia";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDAsistenciaCliente, IDCliente, Asistencia, FechaAsistencia });
            dataGridView1.Location = new Point(293, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(500, 364);
            dataGridView1.TabIndex = 151;
            // 
            // txtFechaAsistencia
            // 
            txtFechaAsistencia.Location = new Point(136, 152);
            txtFechaAsistencia.Multiline = true;
            txtFechaAsistencia.Name = "txtFechaAsistencia";
            txtFechaAsistencia.Size = new Size(100, 20);
            txtFechaAsistencia.TabIndex = 153;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 157);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 152;
            label4.Text = "Fecha Asistencia";
            // 
            // chbAsistencia
            // 
            chbAsistencia.AutoSize = true;
            chbAsistencia.Location = new Point(136, 127);
            chbAsistencia.Name = "chbAsistencia";
            chbAsistencia.Size = new Size(79, 19);
            chbAsistencia.TabIndex = 154;
            chbAsistencia.Text = "Asistencia";
            chbAsistencia.UseVisualStyleBackColor = true;
            // 
            // IDAsistenciaCliente
            // 
            IDAsistenciaCliente.DataPropertyName = "IDAsistenciaCliente";
            IDAsistenciaCliente.HeaderText = "IDAsistencia";
            IDAsistenciaCliente.Name = "IDAsistenciaCliente";
            IDAsistenciaCliente.ReadOnly = true;
            // 
            // IDCliente
            // 
            IDCliente.DataPropertyName = "IDCliente";
            IDCliente.HeaderText = "Cliente";
            IDCliente.Name = "IDCliente";
            IDCliente.ReadOnly = true;
            // 
            // Asistencia
            // 
            Asistencia.DataPropertyName = "Asistencia";
            Asistencia.HeaderText = "Asistencia";
            Asistencia.Name = "Asistencia";
            Asistencia.ReadOnly = true;
            // 
            // FechaAsistencia
            // 
            FechaAsistencia.DataPropertyName = "FechaAsistencia";
            FechaAsistencia.HeaderText = "FechaAsistencia";
            FechaAsistencia.Name = "FechaAsistencia";
            FechaAsistencia.ReadOnly = true;
            // 
            // frmAsistenciaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(chbAsistencia);
            Controls.Add(txtFechaAsistencia);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtCliente);
            Controls.Add(txtIDAsistenciaCliente);
            Controls.Add(lbl2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAsistenciaClientes";
            Text = "Asistencia Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private TextBox txtCliente;
        private TextBox txtAsistencia;
        private TextBox txtIDAsistenciaCliente;
        private Label lbl2;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtFechaAsistencia;
        private Label label4;
        private CheckBox chbAsistencia;
        private DataGridViewTextBoxColumn IDAsistenciaCliente;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewTextBoxColumn Asistencia;
        private DataGridViewTextBoxColumn FechaAsistencia;
    }
}