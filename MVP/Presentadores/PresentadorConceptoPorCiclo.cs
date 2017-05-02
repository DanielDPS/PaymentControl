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
   public class PresentadorConceptoPorCiclo
    {
       private IConceptoPorCiclo iconceptoCiclo;
       private ServicioConcepto servicioConcepto;
       public PresentadorConceptoPorCiclo(IConceptoRepositorio IconceptoR, IConceptoPorCiclo vista)
       {
           servicioConcepto = new ServicioConcepto(IconceptoR);
           iconceptoCiclo = vista;
       }

       public void PresentarConceptoPorCiclo()
       {
           CConcepto cconcepto = new CConcepto();
           cconcepto.FKCiclo = iconceptoCiclo._CicloId;
           OConcepto oconcepto = servicioConcepto.ObtenerConceptoPorCiclo(cconcepto);
           if (oconcepto.Correcto)
               iconceptoCiclo.MostrarConceptoPorCiclo(oconcepto._Concepto);
           else
               iconceptoCiclo.ErrorConceptoPorCiclo(string.Format("{0}","No existe"));

       }
    }
}
