namespace SistemaGym.UI.Windows
{
    partial class MenuPrincipalUIW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalUIW));
            btnProductos = new Button();
            btnEmpleados = new Button();
            btnClientes = new Button();
            panelDesktop = new Panel();
            lblWelcome = new Label();
            panelInicio = new Panel();
            btnClose = new PictureBox();
            lblInicio = new Label();
            panelComford = new Panel();
            label1 = new Label();
            panelDesktop.SuspendLayout();
            panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panelComford.SuspendLayout();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(255, 255, 192);
            btnProductos.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(-6, 310);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(235, 85);
            btnProductos.TabIndex = 11;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleRight;
            btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(255, 255, 192);
            btnEmpleados.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(-6, 218);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(235, 96);
            btnEmpleados.TabIndex = 10;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TextAlign = ContentAlignment.MiddleRight;
            btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(255, 255, 192);
            btnClientes.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(-6, 123);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(235, 102);
            btnClientes.TabIndex = 9;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleRight;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(lblWelcome);
            panelDesktop.Location = new Point(223, 123);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(633, 391);
            panelDesktop.TabIndex = 8;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(243, 146);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(140, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "BIENVENIDO AL SISTEMA";
            // 
            // panelInicio
            // 
            panelInicio.BackColor = Color.FromArgb(192, 255, 255);
            panelInicio.Controls.Add(btnClose);
            panelInicio.Controls.Add(lblInicio);
            panelInicio.Location = new Point(217, 5);
            panelInicio.Name = "panelInicio";
            panelInicio.Size = new Size(639, 118);
            panelInicio.TabIndex = 7;
            // 
            // btnClose
            // 
            btnClose.ErrorImage = (Image)resources.GetObject("btnClose.ErrorImage");
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.InitialImage = (Image)resources.GetObject("btnClose.InitialImage");
            btnClose.Location = new Point(556, 26);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(205, 54);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(42, 15);
            lblInicio.TabIndex = 0;
            lblInicio.Text = "INICIO";
            // 
            // panelComford
            // 
            panelComford.BackColor = Color.FromArgb(192, 255, 255);
            panelComford.Controls.Add(label1);
            panelComford.Location = new Point(2, 6);
            panelComford.Name = "panelComford";
            panelComford.Size = new Size(215, 117);
            panelComford.TabIndex = 6;
            panelComford.Paint += panelComford_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 61);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Comford Gym";
            // 
            // MenuPrincipalUIW
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 517);
            Controls.Add(btnProductos);
            Controls.Add(panelComford);
            Controls.Add(btnClientes);
            Controls.Add(btnEmpleados);
            Controls.Add(panelDesktop);
            Controls.Add(panelInicio);
            Name = "MenuPrincipalUIW";
            Text = "MenuPrincipalUIW";
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            panelInicio.ResumeLayout(false);
            panelInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panelComford.ResumeLayout(false);
            panelComford.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnEmpleados;
        private Button btnClientes;
        private Panel panelDesktop;
        private Label lblWelcome;
        private Panel panelInicio;
        private PictureBox btnClose;
        private Label lblInicio;
        private Panel panelComford;
        private Label label1;
    }
}