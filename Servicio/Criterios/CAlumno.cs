using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Criterios
{
   public class CAlumno
    {
       public int FkTurno { get; set; }
       public int FkGrupo { get; set; }
       public int IdAlumno { get; set; }

       public string NombreAlumno { get; set; }
       public int ExpedienteAlumno { get; set; }
    }
}
