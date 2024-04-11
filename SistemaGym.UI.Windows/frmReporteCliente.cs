using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
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
    public partial class frmReporteCliente : Form
    {
        public frmReporteCliente()
        {
            InitializeComponent();
        }

        private void frmReporteCliente_Load(object sender, EventArgs e)
        {
            var reportDataSource = new ReportDataSource("SistemaGymDataSet", ObtenerDatos());


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaGym.UI.Windows.ReportDefinitions.Clientes.rdlc";
           
            reportViewer1.RefreshReport();
           
        }
        private DataTable ObtenerDatos()
        {
          
         var dataSet = new SistemaGymDataSet(); 
            return dataSet.Tables[0];
        }
    }
}
