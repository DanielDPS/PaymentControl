using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class GrupoAlumnoTC
    {
       public int _FkGrupo { get; set; }
       public int _FkAlumno { get; set; }
       public int _FkTurno { get; set; }
       public int _FkCiclo { get; set; }
    }
}
