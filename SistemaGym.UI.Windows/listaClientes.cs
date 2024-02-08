﻿using SistemaGym.BLL;
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
    public partial class listaClientes : Form
    {

        private int? _IdCliente;

        public int? IdCliente
        {
            get
            {
                return _IdCliente;
            }
        }

        public listaClientes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listaClientes_Load(object sender, EventArgs e)
        {
            dgvListaClientes.DataSource = ClientesBLL.GetClients();
            dgvListaClientes.AutoGenerateColumns = false;
        }

        private void dgvListaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            _IdCliente = (int?)dgvListaClientes.CurrentRow.Cells["IDCliente"].Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
