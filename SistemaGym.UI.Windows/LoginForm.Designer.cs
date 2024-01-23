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
            btnCerrarLogin = new PictureBox();
            btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            TxbContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            TxbUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)btnCerrarLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrarLogin
            // 
            btnCerrarLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarLogin.Cursor = Cursors.Hand;
            btnCerrarLogin.Image = Properties.Resources.cerrar_ventana_x__1_;
            btnCerrarLogin.Location = new Point(450, 12);
            btnCerrarLogin.Name = "btnCerrarLogin";
            btnCerrarLogin.Size = new Size(32, 32);
            btnCerrarLogin.SizeMode = PictureBoxSizeMode.AutoSize;
            btnCerrarLogin.TabIndex = 3;
            btnCerrarLogin.TabStop = false;
            btnCerrarLogin.Click += btnCerrarLogin_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.None;
            btnEntrar.BorderColor = Color.Gold;
            btnEntrar.BorderRadius = 25;
            btnEntrar.BorderThickness = 1;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.CustomizableEdges = customizableEdges1;
            btnEntrar.DisabledState.BorderColor = Color.DarkGray;
            btnEntrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEntrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEntrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEntrar.FillColor = Color.Transparent;
            btnEntrar.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.HoverState.FillColor = Color.Khaki;
            btnEntrar.HoverState.ForeColor = Color.Black;
            btnEntrar.Image = Properties.Resources.login_10180173;
            btnEntrar.ImageSize = new Size(25, 25);
            btnEntrar.Location = new Point(55, 273);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.PressedColor = Color.LightYellow;
            btnEntrar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEntrar.Size = new Size(385, 52);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "&Acceder";
            btnEntrar.Click += btnEntrar_Click;
            // 
            // TxbContraseña
            // 
            TxbContraseña.Anchor = AnchorStyles.None;
            TxbContraseña.BorderColor = Color.White;
            TxbContraseña.BorderThickness = 2;
            TxbContraseña.CustomizableEdges = customizableEdges3;
            TxbContraseña.DefaultText = "";
            TxbContraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbContraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbContraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbContraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbContraseña.FillColor = Color.Black;
            TxbContraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbContraseña.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbContraseña.ForeColor = Color.White;
            TxbContraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbContraseña.IconLeft = Properties.Resources.icons8_contraseña_32;
            TxbContraseña.Location = new Point(55, 173);
            TxbContraseña.Name = "TxbContraseña";
            TxbContraseña.PasswordChar = '●';
            TxbContraseña.PlaceholderForeColor = Color.LightGray;
            TxbContraseña.PlaceholderText = "Contraseña";
            TxbContraseña.SelectedText = "";
            TxbContraseña.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TxbContraseña.Size = new Size(385, 41);
            TxbContraseña.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            TxbContraseña.TabIndex = 1;
            TxbContraseña.UseSystemPasswordChar = true;
            // 
            // TxbUsuario
            // 
            TxbUsuario.Anchor = AnchorStyles.None;
            TxbUsuario.BorderColor = Color.White;
            TxbUsuario.BorderThickness = 2;
            TxbUsuario.CustomizableEdges = customizableEdges5;
            TxbUsuario.DefaultText = "";
            TxbUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbUsuario.FillColor = Color.Black;
            TxbUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbUsuario.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbUsuario.ForeColor = Color.White;
            TxbUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbUsuario.IconLeft = Properties.Resources.icons8_usuario_32;
            TxbUsuario.Location = new Point(55, 109);
            TxbUsuario.Name = "TxbUsuario";
            TxbUsuario.PasswordChar = '\0';
            TxbUsuario.PlaceholderForeColor = Color.LightGray;
            TxbUsuario.PlaceholderText = "Usuario";
            TxbUsuario.SelectedText = "";
            TxbUsuario.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TxbUsuario.Size = new Size(385, 41);
            TxbUsuario.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            TxbUsuario.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Confort_GYM_SidePanel;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 411);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnCerrarLogin);
            panel1.Controls.Add(TxbUsuario);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(TxbContraseña);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(208, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 411);
            panel1.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 411);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comfort GYM - INICIAR SESION";
            ((System.ComponentModel.ISupportInitialize)btnCerrarLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private Guna.UI2.WinForms.Guna2TextBox TxbContraseña;
        private Guna.UI2.WinForms.Guna2TextBox TxbUsuario;
        private PictureBox btnCerrarLogin;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}