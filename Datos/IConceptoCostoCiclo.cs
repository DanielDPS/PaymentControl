using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace Datos
{
    public interface IConceptoCostoCiclo
    {
         int ObtenerIdConceptoCostoCiclo(int  fkconcepto,int fkcosto, int fkciclo);
    }
}
