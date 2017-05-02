using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;
using Servicio;
using Servicio.Criterios;
using Servicio.Objetos;
namespace MVP.Vistas
{
    public interface IMostrarUsuario
    {

        Usuario Gusuario { get; }
        void Mostrar(Usuario usuario);
        void Error(string error);

    }
}
