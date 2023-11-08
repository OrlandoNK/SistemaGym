namespace SistemaGym.UI.Windows
{
    partial class frmGrupoMembresia
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
            textIDGrupoMembresia = new TextBox();
            textIDMembresia = new TextBox();
            textNombre = new TextBox();
            textFechaRegistro = new TextBox();
            textEstatus = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 51);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Grupo Membresia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "ID Membresia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 3;
            label4.Text = "FechaRegistro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 179);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Estatus";
            // 
            // textIDGrupoMembresia
            // 
            textIDGrupoMembresia.Location = new Point(143, 51);
            textIDGrupoMembresia.Name = "textIDGrupoMembresia";
            textIDGrupoMembresia.Size = new Size(100, 23);
            textIDGrupoMembresia.TabIndex = 5;
            // 
            // textIDMembresia
            // 
            textIDMembresia.Location = new Point(143, 82);
            textIDMembresia.Name = "textIDMembresia";
            textIDMembresia.Size = new Size(100, 23);
            textIDMembresia.TabIndex = 6;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(143, 117);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 7;
            // 
            // textFechaRegistro
            // 
            textFechaRegistro.Location = new Point(143, 150);
            textFechaRegistro.Name = "textFechaRegistro";
            textFechaRegistro.Size = new Size(100, 23);
            textFechaRegistro.TabIndex = 8;
            // 
            // textEstatus
            // 
            textEstatus.Location = new Point(143, 179);
            textEstatus.Name = "textEstatus";
            textEstatus.Size = new Size(100, 23);
            textEstatus.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(290, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(342, 205);
            dataGridView1.TabIndex = 10;
            // 
            // frmGrupoMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textEstatus);
            Controls.Add(textFechaRegistro);
            Controls.Add(textNombre);
            Controls.Add(textIDMembresia);
            Controls.Add(textIDGrupoMembresia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmGrupoMembresia";
            Text = "frmGrupoMembresia";
            Load += frmGrupoMembresia_Load;
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
        private TextBox textIDGrupoMembresia;
        private TextBox textIDMembresia;
        private TextBox textNombre;
        private TextBox textFechaRegistro;
        private TextBox textEstatus;
        private DataGridView dataGridView1;
    }
}