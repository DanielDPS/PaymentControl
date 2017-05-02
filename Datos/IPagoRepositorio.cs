using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace Datos
{
    public interface IPagoRepositorio
    {
        void RealizarPago(ConceptoPago pago);
         IEnumerable<ConceptoPagoDetalle>  MostrarPagos ();
         IEnumerable<ConceptoPagoDetalle> MostrarPagosPorAlumno(string filtro);
    }
}
