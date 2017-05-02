using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace Servicio.Conversiones
{
    public static  class PagoFabrica
    {

        public static ConceptoPago ConvertAPago(this CarroPago carropago)
        {
            ConceptoPago colpago = new ConceptoPago();
            colpago.Fecha = DateTime.Now;
            colpago.detalle = carropago.Lista;
            return colpago;


           
        }
    }
}
