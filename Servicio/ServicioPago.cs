using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;
using Servicio.Criterios;
using Servicio.Objetos;
using Servicio.Conversiones;

namespace Servicio
{
     public class ServicioPago
    {

         private IPagoRepositorio IpagoR;
         public ServicioPago(IPagoRepositorio IPR)
         {
             IpagoR = IPR;
         }

         public OPagoLista ObtenerPagosPorAlumno(CPago cpago)
         {
             OPagoLista lista = new OPagoLista();
             try
             {
                 IEnumerable<ConceptoPagoDetalle> pagos = IpagoR.MostrarPagosPorAlumno(cpago._Filtro);
                 lista.detalles = pagos;
                 lista.Correcto = true;
             }
             catch (Exception e)
             {
                 lista.Excepcion = e;
                 lista.Correcto = false;
               
             }
             return lista;
         }

         public OPago EjecutarPago(CPago cpago)
         {
             OPago opago = new OPago();
             try
             {
                 IpagoR.RealizarPago(cpago._Pago);
                 opago.Correcto = true;

             }
             catch (Exception e)
             {
                 opago.Excepcion = e;
                 opago.Correcto = false;

             }

             return opago;

         }
         public OPagoLista ObtenerPagosDetalle()
         {
             OPagoLista lista = new OPagoLista();

                 IEnumerable<ConceptoPagoDetalle> pagos = IpagoR.MostrarPagos();
                 lista.pagosDetalleLista = pagos;
                 lista.Correcto = true;

             return lista;
         }
    }
}
