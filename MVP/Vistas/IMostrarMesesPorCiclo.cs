using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
   public interface IMostrarMesesPorCiclo
    {
       int _Fkciclo { get; }
       void MostrarMesesPorCiclo(IEnumerable<Mes> meses);
       void ErrorMesesPorCiclo(string error);
    }
}
