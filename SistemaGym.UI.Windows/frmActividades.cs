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
    private void MantenimientoActividades_Load(object sender, EventArgs e)
    {
        dgvActividades.DataSource = ActividadesBLL.MostrarActividades();
    }
    public partial class frmActividades : Form
    {
        public frmActividades()
        {
            InitializeComponent();
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Guardar este Registro de Actividades?", "¿Guardar Actividades?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ActividadesEntity nuevaActividades = new ActividadesEntity();

                nuevaActividades.IDActividad = txtActividad.Text;
                nuevaActividades.IDTipoActividades = txtTipoActividades.Text;
                nuevaActividades.Nombre = txtNombre.Text;
                nuevaActividades.Area = txtArea.Text;
                nuevaActividades.EncargadoActividad = txtEncargadoActividad.Text;
                nuevaActividades.Dia = txtDia.Text;
                nuevaActividades.HoraInicio = txtHoraInicio.Text;
                nuevaActividades.HoraCierre = txtHoraCierre.Text;
                nuevaActividades.Estatus = txtEstatus.Text;

                if (txtID.Text == 0)
                {
                    ActividadesBLL.Guardar(nuevaActividades);
                    MessageBox.Show("Acitivades Registro de manera Satisfatoria", "Mantenimiento Actividades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    dgvActividades.DataSource = ActividadesBLL.MostrarActividades();
                }
            }
            if (result == DialogResult.No)
            {

            }
        }

        private void bntNuevo_Click(object sender, EventArgs e)
        {
            InicializarCampos();
        }
        public void InicializarCampos()
        {
            txtActividad.Text = "0";
            txtTipoActividades.Text = "";
            txtNombre.Text = "";
            txtArea.Text = "";
            txtEncargadoActividad.Text = "";
            txtDia.Text = "";
            txtHoraInicio.Text = "";
            txtHoraCierre.Text = "";
            txtEstatus.Text = "";
        }
        public void LimpiarCampos()
        {
            txtActividad.Clear();
            txtTipoActividades.Clear();
            txtNombre.Clear();
            txtArea.Clear();
            txtEncargadoActividad.Clear();
            txtDia.Clear();
            txtHoraInicio.Clear();
            txtHoraCierre.Clear();
            txtEstatus.Clear();
        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            ActividadesBLL actividadesBLL = new ActividadesBLL();
            
            if (dgvActividades.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seguro que deseas Eliminar esta Actividades?", "¿Eliminar Actividades?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int IDActividades = Convert.ToInt32(dvgActividades.SelectedRows[0].Index);
                    bool seElimino = ActividadesBLL.Eliminar(IDActividades);

                    if (seElimino)
                    {
                        dgvActividades.Rows.RemoveAT(dgvActividades.SelectedRows[0].Index);
                        MessageBox.Show("Actividad Eliminada Sastisfactoriamente;", "Eliminar Actividad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvActividades.DataSource = ActividadesBLL.MostrarActividades();
                    }
                    else
                    {
                        MessageBox.Show("Se Produjo un Error al Intentar Eliminar la Actividad", "Error al Eliminar Actividad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (DialogResult == DialogResult.No)
                {

                }
            }
        }
    }
    
}
