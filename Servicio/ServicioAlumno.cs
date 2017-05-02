using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Servicio.Conversiones;
using Servicio.Vistas;
using Servicio.Objetos;
using Servicio.Criterios;
using Modelos;
namespace Servicio
{
    public  class ServicioAlumno
    {

        private IAlumnoRepositorio IalumnoR;
        public ServicioAlumno(IAlumnoRepositorio alumno)
        {
            IalumnoR = alumno;
        }

        public OAlumnoLista ObtenerAlumnos()
        {
            OAlumnoLista listadoAlumnos = new OAlumnoLista();
            try
            {
                IEnumerable<Alumno> alumnos = IalumnoR.ObtenerAlumnos();
                listadoAlumnos.AlumnosLista = alumnos;
                listadoAlumnos.Correcto = true;
            }
            catch (Exception e)
            {
                listadoAlumnos.Excepcion = e;
                listadoAlumnos.Correcto = false;
            }
            return listadoAlumnos;

        }

        public OAlumno ObtenerAlumnoPorId(CAlumno calumno)
        {
            OAlumno alumno = new OAlumno();
            try
            {
                Alumno palumno = IalumnoR.ObtenerAlumnoPorId(calumno.IdAlumno);
                if (palumno.Id.Equals(calumno.IdAlumno))
                {
                    alumno._Alumno = palumno;
                    alumno.Correcto = true;
                }
                else
                {

                    alumno.Correcto = false;
                }

            }
            catch (Exception)
            {
                
                throw;
            }
            return alumno;

        }

        public OAlumnoLista ListadoAlumnosPorId(CAlumno calumno)
        {
            OAlumnoLista listado = new OAlumnoLista();
            try
            {
                IEnumerable<AlumnoViewModel> alumnos = IalumnoR.ObtenerAlumnosPorTurnoYGrupo(calumno.FkTurno,calumno.FkGrupo).ConvertirAListaAlumnoViewModel();
               listado.ListaAlumnos = alumnos;
               listado.Correcto = true;
                
            }
            catch (Exception e)
            {
                listado.Excepcion = e;
                listado.Correcto = false;
            }
            return listado;

        }

        public OAlumnoLista InsertarAlumno(OAlumno oalumno,CAlumno calumno)
        {
            OAlumnoLista listado = new OAlumnoLista();
            try
            {
                IalumnoR.AgregarAlumno(oalumno._Alumno,calumno.FkGrupo,calumno.FkTurno);
                listado.Correcto = true;
            }
            catch (Exception e) 
            {
                listado.Excepcion = e;
                listado.Correcto = false;
            }
            return listado;
        }

        public OAlumnoLista ActualizarAlumno(OAlumno oalumno)
        {
            OAlumnoLista listado = new OAlumnoLista();
            try
            {
                IalumnoR.ActualizarAlumno(oalumno._Alumno);
                listado.Correcto = true;
            }
            catch (Exception e)
            {

                listado.Excepcion = e;
                listado.Correcto = false;
            }
            return listado;
        }

        public OAlumnoLista EliminarAlumno(CAlumno calumno)
        {
            OAlumnoLista listado = new OAlumnoLista();
            try
            {
                IalumnoR.EliminarAlumno(calumno.IdAlumno);
                listado.Correcto = true;
            }
            catch (Exception e)
            {
                listado.Excepcion = e;
                listado.Correcto = false;
                
            }
            return listado;
        }


        public OAlumnoLista ObtenerAlumnoPorNombreOExpediente(CAlumno calumno)
        {
            OAlumnoLista listado = new OAlumnoLista();
            try
            {
                IEnumerable<Alumno> alumnos = IalumnoR.ObtenerAlumnosPorNombreOExpediente(calumno.NombreAlumno);
                listado.AlumnosLista = alumnos;
                listado.Correcto = true;

            }
            catch (Exception e)
            {
                listado.Excepcion = e;
                listado.Correcto = false;
                
            }
            return listado;
        }
    }
}
