using SistemaGym.DAL;
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
    public partial class mantenimientoFacturacionMembresia : Form
    {

        private FacturacionMembresiaDAL facturacionMembresiaDAL = new FacturacionMembresiaDAL();

        public mantenimientoFacturacionMembresia()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mantenimientoFacturacionMembresia_Load(object sender, EventArgs e)
        {
            dgvFacturacionMembresia.DataSource = FacturacionMembresiaDAL.MostrarFacturaMembresia();
            dgvFacturacionMembresia.AutoGenerateColumns = false;
        }
    }
}
