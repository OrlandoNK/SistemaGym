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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {

        }
        private void InicializarControles()
        {
            txtDescripcion.Clear();
            txtIDCategoria.Text = "0";
            txtNombre.Text = "0";
            dgvCategoria.AutoGenerateColumns = false;
            dgvCategoria.DataSource = CategoriaProductoBLL.Mostrar();

        }
    }
}
