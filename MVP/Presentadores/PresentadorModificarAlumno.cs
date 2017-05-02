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
    public class PresentadorModificarAlumno
    {
        private IActualizarAlumno iactualizar;
        private ServicioAlumno servicioAlumno;
        public PresentadorModificarAlumno(IAlumnoRepositorio irepositorio, IActualizarAlumno vista)
        {
            servicioAlumno = new ServicioAlumno(irepositorio);
            iactualizar = vista;
        }

        public void PresentarModificarAlumno()
        {
            OAlumno oalumno = new OAlumno();
            oalumno._Alumno = iactualizar.alumnoActualizar;
            OAlumnoLista lista = servicioAlumno.ActualizarAlumno(oalumno);
            if (lista.Correcto)
                iactualizar.ModificarAlumno("Se ha modificado al alumno con éxito");
            else
                iactualizar.ErrorModificar(string.Format("{0}",lista.Excepcion.Message));

        }
    }
}
