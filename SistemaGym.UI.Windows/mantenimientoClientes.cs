﻿using Microsoft.VisualBasic;
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
    public partial class frmClientes : Form
    {
        const string sistema = "Sistema Gestion Gimnasion (COMFORT GYM) dice:";
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = ClientesBLL.MostrarCliente();
            dgvClientes.AutoGenerateColumns = false;
            CargarUsuarios();
            CargarMembresia();
            CargarTipoCliente();
            CargarTipoListaCliente();
        }

        private void CargarUsuarios()
        {
            var colUsuario = (DataGridViewComboBoxColumn)dgvClientes.Columns["IDUsuario"];

            colUsuario.DataSource = UsuarioBLL.Mostrar();
            colUsuario.ValueMember = "IDUsuario";
            colUsuario.DisplayMember = "NombreUsuario";
            colUsuario.DataPropertyName = "IDUsuario";


        }
        private void CargarMembresia()
        {
            var colMembresia = (DataGridViewComboBoxColumn)dgvClientes.Columns["IDMembresia"];

            colMembresia.DataSource = MembresiaBLL.Mostrar();
            colMembresia.ValueMember = "IDMembresia";
            colMembresia.DisplayMember = "Nombre";
            colMembresia.DataPropertyName = "IDMembresia";

        }
        private void CargarTipoListaCliente()
        {
            var colTipoListaCliente = (DataGridViewComboBoxColumn)dgvClientes.Columns["TipoListaCliente"];

            colTipoListaCliente.DataSource = TipoListaClienteBLL.MostrarTipoListaCliente();
            colTipoListaCliente.ValueMember = "IDTipoListaCliente";
            colTipoListaCliente.DisplayMember = "Nombre";
            colTipoListaCliente.DataPropertyName = "TipoListaCliente";

        }
        private void CargarTipoCliente()
        {

            var colTipoListaCliente = (DataGridViewComboBoxColumn)dgvClientes.Columns["TipoCliente"];

            colTipoListaCliente.DataSource = TipoClienteBLL.MostrarTipoCliente();
            colTipoListaCliente.ValueMember = "IDTipoCliente";
            colTipoListaCliente.DisplayMember = "Nombre";
            colTipoListaCliente.DataPropertyName = "TipoCliente";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nuevoCliente nuevoCliente = new nuevoCliente();
            nuevoCliente.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
