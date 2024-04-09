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
    public partial class listaUsuarios : Form
    {
        public listaUsuarios()
        {
            InitializeComponent();
        }

        private int _IdUsuario;

        public int IdUsuario
        {
            get
            {
                return _IdUsuario;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listaUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = UsuarioBLL.Mostrar();
            dgvUsuarios.AutoGenerateColumns = false;
            CargarIDEmpleado();
            CargarRol();
        }

        private void CargarRol()
        {
            var colRol = (DataGridViewComboBoxColumn)dgvUsuarios.Columns["IdRol"];
            colRol.ValueMember = "IDRol";
            colRol.DisplayMember = "Nombre";
            colRol.DataPropertyName = "IdRol";
            colRol.DataSource = RolBLL.MostrarRol();
        }
        private void CargarIDEmpleado()
        {
            var colRol = (DataGridViewComboBoxColumn)dgvUsuarios.Columns["IdEmpleado"];
            colRol.ValueMember = "IDEmpleado";
            colRol.DisplayMember = "Documento";
            colRol.DataPropertyName = "IdEmpleado";
            colRol.DataSource = EmpleadoBLL.GetEmpleados();
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            _IdUsuario = (int)dgvUsuarios.CurrentRow.Cells["IDUsuario"].Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
