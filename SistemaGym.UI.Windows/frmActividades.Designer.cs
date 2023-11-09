namespace SistemaGym.UI.Windows
{
    partial class frmActividades
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
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtActividad = new TextBox();
            txtTipoActividades = new TextBox();
            txtNombre = new TextBox();
            txtArea = new TextBox();
            txtEncargadoActividad = new TextBox();
            txtDia = new TextBox();
            txtHoraInicio = new TextBox();
            txtHoraCierre = new TextBox();
            txtEstatus = new TextBox();
            dataGridView1 = new DataGridView();
            IDActividad = new DataGridViewTextBoxColumn();
            IDTipoActividades = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Area = new DataGridViewTextBoxColumn();
            EncargadoActividades = new DataGridViewTextBoxColumn();
            Dia = new DataGridViewTextBoxColumn();
            HoraInicio = new DataGridViewTextBoxColumn();
            HoraCierre = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            bntGuardar = new Button();
            bntNuevo = new Button();
            bntEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 69);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "IDActividad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 108);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "IDTipoAtividades";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 147);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 188);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 229);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 4;
            label5.Text = "EncargadoActividad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 268);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(24, 15);
            label6.TabIndex = 5;
            label6.Text = "Dia";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 306);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 6;
            label7.Text = "HoraInicio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 340);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 7;
            label8.Text = "HoraCierre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(58, 378);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 8;
            label9.Text = "Estatus";
            // 
            // txtActividad
            // 
            txtActividad.Location = new Point(182, 71);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(100, 23);
            txtActividad.TabIndex = 9;
            // 
            // txtTipoActividades
            // 
            txtTipoActividades.Location = new Point(182, 108);
            txtTipoActividades.Name = "txtTipoActividades";
            txtTipoActividades.Size = new Size(100, 23);
            txtTipoActividades.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(182, 147);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 11;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(182, 188);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(100, 23);
            txtArea.TabIndex = 12;
            // 
            // txtEncargadoActividad
            // 
            txtEncargadoActividad.Location = new Point(182, 229);
            txtEncargadoActividad.Name = "txtEncargadoActividad";
            txtEncargadoActividad.Size = new Size(100, 23);
            txtEncargadoActividad.TabIndex = 13;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(182, 268);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 14;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.Location = new Point(182, 306);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.Size = new Size(100, 23);
            txtHoraInicio.TabIndex = 15;
            // 
            // txtHoraCierre
            // 
            txtHoraCierre.Location = new Point(182, 340);
            txtHoraCierre.Name = "txtHoraCierre";
            txtHoraCierre.Size = new Size(100, 23);
            txtHoraCierre.TabIndex = 16;
            // 
            // txtEstatus
            // 
            txtEstatus.Location = new Point(182, 378);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(100, 23);
            txtEstatus.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDActividad, IDTipoActividades, Nombre, Area, EncargadoActividades, Dia, HoraInicio, HoraCierre, Estatus });
            dataGridView1.Location = new Point(301, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(296, 188);
            dataGridView1.TabIndex = 18;
            // 
            // IDActividad
            // 
            IDActividad.HeaderText = "IDAcitivdad";
            IDActividad.Name = "IDActividad";
            IDActividad.ReadOnly = true;
            // 
            // IDTipoActividades
            // 
            IDTipoActividades.HeaderText = "IDTipoActividades";
            IDTipoActividades.Name = "IDTipoActividades";
            IDTipoActividades.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Area
            // 
            Area.HeaderText = "Area";
            Area.Name = "Area";
            Area.ReadOnly = true;
            // 
            // EncargadoActividades
            // 
            EncargadoActividades.HeaderText = "EncargadoActividades";
            EncargadoActividades.Name = "EncargadoActividades";
            EncargadoActividades.ReadOnly = true;
            // 
            // Dia
            // 
            Dia.HeaderText = "Dia";
            Dia.Name = "Dia";
            Dia.ReadOnly = true;
            // 
            // HoraInicio
            // 
            HoraInicio.HeaderText = "HoraInicio";
            HoraInicio.Name = "HoraInicio";
            HoraInicio.ReadOnly = true;
            // 
            // HoraCierre
            // 
            HoraCierre.HeaderText = "HoraCierre";
            HoraCierre.Name = "HoraCierre";
            HoraCierre.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // bntGuardar
            // 
            bntGuardar.Location = new Point(301, 306);
            bntGuardar.Name = "bntGuardar";
            bntGuardar.Size = new Size(75, 23);
            bntGuardar.TabIndex = 19;
            bntGuardar.Text = "Guardar";
            bntGuardar.UseVisualStyleBackColor = true;
            bntGuardar.Click += bntGuardar_Click;
            // 
            // bntNuevo
            // 
            bntNuevo.Location = new Point(407, 306);
            bntNuevo.Name = "bntNuevo";
            bntNuevo.Size = new Size(75, 23);
            bntNuevo.TabIndex = 20;
            bntNuevo.Text = "Nuevo";
            bntNuevo.UseVisualStyleBackColor = true;
            bntNuevo.Click += bntNuevo_Click;
            // 
            // bntEliminar
            // 
            bntEliminar.Location = new Point(522, 306);
            bntEliminar.Name = "bntEliminar";
            bntEliminar.Size = new Size(75, 23);
            bntEliminar.TabIndex = 21;
            bntEliminar.Text = "Eliminar";
            bntEliminar.UseVisualStyleBackColor = true;
            bntEliminar.Click += bntEliminar_Click;
            // 
            // frmActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntEliminar);
            Controls.Add(bntNuevo);
            Controls.Add(bntGuardar);
            Controls.Add(dataGridView1);
            Controls.Add(txtEstatus);
            Controls.Add(txtHoraCierre);
            Controls.Add(txtHoraInicio);
            Controls.Add(txtDia);
            Controls.Add(txtEncargadoActividad);
            Controls.Add(txtArea);
            Controls.Add(txtNombre);
            Controls.Add(txtTipoActividades);
            Controls.Add(txtActividad);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmActividades";
            Text = "frmActividades";
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
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtActividad;
        private TextBox txtTipoActividades;
        private TextBox txtNombre;
        private TextBox txtArea;
        private TextBox txtEncargadoActividad;
        private TextBox txtDia;
        private TextBox txtHoraInicio;
        private TextBox txtHoraCierre;
        private TextBox txtEstatus;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDActividad;
        private DataGridViewTextBoxColumn IDTipoActividades;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Area;
        private DataGridViewTextBoxColumn EncargadoActividades;
        private DataGridViewTextBoxColumn Dia;
        private DataGridViewTextBoxColumn HoraInicio;
        private DataGridViewTextBoxColumn HoraCierre;
        private DataGridViewTextBoxColumn Estatus;
        private Button bntGuardar;
        private Button bntNuevo;
        private Button bntEliminar;
    }
}