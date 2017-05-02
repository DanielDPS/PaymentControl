using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicio.Vistas;
using Modelos;
namespace Servicio.Conversiones
{
    public static  class CarritoPagos
    {

        public static ConceptoPagoDetalle ConvertirACarroPago (this Costo  costo )
        {
           
            ConceptoPagoDetalle carrop = new ConceptoPagoDetalle();
            carrop.Pago = costo.Precio;
            return carrop;
        }

    }
}
