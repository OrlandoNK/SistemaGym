using SistemaGym.BLL;
using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGym.UI.Windows
{

    public partial class registrarGrupoMembresia : Form
    {
        private string SYSTEM_TITLE = "Sistema Gestión Gimnasion (COMFORT GYM) dice";
        public registrarGrupoMembresia()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            ErrorProvider.Clear();
            bool validation = true;
            string CampoObligatorio = "¡Este Campo es Obligatorio!";
            string AgregarMembresia = "¡Debe de Agregar la Membresia!";
            string CampoNumerico = "¡Este Campo debe Ser Numerico!";


            if (string.IsNullOrEmpty(TxbIDMembresia.Text))
            {
                ErrorProvider.SetError(TxbIDMembresia, AgregarMembresia);
                validation = false;
            }
            int IDMembresia;
            if (!int.TryParse(TxbIDMembresia.Text, out IDMembresia))
            {
                ErrorProvider.SetError(TxbIDMembresia, CampoNumerico);
                validation = false;
            }
            if (string.IsNullOrEmpty(TxbNombreMembresia.Text))
            {
                ErrorProvider.SetError(TxbNombreMembresia, AgregarMembresia);
                validation = false;
            }
            if (string.IsNullOrEmpty(TxbValorMembresia.Text))
            {
                ErrorProvider.SetError(TxbValorMembresia, AgregarMembresia);
                validation = false;
            }
            decimal ValorMembresia;
            if (!decimal.TryParse(TxbValorMembresia.Text, out ValorMembresia))
            {
                ErrorProvider.SetError(TxbValorMembresia, CampoNumerico);
                validation = false;
            }
            if (string.IsNullOrEmpty(TxbMontoTotal.Text))
            {
                ErrorProvider.SetError(TxbMontoTotal, CampoObligatorio);
                validation = false;
            }
            decimal MontoTotal;
            if (!decimal.TryParse(TxbMontoTotal.Text, out MontoTotal))
            {
                ErrorProvider.SetError(TxbMontoTotal, CampoNumerico);
                validation = false;
            }
            if (string.IsNullOrEmpty(TxbNombreGrupoMembresia.Text))
            {
                ErrorProvider.SetError(TxbNombreGrupoMembresia, CampoObligatorio);
                validation = false;
            }
            if (string.IsNullOrEmpty(TxbDescrMembresia.Text))
            {
                ErrorProvider.SetError(TxbDescrMembresia, AgregarMembresia);
                validation = false;
            }
            if (string.IsNullOrEmpty(txtCantidadPersonas.Text))
            {
                ErrorProvider.SetError(txtCantidadPersonas, AgregarMembresia);
                validation = false;
            }
            int CantidadPersonas;
            if (!int.TryParse(txtCantidadPersonas.Text, out CantidadPersonas))
            {
                ErrorProvider.SetError(txtCantidadPersonas, CampoNumerico);
                validation = false;
            }



            return validation;
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
                    this.TxbValorMembresia.Text = Convert.ToDecimal(oMembresia.Valor).ToString("0.00");
                    this.txtCantidadPersonas.Text = Convert.ToDecimal(oMembresia.CantidadPersonas).ToString("0.00");

                    decimal CantidadPersonas = decimal.Parse(txtCantidadPersonas.Text);
                    decimal ValorMembresia = decimal.Parse(TxbValorMembresia.Text);
                    this.TxbMontoTotal.Text = Convert.ToDecimal(CantidadPersonas * ValorMembresia).ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Membresia No Encontrada", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {

                return;
            }

            GrupoMembresiaEntity nuevoGrupoMembresia = new GrupoMembresiaEntity();
            GrupoMembresiaBLL grupoMembresiaBLL = new GrupoMembresiaBLL();

            nuevoGrupoMembresia.IDMembresia = Convert.ToInt32(TxbIDMembresia.Text);
            nuevoGrupoMembresia.Nombre = TxbNombreGrupoMembresia.Text;
            nuevoGrupoMembresia.MontoTotal = Convert.ToDecimal(TxbMontoTotal.Text);
            nuevoGrupoMembresia.FechaRegistro = DateTime.Now;
            nuevoGrupoMembresia.Estatus = "Activo";

            try
            {
                GrupoMembresiaBLL.guardar(nuevoGrupoMembresia);
                MessageBox.Show("¡El Grupo de Membresia a Ha Sido Guardado de Manera Satisfactoria!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se ha Producido un Error al Intentar Guardar el Grupo de Membresia:\n\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha Producido un Error al Intentar Guardar el Grupo de Membresia:\n\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            TxbIDMembresia.Clear();
            TxbNombreMembresia.Clear();
            TxbValorMembresia.Clear();
            TxbDescrMembresia.Clear();
            TxbNombreGrupoMembresia.Clear();
            TxbMontoTotal.Clear();
            txtCantidadPersonas.Clear();
        }
    }
}
