using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicio.Vistas;
using Modelos;
namespace MVP.Vistas
{
    public interface IMostrarAlumno
    {
        int IdTurno { get; }
        int IdGrupo { get; }
        void MostrarAlumnosPorTurnoYGrupo(IEnumerable<AlumnoViewModel> alumnoviewmodel);
        void ErrorAlumnoPorGrupoYTurno(string error);
    }
}
