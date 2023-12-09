using SistemaGym.BLL;
using SistemaGym.DAL;
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
    public partial class registrarMembresias : Form
    {
        public registrarMembresias()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MembresiaEntity nuevaMembresia = new MembresiaEntity();

            nuevaMembresia.Nombre = TxbNombre.Text;
            nuevaMembresia.Descripcion = TxbDescripcion.Text;
            nuevaMembresia.Duracion = TxbDuracion.Text;
            nuevaMembresia.Valor = Convert.ToDecimal(TxbValor.Text);
            nuevaMembresia.FechaCreacion = DateTime.Now;
            nuevaMembresia.Estatus = "Activo";

            MembresiaDAL.InsertarMembresia(nuevaMembresia);
            MessageBox.Show("Membresia Registrada de Manera Correcta", "Membresia Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            this.Close();
        }

        private void LimpiarCampos()
        {
            TxbNombre.Clear();
            TxbDescripcion.Clear();
            TxbDuracion.Clear();
            TxbValor.Clear();
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {

        }

    }
}
