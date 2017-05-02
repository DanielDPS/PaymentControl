using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio.Criterios;
using Servicio.Objetos;
namespace Servicio
{
    public class ServicioConceptoCostoCiclo
    {

        private IConceptoCostoCiclo IconceptoCC;
        public ServicioConceptoCostoCiclo(IConceptoCostoCiclo ICCC)
        {
            IconceptoCC = ICCC;
        }

        public OConceptoCostoCiclo ObtenerIdConceptoCostoCiclo(CConceptoCostoCiclo cconceptoCC)
        {
            OConceptoCostoCiclo oconceptocc = new OConceptoCostoCiclo();
            try
            {
                int  ID = IconceptoCC.ObtenerIdConceptoCostoCiclo(cconceptoCC.FkConcepto, cconceptoCC.FkCosto, cconceptoCC.FkCiclo);
                oconceptocc.IdConceptoCostoCiclo = ID;
                oconceptocc.Correcto = true;



            }
            catch (Exception e )
            {
                oconceptocc.Excepcion = e;
                oconceptocc.Correcto = false;

            }
            return oconceptocc;

        }
    }
}
