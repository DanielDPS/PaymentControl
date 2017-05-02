using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
    public interface IActualizarAlumno
    {
        Alumno alumnoActualizar { get; }
        void ModificarAlumno(string mensaje);
        void ErrorModificar(string errormodificar);
    }
}
