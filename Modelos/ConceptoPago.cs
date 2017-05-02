using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ConceptoPago
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public IEnumerable<ConceptoPagoDetalle> detalle;

    }
}
