using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
    public interface IMostrarCiclos
    {
        void MostrarCiclos(List<Ciclo> ciclos);
        void ErrorMostrarCiclos(string errorCiclos);
    }
}
