namespace SistemaGym.UI.Windows
{
    partial class frmAreaEmpresa
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textIDArea = new TextBox();
            textEncargado = new TextBox();
            textNombre = new TextBox();
            textDescripcion = new TextBox();
            textFechaCreacion = new TextBox();
            dataGridView1 = new DataGridView();
            IDArea = new DataGridViewTextBoxColumn();
            Encargado = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 87);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Area";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 116);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Encargado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 145);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 175);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 204);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 4;
            label5.Text = "FechaCreacion";
            // 
            // textIDArea
            // 
            textIDArea.Location = new Point(125, 87);
            textIDArea.Name = "textIDArea";
            textIDArea.Size = new Size(100, 23);
            textIDArea.TabIndex = 5;
            // 
            // textEncargado
            // 
            textEncargado.Location = new Point(125, 116);
            textEncargado.Name = "textEncargado";
            textEncargado.Size = new Size(100, 23);
            textEncargado.TabIndex = 6;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(125, 145);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 7;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(125, 175);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(100, 23);
            textDescripcion.TabIndex = 8;
            // 
            // textFechaCreacion
            // 
            textFechaCreacion.Location = new Point(125, 204);
            textFechaCreacion.Name = "textFechaCreacion";
            textFechaCreacion.Size = new Size(100, 23);
            textFechaCreacion.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDArea, Encargado, Nombre, Descripcion, FechaCreacion });
            dataGridView1.Location = new Point(251, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 10;
            // 
            // IDArea
            // 
            IDArea.HeaderText = "IDArea";
            IDArea.Name = "IDArea";
            IDArea.ReadOnly = true;
            // 
            // Encargado
            // 
            Encargado.HeaderText = "Encargado";
            Encargado.Name = "Encargado";
            Encargado.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            FechaCreacion.HeaderText = "FechaCreacion";
            FechaCreacion.Name = "FechaCreacion";
            FechaCreacion.ReadOnly = true;
            // 
            // frmAreaEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textFechaCreacion);
            Controls.Add(textDescripcion);
            Controls.Add(textNombre);
            Controls.Add(textEncargado);
            Controls.Add(textIDArea);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAreaEmpresa";
            Text = "frmAreaEmpresa";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textIDArea;
        private TextBox textEncargado;
        private TextBox textNombre;
        private TextBox textDescripcion;
        private TextBox textFechaCreacion;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDArea;
        private DataGridViewTextBoxColumn Encargado;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn FechaCreacion;
    }
}