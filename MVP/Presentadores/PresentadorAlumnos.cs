using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;
using Servicio;
using Servicio.Criterios;
using Servicio.Objetos;
using MVP.Vistas;
namespace MVP.Presentadores
{
    public  class PresentadorAlumnos
    {

        private IMostrarAlumno ImostrarA;
        private ServicioAlumno servicioAlumno;
        public PresentadorAlumnos(IAlumnoRepositorio IalumnoR,IMostrarAlumno view)
        {
            servicioAlumno = new ServicioAlumno(IalumnoR);
            ImostrarA = view;
        }

        public void PresentarAlumnos()
        {
            CAlumno calumno = new CAlumno();
            calumno.FkTurno = ImostrarA.IdTurno;
            calumno.FkGrupo = ImostrarA.IdGrupo;
            OAlumnoLista listado = servicioAlumno.ListadoAlumnosPorId(calumno);
            if (listado.Correcto)
            {
                ImostrarA.MostrarAlumnosPorTurnoYGrupo(listado.ListaAlumnos);
            }
            else
            {
                ImostrarA.ErrorAlumnoPorGrupoYTurno(string.Format("{0}",listado.Excepcion.Message));

            }

        }
    }
}
