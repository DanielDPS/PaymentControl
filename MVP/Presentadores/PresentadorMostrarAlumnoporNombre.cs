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
    public class PresentadorMostrarAlumnoporNombre
    {
        private IMostrarAlumnoPorNombreoExpediente ImostrarPornombre;
        private ServicioAlumno servicioAlumno;

        public PresentadorMostrarAlumnoporNombre(IAlumnoRepositorio ialumno, IMostrarAlumnoPorNombreoExpediente vista)
        {
            servicioAlumno = new ServicioAlumno(ialumno);
            ImostrarPornombre = vista;
        }
        public void PresentarAlumnoPorNombreoExpediente()
        {
            OAlumnoLista alumnosslistado = servicioAlumno.ObtenerAlumnos();
            CAlumno calumno = new CAlumno();
            calumno.NombreAlumno = ImostrarPornombre.Nombrealumno;
            OAlumnoLista listado = servicioAlumno.ObtenerAlumnoPorNombreOExpediente(calumno);
            if (listado.Correcto)
            {

                if (ImostrarPornombre.Nombrealumno == null )
                {
                    ImostrarPornombre.MostrarAlumnoporNombre(alumnosslistado.AlumnosLista);
                }
                else 
                ImostrarPornombre.MostrarAlumnoporNombre(listado.AlumnosLista);
            }
            else
                ImostrarPornombre.ErrorAlumnosporNombre(string.Format("{0}", listado.Excepcion.Message));

        }
    }
}
