using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio;
using Servicio.Criterios;
using Servicio.Objetos;
using MVP.Vistas;
namespace MVP.Presentadores
{
    public class PresentadorConceptoCostoCiclo
    {
        private IMostrarConceptoCostoCiclo IconceptoCC;
        private ServicioConceptoCostoCiclo servicioConceptoCostoC;
        public PresentadorConceptoCostoCiclo(IConceptoCostoCiclo ir, IMostrarConceptoCostoCiclo vista)
        {
            servicioConceptoCostoC = new ServicioConceptoCostoCiclo(ir);
            IconceptoCC = vista;
        }


        public void PresentarIdConceptoCostoCiclo()
        {
            CConceptoCostoCiclo cconceptoCC = new CConceptoCostoCiclo();
            cconceptoCC.FkConcepto = IconceptoCC.conceptoCostoC._FkConcepto;
            cconceptoCC.FkCosto = IconceptoCC.conceptoCostoC._FkCosto;
            cconceptoCC.FkCiclo = IconceptoCC.conceptoCostoC._FkCiclo;
            OConceptoCostoCiclo oconceptoCC = servicioConceptoCostoC.ObtenerIdConceptoCostoCiclo(cconceptoCC);
            if (oconceptoCC.Correcto)
                IconceptoCC.MostrarIdConceptoCostoCiclo(oconceptoCC.IdConceptoCostoCiclo);
            else
                IconceptoCC.ErrorConceptoCostoCiclo(string.Format("{0}",oconceptoCC.Excepcion.Message));

        }
    }
}
