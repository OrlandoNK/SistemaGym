using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGym.BLL;
using SistemaGym.DAL;
using SistemaGym.Entities;

namespace SistemaGym.UI.Windows
{
    public partial class MenuPrincipalUI : Form
    {
        //variable para saber cual formulario esta abierto
        private Form activeForm;
        public MenuPrincipalUI()

        {
            InitializeComponent();
        }
        private void Reset()//metodo para cargar inicio de nuevo
        {
            
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
             = childForm.Text;
            btnClose.Visible = true;
        }
    }
}