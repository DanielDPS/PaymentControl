using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Modelos
{
   public class CarroPago
    {

       List<ConceptoPagoDetalle> _detalle;
       public CarroPago()
       {
           _detalle = new List<ConceptoPagoDetalle>();
       }

       public void AgregarPago(ConceptoPagoDetalle pago)
       {
           int index = _detalle.FindIndex(temp => temp.FkAlumnoGT.Equals(pago.FkAlumnoGT) && temp.FkConceptoCostoC.Equals(pago.FkConceptoCostoC) && temp.NumeroMes.Equals(pago.NumeroMes) );
           if (_detalle.Count == 0 || index < 0)
           {
               _detalle.Add(pago);
           }
           else
           {
               ConceptoPagoDetalle actual = _detalle[index];

                   actual.Pago = pago.Pago;

           }

       }
       public void LimpiarPago()
       {
           _detalle = null;
       }
       public void EliminarPago(int indice)
       {
           _detalle.RemoveAt(indice);
       }
       public IEnumerable<ConceptoPagoDetalle> Lista
       {

           get
           {
               return _detalle;
           }
       }
    }
}
