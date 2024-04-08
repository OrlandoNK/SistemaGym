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
    public partial class mantenimientoGrupoMembresia : Form
    {
        public mantenimientoGrupoMembresia()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            registrarGrupoMembresia nuevoGrupoMembresia = new registrarGrupoMembresia();
            nuevoGrupoMembresia.Show();
        }

        private void mantenimientoGrupoMembresia_Load(object sender, EventArgs e)
        {
            dgvGrupoMembresia.DataSource = GrupoMembresiaBLL.MostrarGrupoMembresia();
            dgvGrupoMembresia.AutoGenerateColumns = false;
        }
    }
}
