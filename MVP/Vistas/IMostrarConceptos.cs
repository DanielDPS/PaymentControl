using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
    public interface IMostrarConceptos
    {
        void MostrarConceptos(IEnumerable<Concepto> gConceptos);
        void ErrorConcepto(string errorConcepto);
    }
}
