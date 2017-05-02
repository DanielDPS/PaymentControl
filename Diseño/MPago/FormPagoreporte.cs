using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Diseño.MPago;
using Microsoft.Reporting.WinForms;
using Diseño;
namespace Diseño.MPago
{
    public partial class FormPagoreporte : Form
    {
        ConceptoPagoDetalle detallePago;
        public FormPagoreporte(ConceptoPagoDetalle reporte)
        {
            InitializeComponent();
            detallePago = new ConceptoPagoDetalle();
            detallePago = reporte;

        }

        private void FormPagoreporte_Load(object sender, EventArgs e)
        {
            
            this.paReportePagoAlumnoTableAdapter.Fill(this.dtListadoPagos.paReportePagoAlumno,detallePago.Folio);
            this.reportViewer1.RefreshReport();
           
        }
    }
}
