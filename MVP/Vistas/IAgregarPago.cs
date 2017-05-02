using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
   public interface IAgregarPago
    {
       ConceptoPago pago { get; }
       void PagoCorrecto(string mensaje);
       void ErrorPago(string error);
    }
}
