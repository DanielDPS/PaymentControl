using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace Datos
{
   public interface ICicloFechaRepositorio
    {
       FCiclo ObtenerCicloFechaPorId(int id);
       IEnumerable<FCiclo> ObtenerCicloFechaPorFkAlumno(int id);
    }
}
