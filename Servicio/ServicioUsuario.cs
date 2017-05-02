using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Servicio;
using Servicio.Criterios;
using Servicio.Objetos;
using Modelos;
namespace Servicio
{
    public class ServicioUsuario
    {
        IUsuarioRepositorio IusuarioR;
        public ServicioUsuario(IUsuarioRepositorio IUR)
        {
            IusuarioR = IUR;
        }

        public OUsuario ObtenerUsuarioPorUsuarioYContrasena(CUsuario cusuario)
        {
            OUsuario ousuario = new OUsuario();
            try
            {
                Usuario pusuario = IusuarioR.ObtenerUsuarioPorUsuarioyContra(cusuario.Cusuario,cusuario.Ccontrasena);
                if (pusuario.PUsuario.Equals(cusuario.Cusuario) && pusuario.Contraseña.Equals(cusuario.Ccontrasena))
                {
                    ousuario.Ousuario = pusuario;
                    ousuario.Correcto = true;
                }
                else
                {
                    ousuario.Correcto = false;
                }

            }
            catch (Exception e)
            {
            }

            return ousuario;

        }
    }
}
