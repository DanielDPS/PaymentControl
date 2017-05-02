using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
    public interface IMostrarTurnos
    {
        void MostrarTurnos(IEnumerable<Turno> gTurnos);
        void ErrorTurnos(string error);
    }
}
