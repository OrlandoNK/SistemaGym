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
    public partial class mantenimientoEmpleados : Form
    {
        public mantenimientoEmpleados()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            registrarEmpleados nuevoEmpleado = new registrarEmpleados();
            nuevoEmpleado.Show();
        }

        private void mantenimientoEmpleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = EmpleadoBLL.GetEmpleados();
            dgvEmpleados.AutoGenerateColumns = false;
        }
    }
}
