using SistemaGym.BLL;
using SistemaGym.Entities;
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
    public partial class nuevoCliente : Form
    {
        public nuevoCliente()
        {
            InitializeComponent();
        }

        private void nuevoCliente_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = gestioUsuarioEntities.usernameLogged;
            CargarMembresia();
            CargarTipoCliente();
            CargarTipoListaCliente();
        }

        private void CargarTipoListaCliente()
        {
            cbTipoListaCliente.ValueMember = "IDTipoListaCliente";
            cbTipoListaCliente.DisplayMember = "Nombre";
            cbTipoListaCliente.DataSource = TipoListaClienteBLL.MostrarTipoListaCliente();
        }

        private void CargarTipoCliente()
        {
            cbTipoCliente.ValueMember = "IDTipoCliente";
            cbTipoCliente.DisplayMember = "Nombre";
            cbTipoCliente.DataSource = TipoClienteBLL.MostrarTipoCliente();
        }

        private void CargarMembresia()
        {
            cbMembresia.ValueMember = "IDMembresia";
            cbMembresia.DisplayMember = "Nombre";
            cbMembresia.DataSource = MembresiaBLL.Mostrar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
