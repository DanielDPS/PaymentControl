using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Servicio;
using Modelos;
using Servicio.Objetos;
using Servicio.Criterios;
using MVP.Vistas;
namespace MVP.Presentadores
{
     public class PresentadorUsuario
    {
        private IMostrarUsuario Imostrarusuario;
        private ServicioUsuario servicioUsuario;

        public PresentadorUsuario(IUsuarioRepositorio Iusuario, IMostrarUsuario vista)
        {
            servicioUsuario = new ServicioUsuario(Iusuario);
            Imostrarusuario = vista;

        }
        public void PresentarInicioSesion()
        {
            CUsuario cusuario = new CUsuario();
            cusuario.Cusuario = Imostrarusuario.Gusuario.PUsuario;
            cusuario.Ccontrasena = Imostrarusuario.Gusuario.Contraseña;
            OUsuario ousuario = servicioUsuario.ObtenerUsuarioPorUsuarioYContrasena(cusuario);
            if (ousuario.Correcto)
                Imostrarusuario.Mostrar(ousuario.Ousuario);
            else
                Imostrarusuario.Error(string.Format("{0}","El usuario: "+cusuario.Cusuario+" no existe, por favor intentelo de nuevo"));
            

        }
    }
}
