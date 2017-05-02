using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace Servicio.Objetos
{
    public class OPagoLista:RespuestaBase
    {
        public IEnumerable<ConceptoPagoDetalle> pagosDetalleLista { get; set; }
        public IEnumerable<ConceptoPagoDetalle> detalles { get; set; }
    }
}
