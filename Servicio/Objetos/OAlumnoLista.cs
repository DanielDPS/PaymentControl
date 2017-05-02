using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicio.Vistas;
using  Modelos;
namespace Servicio.Objetos
{
    public class OAlumnoLista:RespuestaBase
    {
        public IEnumerable<AlumnoViewModel> ListaAlumnos { get; set; }
        public IEnumerable<Alumno> AlumnosLista { get; set; }
    }
}
