using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio.Objetos;
namespace Servicio
{
    public class ServicioTurno
    {
        public ITurnoRepositorio Iturnos;
        public ServicioTurno(ITurnoRepositorio Itr)
        {
            Iturnos = Itr;
        }

        public OTurnoLista ObtenerTurnos()
        {
            OTurnoLista listaTurno = new OTurnoLista();
            try
            {
                IEnumerable<Turno> turnos = Iturnos.ObtenerTurnos();
                listaTurno.TurnoLista = turnos;
                listaTurno.Correcto = true;
            }
            catch (Exception e )
            {

                listaTurno.Excepcion = e;
                listaTurno.Correcto = false;
            }
            return listaTurno;
        }
    }
}
