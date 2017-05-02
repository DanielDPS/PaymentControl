using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicio.Vistas;
using Modelos;
namespace Servicio.Conversiones
{
    public static class AlumnoViewModelFactory
    {

        public static IEnumerable<AlumnoViewModel> ConvertirAListaAlumnoViewModel(this IEnumerable<Alumno> alumnos)
        {
            IList<AlumnoViewModel> listado = new List<AlumnoViewModel>();
            foreach (Alumno alumno in alumnos)
            {
                listado.Add(alumno.ConvertirAAlumnoViewModel());    
            }
            return listado;

        }
        public static AlumnoViewModel ConvertirAAlumnoViewModel(this Alumno alumno)
        {
            AlumnoViewModel alumnoviewm = new AlumnoViewModel();
            alumnoviewm.Id = Convert.ToString(alumno.Id);
            alumnoviewm.Nombre = alumno.Nombre;
            alumnoviewm.Apellidos = alumno.Apellidos;
            alumnoviewm.Expediente = Convert.ToString(alumno.Expediente);

            return alumnoviewm;

        }
    }
}
