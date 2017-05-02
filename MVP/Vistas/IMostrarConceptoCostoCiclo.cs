using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
    public interface IMostrarConceptoCostoCiclo
    {
        ConceptoCostoCiclo conceptoCostoC { get; }
        void MostrarIdConceptoCostoCiclo(int IdC);
        void ErrorConceptoCostoCiclo(string error);
    }
}
