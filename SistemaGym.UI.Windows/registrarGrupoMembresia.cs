using SistemaGym.BLL;
using SistemaGym.Entities;
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
    public partial class registrarGrupoMembresia : Form
    {
        public registrarGrupoMembresia()
        {
            InitializeComponent();
        }

        private void btnBuscarMembresia_Click(object sender, EventArgs e)
        {
            listaMembresias listaMembresias = new listaMembresias();

            if (listaMembresias.ShowDialog() == DialogResult.OK)
            {
                MembresiaEntity oMembresia = MembresiaBLL.GetById((int)listaMembresias.IdMembresia);

                if (oMembresia != null)
                {
                    this.TxbIDMembresia.Text = oMembresia.IDMembresia.ToString();
                    this.TxbNombreMembresia.Text = oMembresia.Nombre.ToString();
                    this.TxbDescrMembresia.Text = oMembresia.Descripcion.ToString();
                    this.TxbValorMembresia.Text = Convert.ToInt32(oMembresia.Valor).ToString();
                }
                else
                {
                    MessageBox.Show("Membresia No Encontrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
