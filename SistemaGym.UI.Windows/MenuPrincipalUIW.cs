using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGym.UI.Windows
{
    public partial class MenuPrincipalUIW : Form
    {
        //variable para saber cual formulario esta abierto
        private Form activeForm;
        public MenuPrincipalUIW()
        {
            InitializeComponent();
        }
        private void Reset()//metodo para cargar inicio de nuevo
        {
            lblInicio.Text = "INICIO";
            lblWelcome.Text = "BIENVENIDO AL SISTEMA";
            btnClose.Visible = false;
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblInicio.Text = childForm.Text;
            btnClose.Visible = true;
        }

        private void panelComford_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
    }
}
