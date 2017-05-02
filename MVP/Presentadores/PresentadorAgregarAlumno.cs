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
   public class PresentadorAgregarAlumno
    {
       private IAgregarAlumno iagregar;
       private ServicioAlumno servicioAlumno;
       public PresentadorAgregarAlumno(IAlumnoRepositorio ialumno ,IAgregarAlumno vista)
       {
           servicioAlumno = new ServicioAlumno(ialumno);
           iagregar = vista;
       }
       public void PresentarAgregarAlumno()
       {
           CAlumno calumno = new CAlumno();
           OAlumno oalumno = new OAlumno();
           oalumno._Alumno = iagregar.alumno;
           calumno.FkGrupo = iagregar.idgrupo;
           calumno.FkTurno = iagregar.idturno;
           OAlumnoLista lista = servicioAlumno.InsertarAlumno(oalumno,calumno);
           if (lista.Correcto)
               iagregar.AgregarAlumno("Se ha guardado al alumno con éxito");
           else
               iagregar.ErrorAlumno(string.Format("{0}",lista.Excepcion.Message));


       }
    }
}
