namespace SistemaGym.UI.Windows
{
    partial class frmCargoCredito
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
            label6 = new Label();
            textIDCargoCredito = new TextBox();
            textIDCliente = new TextBox();
            textCargo = new TextBox();
            textMonto = new TextBox();
            textFehaCargo = new TextBox();
            Estatus = new TextBox();
            dataGridView1 = new DataGridView();
            IDCargoCredito = new DataGridViewTextBoxColumn();
            IDCliente = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            FechaCargo = new DataGridViewTextBoxColumn();
            tEstatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 71);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "IDCargoCredito";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 118);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "IDCliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 168);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Cargo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 215);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Monto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 258);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "FechaCargo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 305);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 5;
            label6.Text = "Estatus";
            // 
            // textIDCargoCredito
            // 
            textIDCargoCredito.Location = new Point(119, 71);
            textIDCargoCredito.Name = "textIDCargoCredito";
            textIDCargoCredito.Size = new Size(100, 23);
            textIDCargoCredito.TabIndex = 6;
            // 
            // textIDCliente
            // 
            textIDCliente.Location = new Point(119, 118);
            textIDCliente.Name = "textIDCliente";
            textIDCliente.Size = new Size(100, 23);
            textIDCliente.TabIndex = 7;
            // 
            // textCargo
            // 
            textCargo.Location = new Point(119, 168);
            textCargo.Name = "textCargo";
            textCargo.Size = new Size(100, 23);
            textCargo.TabIndex = 8;
            // 
            // textMonto
            // 
            textMonto.Location = new Point(119, 215);
            textMonto.Name = "textMonto";
            textMonto.Size = new Size(100, 23);
            textMonto.TabIndex = 9;
            // 
            // textFehaCargo
            // 
            textFehaCargo.Location = new Point(119, 258);
            textFehaCargo.Name = "textFehaCargo";
            textFehaCargo.Size = new Size(100, 23);
            textFehaCargo.TabIndex = 10;
            // 
            // Estatus
            // 
            Estatus.Location = new Point(119, 305);
            Estatus.Name = "Estatus";
            Estatus.Size = new Size(100, 23);
            Estatus.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDCargoCredito, IDCliente, Cargo, Monto, FechaCargo, tEstatus });
            dataGridView1.Location = new Point(237, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 278);
            dataGridView1.TabIndex = 12;
            // 
            // IDCargoCredito
            // 
            IDCargoCredito.HeaderText = "IDCargoCredito";
            IDCargoCredito.Name = "IDCargoCredito";
            IDCargoCredito.ReadOnly = true;
            // 
            // IDCliente
            // 
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            IDCliente.ReadOnly = true;
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            Cargo.ReadOnly = true;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // FechaCargo
            // 
            FechaCargo.HeaderText = "FechaCargo";
            FechaCargo.Name = "FechaCargo";
            FechaCargo.ReadOnly = true;
            // 
            // tEstatus
            // 
            tEstatus.HeaderText = "tEstatus";
            tEstatus.Name = "tEstatus";
            tEstatus.ReadOnly = true;
            // 
            // frmCargoCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 450);
            Controls.Add(dataGridView1);
            Controls.Add(Estatus);
            Controls.Add(textFehaCargo);
            Controls.Add(textMonto);
            Controls.Add(textCargo);
            Controls.Add(textIDCliente);
            Controls.Add(textIDCargoCredito);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCargoCredito";
            Text = "frmCargoCredito";
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
        private Label label6;
        private TextBox textIDCargoCredito;
        private TextBox textIDCliente;
        private TextBox textCargo;
        private TextBox textMonto;
        private TextBox textFehaCargo;
        private TextBox Estatus;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDCargoCredito;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn FechaCargo;
        private DataGridViewTextBoxColumn tEstatus;
    }
}