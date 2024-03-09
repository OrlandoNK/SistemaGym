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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)btnCerrarLogin).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrarLogin
            // 
            btnCerrarLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarLogin.Cursor = Cursors.Hand;
            btnCerrarLogin.Image = Properties.Resources._BotonXcerrarVentana;
            btnCerrarLogin.Location = new Point(532, 11);
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
            btnEntrar.BorderRadius = 24;
            btnEntrar.BorderThickness = 1;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.CustomizableEdges = customizableEdges1;
            btnEntrar.DisabledState.BorderColor = Color.DarkGray;
            btnEntrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEntrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEntrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEntrar.FillColor = Color.Transparent;
            btnEntrar.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.HoverState.FillColor = Color.Goldenrod;
            btnEntrar.HoverState.ForeColor = Color.Black;
            btnEntrar.ImageSize = new Size(28, 28);
            btnEntrar.Location = new Point(44, 272);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.PressedColor = Color.LightYellow;
            btnEntrar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEntrar.Size = new Size(487, 52);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "&Acceder";
            btnEntrar.Click += btnEntrar_Click;
            // 
            // TxbContraseña
            // 
            TxbContraseña.Anchor = AnchorStyles.None;
            TxbContraseña.BorderColor = Color.WhiteSmoke;
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
            TxbContraseña.IconLeft = Properties.Resources._PasswordLogin_x32_;
            TxbContraseña.Location = new Point(44, 183);
            TxbContraseña.Name = "TxbContraseña";
            TxbContraseña.PasswordChar = '●';
            TxbContraseña.PlaceholderForeColor = Color.Gainsboro;
            TxbContraseña.PlaceholderText = "Contraseña";
            TxbContraseña.SelectedText = "";
            TxbContraseña.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TxbContraseña.Size = new Size(487, 41);
            TxbContraseña.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            TxbContraseña.TabIndex = 1;
            TxbContraseña.UseSystemPasswordChar = true;
            // 
            // TxbUsuario
            // 
            TxbUsuario.Anchor = AnchorStyles.None;
            TxbUsuario.BorderColor = Color.WhiteSmoke;
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
            TxbUsuario.IconLeft = Properties.Resources._UsuarioLogin_x32_;
            TxbUsuario.Location = new Point(44, 124);
            TxbUsuario.Name = "TxbUsuario";
            TxbUsuario.PasswordChar = '\0';
            TxbUsuario.PlaceholderForeColor = Color.Gainsboro;
            TxbUsuario.PlaceholderText = "Usuario";
            TxbUsuario.SelectedText = "";
            TxbUsuario.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TxbUsuario.Size = new Size(487, 41);
            TxbUsuario.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            TxbUsuario.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 436);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Confort_GYM_SidePanel;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 434);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TxbUsuario);
            panel2.Controls.Add(btnCerrarLogin);
            panel2.Controls.Add(TxbContraseña);
            panel2.Controls.Add(btnEntrar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(226, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 436);
            panel2.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 436);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comfort GYM - INICIAR SESION";
            ((System.ComponentModel.ISupportInitialize)btnCerrarLogin).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private Guna.UI2.WinForms.Guna2TextBox TxbContraseña;
        private Guna.UI2.WinForms.Guna2TextBox TxbUsuario;
        private PictureBox btnCerrarLogin;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}