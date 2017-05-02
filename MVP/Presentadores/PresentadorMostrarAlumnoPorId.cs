using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio;
using Servicio.Criterios;
using Servicio.Objetos;
using MVP.Vistas;
namespace MVP.Presentadores
{
     public class PresentadorMostrarAlumnoPorId
    {
         private IMostrarAlumnoPorId Ialumnoid;
         private ServicioAlumno servicioAlumno;
         public PresentadorMostrarAlumnoPorId(IAlumnoRepositorio alumnoR, IMostrarAlumnoPorId vista)
         {
             servicioAlumno = new ServicioAlumno(alumnoR);
             Ialumnoid = vista;
         }
         public void PresentarAlumnoPorID()
         {
             CAlumno calumno = new CAlumno();
             calumno.IdAlumno = Ialumnoid.IdAlumno;
             OAlumno oalumno = servicioAlumno.ObtenerAlumnoPorId(calumno);
             if (oalumno.Correcto)
                 Ialumnoid.Mostraralumno(oalumno._Alumno);
             else
                 Ialumnoid.ErrorAlumno("No se encontro alumno relacionado");
         }
    }
}
