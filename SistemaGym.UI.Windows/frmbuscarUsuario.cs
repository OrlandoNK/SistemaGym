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
    public partial class frmbuscarUsuario : Form
    {
        public frmbuscarUsuario()
        {
            InitializeComponent();
        }

        private int _idUsuario;
        public int idUsuario
        {

            get { return _idUsuario; }
            set { }

        }

        private void frmbuscarUsuario_Load(object sender, EventArgs e)
        {
            dgvUsuarioList.DataSource = UsuarioBLL.MostrarCliente();
            dgvUsuarioList.AutoGenerateColumns = false;
        }

        private void dgvUsuarioList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            idUsuario = (int)dgvUsuarioList.CurrentRow.Cells["IDUsuario"].Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
