using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio;
using Servicio.Objetos;
using MVP.Vistas;
namespace MVP.Presentadores
{
    public class PresentadorMostrarAlumnos
    {
        private IMostrarAlumnos ImostrarAlumnos;
        private ServicioAlumno servicioAlumno;

        public PresentadorMostrarAlumnos(IAlumnoRepositorio IalumnoR, IMostrarAlumnos vista)
        {
            servicioAlumno = new ServicioAlumno(IalumnoR);
            ImostrarAlumnos = vista;

        }
        public void PresentarMostrarAlumnos()
        {
            OAlumnoLista listado = servicioAlumno.ObtenerAlumnos();
            if (listado.Correcto)
                ImostrarAlumnos.MostrarAlumnos(listado.AlumnosLista);
            else
                ImostrarAlumnos.ErrorAlumnos(string.Format("{0}",listado.Excepcion.Message));

        }


    }
}
