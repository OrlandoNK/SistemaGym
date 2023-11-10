namespace SistemaGym.UI.Windows
{
    partial class LoginForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnCerrarLogin = new PictureBox();
            panel2 = new Panel();
            btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            TxbContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            TxbUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            panel3 = new Panel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarLogin).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 57, 80);
            panel1.Controls.Add(btnCerrarLogin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 58);
            panel1.TabIndex = 0;
            // 
            // btnCerrarLogin
            // 
            btnCerrarLogin.Cursor = Cursors.Hand;
            btnCerrarLogin.Image = Properties.Resources.cerrar__1_;
            btnCerrarLogin.Location = new Point(593, 13);
            btnCerrarLogin.Name = "btnCerrarLogin";
            btnCerrarLogin.Size = new Size(32, 32);
            btnCerrarLogin.SizeMode = PictureBoxSizeMode.AutoSize;
            btnCerrarLogin.TabIndex = 3;
            btnCerrarLogin.TabStop = false;
            btnCerrarLogin.Click += btnCerrarLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MintCream;
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(TxbContraseña);
            panel2.Controls.Add(TxbUsuario);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(219, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(418, 508);
            panel2.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.BorderColor = Color.SeaGreen;
            btnEntrar.BorderRadius = 5;
            btnEntrar.BorderThickness = 1;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.CustomizableEdges = customizableEdges1;
            btnEntrar.DisabledState.BorderColor = Color.DarkGray;
            btnEntrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEntrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEntrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEntrar.FillColor = Color.Transparent;
            btnEntrar.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.ForeColor = Color.FromArgb(39, 57, 80);
            btnEntrar.HoverState.FillColor = Color.YellowGreen;
            btnEntrar.HoverState.ForeColor = Color.FromArgb(39, 57, 80);
            btnEntrar.Location = new Point(44, 344);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.PressedColor = Color.DarkSeaGreen;
            btnEntrar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEntrar.Size = new Size(331, 45);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Iniciar Sesion";
            btnEntrar.Click += btnEntrar_Click;
            // 
            // TxbContraseña
            // 
            TxbContraseña.BorderThickness = 2;
            TxbContraseña.CustomizableEdges = customizableEdges3;
            TxbContraseña.DefaultText = "";
            TxbContraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbContraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbContraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbContraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbContraseña.FillColor = Color.MintCream;
            TxbContraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbContraseña.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbContraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbContraseña.Location = new Point(44, 199);
            TxbContraseña.Name = "TxbContraseña";
            TxbContraseña.PasswordChar = '\0';
            TxbContraseña.PlaceholderForeColor = Color.DarkSeaGreen;
            TxbContraseña.PlaceholderText = "Contraseña";
            TxbContraseña.SelectedText = "";
            TxbContraseña.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TxbContraseña.Size = new Size(331, 41);
            TxbContraseña.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            TxbContraseña.TabIndex = 1;
            // 
            // TxbUsuario
            // 
            TxbUsuario.BorderThickness = 2;
            TxbUsuario.CustomizableEdges = customizableEdges5;
            TxbUsuario.DefaultText = "";
            TxbUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbUsuario.FillColor = Color.MintCream;
            TxbUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbUsuario.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbUsuario.Location = new Point(44, 120);
            TxbUsuario.Name = "TxbUsuario";
            TxbUsuario.PasswordChar = '\0';
            TxbUsuario.PlaceholderForeColor = Color.DarkSeaGreen;
            TxbUsuario.PlaceholderText = "Usuario";
            TxbUsuario.SelectedText = "";
            TxbUsuario.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TxbUsuario.Size = new Size(331, 41);
            TxbUsuario.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            TxbUsuario.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(guna2PictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 508);
            panel3.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackgroundImage = Properties.Resources.Comfort_GYM___Login;
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2PictureBox1.CustomizableEdges = customizableEdges7;
            guna2PictureBox1.Dock = DockStyle.Fill;
            guna2PictureBox1.FillColor = Color.Transparent;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(0, 0);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2PictureBox1.Size = new Size(219, 508);
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 566);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comfort GYM - INICIAR SESION";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarLogin).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private Guna.UI2.WinForms.Guna2TextBox TxbContraseña;
        private Guna.UI2.WinForms.Guna2TextBox TxbUsuario;
        private PictureBox btnCerrarLogin;
    }
}