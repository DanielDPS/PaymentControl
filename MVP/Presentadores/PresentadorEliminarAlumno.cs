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
   public  class PresentadorEliminarAlumno
    {
       private IEliminarAlumno ieliminar;
       private ServicioAlumno servicioAlumno;
       public PresentadorEliminarAlumno(IAlumnoRepositorio irepositorio, IEliminarAlumno vista)
       {
           servicioAlumno = new ServicioAlumno(irepositorio);
           ieliminar = vista;
       }
       public void PresentarEliminarAlumno()
       {
           CAlumno calumno = new CAlumno();
           calumno.IdAlumno = ieliminar.idAlumno;
           OAlumnoLista lista = servicioAlumno.EliminarAlumno(calumno);
           if (lista.Correcto)
               ieliminar.EliminarAlumno("Se ha eliminado al alumno con éxito");
           else
               ieliminar.ErrorEliminarAlumno(string.Format("{0}",lista.Excepcion.Message));

       }
    }
}
