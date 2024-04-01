using SistemaGym.BLL;
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
    public partial class mantenimientoAreaEmpresa : Form
    {
        public mantenimientoAreaEmpresa()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            registrarAreaEmpresa nuevaAreaEmpresa = new registrarAreaEmpresa();
            nuevaAreaEmpresa.Show();
        }
        private void CargarEncargado()
        {
            var colEncargado = (DataGridViewComboBoxColumn)dgvAreaEmpresa.Columns["Encargado"];

            colEncargado.ValueMember = "IDEmpleado";
            colEncargado.DisplayMember = "Nombre";
            colEncargado.DataPropertyName = "Encargado";
            colEncargado.DataSource = EmpleadoBLL.GetEmpleados();
        }

        private void mantenimientoAreaEmpresa_Load(object sender, EventArgs e)
        {
            AreaEmpresaBLL areaEmpresaBLL = new AreaEmpresaBLL();
            dgvAreaEmpresa.DataSource = areaEmpresaBLL.Mostrar();
            dgvAreaEmpresa.AutoGenerateColumns = false;
            CargarEncargado();
        }
    }
}
