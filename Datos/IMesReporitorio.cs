using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace Datos
{
   public  interface IMesReporitorio
    {
       IEnumerable<Mes> ObtenerMesesPorFkCiclo(int id);
    }
}
