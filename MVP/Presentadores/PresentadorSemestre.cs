using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;
using Servicio;
using MVP.Vistas;
using Servicio.Criterios;
using Servicio.Objetos;
namespace MVP.Presentadores
{
    public  class PresentadorSemestre
    {
        private IMostrarSemestre ImostrarS;
        private ServicioSemestre servicioSemestre;
        public PresentadorSemestre(ISemestreRepositorio Isr, IMostrarSemestre view)
        {
            servicioSemestre = new ServicioSemestre(Isr);
            ImostrarS = view;
        }
        public void PresentarSemestre()
        {
            CSemestre csemestre = new CSemestre();
            csemestre.IdSemestre = ImostrarS.fkCiclo;
            OSemestre osemestre = servicioSemestre.ObtenerSemestrePorId(csemestre);
            if (osemestre.Correcto)
                ImostrarS.MostrarSemestrePorCiclo(osemestre._Semestre);
            else
                ImostrarS.ErrorSemestre(string.Format("{0}",osemestre.Excepcion.Message));

        }

    }
}
