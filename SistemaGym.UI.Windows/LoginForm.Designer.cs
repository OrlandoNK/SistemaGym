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
            panel2 = new Panel();
            btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            TxbContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            TxbUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)btnCerrarLogin).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrarLogin
            // 
            btnCerrarLogin.Anchor = AnchorStyles.None;
            btnCerrarLogin.Cursor = Cursors.Hand;
            btnCerrarLogin.Image = Properties.Resources.cerrar__1_;
            btnCerrarLogin.Location = new Point(544, 125);
            btnCerrarLogin.Name = "btnCerrarLogin";
            btnCerrarLogin.Size = new Size(32, 32);
            btnCerrarLogin.SizeMode = PictureBoxSizeMode.AutoSize;
            btnCerrarLogin.TabIndex = 3;
            btnCerrarLogin.TabStop = false;
            btnCerrarLogin.Click += btnCerrarLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnCerrarLogin);
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(TxbContraseña);
            panel2.Controls.Add(TxbUsuario);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 438);
            panel2.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.None;
            btnEntrar.BorderColor = Color.Gold;
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
            btnEntrar.HoverState.FillColor = Color.Khaki;
            btnEntrar.HoverState.ForeColor = Color.Black;
            btnEntrar.Location = new Point(207, 268);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.PressedColor = Color.LightYellow;
            btnEntrar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEntrar.Size = new Size(369, 45);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Iniciar Sesion";
            btnEntrar.Click += btnEntrar_Click;
            // 
            // TxbContraseña
            // 
            TxbContraseña.Anchor = AnchorStyles.None;
            TxbContraseña.BorderThickness = 2;
            TxbContraseña.CustomizableEdges = customizableEdges3;
            TxbContraseña.DefaultText = "";
            TxbContraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbContraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbContraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbContraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbContraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbContraseña.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbContraseña.ForeColor = Color.Black;
            TxbContraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbContraseña.IconLeft = Properties.Resources.password;
            TxbContraseña.Location = new Point(207, 210);
            TxbContraseña.Name = "TxbContraseña";
            TxbContraseña.PasswordChar = '●';
            TxbContraseña.PlaceholderForeColor = Color.Silver;
            TxbContraseña.PlaceholderText = "Contraseña";
            TxbContraseña.SelectedText = "";
            TxbContraseña.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TxbContraseña.Size = new Size(369, 41);
            TxbContraseña.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            TxbContraseña.TabIndex = 1;
            TxbContraseña.UseSystemPasswordChar = true;
            // 
            // TxbUsuario
            // 
            TxbUsuario.Anchor = AnchorStyles.None;
            TxbUsuario.BorderThickness = 2;
            TxbUsuario.CustomizableEdges = customizableEdges5;
            TxbUsuario.DefaultText = "";
            TxbUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbUsuario.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbUsuario.ForeColor = Color.Black;
            TxbUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbUsuario.IconLeft = Properties.Resources.usuario1;
            TxbUsuario.Location = new Point(207, 163);
            TxbUsuario.Name = "TxbUsuario";
            TxbUsuario.PasswordChar = '\0';
            TxbUsuario.PlaceholderForeColor = Color.Silver;
            TxbUsuario.PlaceholderText = "Usuario";
            TxbUsuario.SelectedText = "";
            TxbUsuario.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TxbUsuario.Size = new Size(369, 41);
            TxbUsuario.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            TxbUsuario.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 438);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comfort GYM - INICIAR SESION";
            ((System.ComponentModel.ISupportInitialize)btnCerrarLogin).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private Guna.UI2.WinForms.Guna2TextBox TxbContraseña;
        private Guna.UI2.WinForms.Guna2TextBox TxbUsuario;
        private PictureBox btnCerrarLogin;
    }
}