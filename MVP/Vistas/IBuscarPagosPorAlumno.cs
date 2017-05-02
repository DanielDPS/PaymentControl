using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
    public interface IBuscarPagosPorAlumno
    {
        string FiltroNomre { get; }
        void MostrarPagosPorAlumno(IEnumerable<ConceptoPagoDetalle> pagosAlumnos);
        void ErrorPagosPorAlumno(string errorPagos);
    }
}
