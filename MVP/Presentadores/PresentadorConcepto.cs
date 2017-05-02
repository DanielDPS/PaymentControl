using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Servicio;
using Datos;
using Servicio.Objetos;
using MVP.Vistas;
namespace MVP.Presentadores
{
     public class PresentadorConcepto
    {
         private IMostrarConceptos Iconceptos;
         private ServicioConcepto servicioConcepto;
         public PresentadorConcepto(IConceptoRepositorio IconceptoR, IMostrarConceptos vista)
         {
             servicioConcepto = new ServicioConcepto(IconceptoR);
             Iconceptos = vista;
         }
         public void PresentarConceptos()
         {
             OConceptoLista listadoConceptos = servicioConcepto.ObtenerConceptos();
             if (listadoConceptos.Correcto)
                 Iconceptos.MostrarConceptos(listadoConceptos.ListaConcepto);
             else
                 Iconceptos.ErrorConcepto(string.Format("{0}",listadoConceptos.Excepcion.Message));
         }
    }
}
