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
    public partial class listaEmpleados : Form
    {
        public listaEmpleados()
        {
            InitializeComponent();
        }

        private void listaEmpleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = EmpleadoBLL.GetEmpleados();
            dgvEmpleados.AutoGenerateColumns = false;
        }
    }
}
