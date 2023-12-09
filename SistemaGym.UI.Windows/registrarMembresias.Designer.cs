namespace SistemaGym.UI.Windows
{
    partial class registrarMembresias
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
            panel1 = new Panel();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnGuardar = new Button();
            lblValor = new Label();
            lblDuracion = new Label();
            lblDescripcion = new Label();
            lblNombre = new Label();
            TxbValor = new TextBox();
            TxbDuracion = new TextBox();
            TxbDescripcion = new RichTextBox();
            TxbNombre = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 70);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.close_button__x64_;
            btnClose.Location = new Point(359, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(53, 53);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 28);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleGoldenrod;
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(lblValor);
            panel3.Controls.Add(lblDuracion);
            panel3.Controls.Add(lblDescripcion);
            panel3.Controls.Add(lblNombre);
            panel3.Controls.Add(TxbValor);
            panel3.Controls.Add(TxbDuracion);
            panel3.Controls.Add(TxbDescripcion);
            panel3.Controls.Add(TxbNombre);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(424, 342);
            panel3.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.Black;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Gold;
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.Gold;
            btnGuardar.Image = Properties.Resources.SAVE_2;
            btnGuardar.Location = new Point(275, 110);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 96);
            btnGuardar.TabIndex = 12;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblValor
            // 
            lblValor.Anchor = AnchorStyles.None;
            lblValor.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblValor.Location = new Point(41, 261);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(179, 23);
            lblValor.TabIndex = 9;
            lblValor.Text = "Valor";
            lblValor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDuracion
            // 
            lblDuracion.Anchor = AnchorStyles.None;
            lblDuracion.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDuracion.Location = new Point(41, 209);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(179, 23);
            lblDuracion.TabIndex = 8;
            lblDuracion.Text = "Duración";
            lblDuracion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.None;
            lblDescripcion.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(41, 84);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(179, 23);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripción";
            lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(41, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(179, 23);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbValor
            // 
            TxbValor.Anchor = AnchorStyles.None;
            TxbValor.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbValor.ForeColor = Color.Black;
            TxbValor.Location = new Point(41, 287);
            TxbValor.Name = "TxbValor";
            TxbValor.Size = new Size(126, 23);
            TxbValor.TabIndex = 3;
            // 
            // TxbDuracion
            // 
            TxbDuracion.Anchor = AnchorStyles.None;
            TxbDuracion.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbDuracion.ForeColor = Color.Black;
            TxbDuracion.Location = new Point(41, 235);
            TxbDuracion.Name = "TxbDuracion";
            TxbDuracion.Size = new Size(126, 23);
            TxbDuracion.TabIndex = 2;
            // 
            // TxbDescripcion
            // 
            TxbDescripcion.Anchor = AnchorStyles.None;
            TxbDescripcion.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbDescripcion.ForeColor = Color.Black;
            TxbDescripcion.Location = new Point(41, 110);
            TxbDescripcion.Name = "TxbDescripcion";
            TxbDescripcion.Size = new Size(228, 96);
            TxbDescripcion.TabIndex = 1;
            TxbDescripcion.Text = "";
            // 
            // TxbNombre
            // 
            TxbNombre.Anchor = AnchorStyles.None;
            TxbNombre.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbNombre.ForeColor = Color.Black;
            TxbNombre.Location = new Point(41, 58);
            TxbNombre.Name = "TxbNombre";
            TxbNombre.Size = new Size(228, 23);
            TxbNombre.TabIndex = 0;
            // 
            // registrarMembresias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 440);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registrarMembresias";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox btnClose;
        private Panel panel3;
        private RichTextBox TxbDescripcion;
        private TextBox TxbNombre;
        private TextBox TxbValor;
        private TextBox TxbDuracion;
        private Label lblDescripcion;
        private Label lblNombre;
        private Label lblValor;
        private Label lblDuracion;
        private Button btnGuardar;
    }
}