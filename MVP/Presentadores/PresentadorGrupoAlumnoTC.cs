using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio.Criterios;
using Servicio.Objetos;
using Servicio;
using MVP.Vistas;
namespace MVP.Presentadores
{
    public class PresentadorGrupoAlumnoTC
    {
        private IMostrarIdGrupoAlumnoTC IgrupoAlumnoTC;
        private ServicioGrupoAlumnoTC servicioGrupoAlumnoTC;
        public PresentadorGrupoAlumnoTC(IGrupoAlumnoTCRepositorio irepo, IMostrarIdGrupoAlumnoTC vista)
        {
            servicioGrupoAlumnoTC = new ServicioGrupoAlumnoTC(irepo);
            IgrupoAlumnoTC = vista;
        }

        public void PresentarIdGrupoAlumnoTC()
        {
            CGrupoAlumnoTC cgrupotc = new CGrupoAlumnoTC();
            cgrupotc.FkGrupo = IgrupoAlumnoTC.GrupoalumnoTC._FkGrupo;
            cgrupotc.FkAlumno = IgrupoAlumnoTC.GrupoalumnoTC._FkAlumno;
            cgrupotc.FkTurno = IgrupoAlumnoTC.GrupoalumnoTC._FkTurno;
            cgrupotc.FkCiclo = IgrupoAlumnoTC.GrupoalumnoTC._FkCiclo;
            OGrupoAlumnoTC ogrupotc = servicioGrupoAlumnoTC.ObtenerIdGrupoAlumnoTC(cgrupotc);
            if (ogrupotc.Correcto)
                IgrupoAlumnoTC.DevolverIDGrupoAlumnoTC(ogrupotc._Resultado);
            else
                IgrupoAlumnoTC.ErrorIDGrupoAlumnoTC(string.Format("{0}",ogrupotc.Excepcion.Message));

           
        }
    }
}
