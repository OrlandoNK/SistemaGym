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
    public partial class mantenimientoListaClientes : Form
    {
        public mantenimientoListaClientes()
        {
            InitializeComponent();
        }

        private void mantenimientoListaClientes_Load(object sender, EventArgs e)
        {
            dgvListaCliente.DataSource = TipoListaClienteBLL.MostrarTipoListaCliente();
            dgvListaCliente.AutoGenerateColumns = false;
        }
    }
}
