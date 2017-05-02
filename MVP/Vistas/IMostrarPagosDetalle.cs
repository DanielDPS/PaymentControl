using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
    public interface IMostrarPagosDetalle
    {
        void MostrarPagosDetalle(IEnumerable<ConceptoPagoDetalle> pagos);
        void ErrorPagosDetalle(string error);
    }
}
