using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
   public  interface IMostrarIdGrupoAlumnoTC
    {
       GrupoAlumnoTC GrupoalumnoTC { get; }
       void DevolverIDGrupoAlumnoTC(int idGrupoAlumnoTC);
       void ErrorIDGrupoAlumnoTC(string errorTC);
    }
}
