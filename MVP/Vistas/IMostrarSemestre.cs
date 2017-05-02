using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
    public interface IMostrarSemestre
    {
        int  fkCiclo { get; }
        void MostrarSemestrePorCiclo(Semestre gSemestre);
        void ErrorSemestre(string errorsemestre);
    }
}
