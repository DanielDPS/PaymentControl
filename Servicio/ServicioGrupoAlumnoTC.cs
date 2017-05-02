using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio.Criterios;
using Servicio.Objetos;

namespace Servicio
{
    public class ServicioGrupoAlumnoTC
    {

        private IGrupoAlumnoTCRepositorio IgrupoAlumnotc;
        public ServicioGrupoAlumnoTC(IGrupoAlumnoTCRepositorio Ig)
        {

            IgrupoAlumnotc = Ig;
        }

        public OGrupoAlumnoTC ObtenerIdGrupoAlumnoTC(CGrupoAlumnoTC cgrupo)
        {
            OGrupoAlumnoTC ogrupoAlumnoTC = new OGrupoAlumnoTC();
            try
            {
                int idindice = IgrupoAlumnotc.ObtenerIdIndiceGrupoAlumnoTC(cgrupo.FkGrupo, cgrupo.FkAlumno, cgrupo.FkTurno, cgrupo.FkCiclo);
                ogrupoAlumnoTC._Resultado = idindice;
                ogrupoAlumnoTC.Correcto = true;
            }
            catch (Exception e )
            {

                ogrupoAlumnoTC.Excepcion = e;
                ogrupoAlumnoTC.Correcto = false;
            }
            return ogrupoAlumnoTC;
        }
    }
}
