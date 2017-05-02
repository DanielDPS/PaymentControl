using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Criterios
{
    public  class CGrupoAlumnoTC
    {
        public int FkGrupo { get; set; }
        public int FkAlumno { get; set; }
        public int FkTurno { get; set; }
        public int FkCiclo { get; set; }
    }
}
