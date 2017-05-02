using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class SesionUsuario
    {
        public Usuario Usuarioactual { get; set; }
        private static SesionUsuario _Instancia;
        private static volatile object lock_this = new object();

        public static SesionUsuario Instancia
        {
            get
            {
                if (_Instancia == null)
                {
                    lock (lock_this)
                    {
                        _Instancia = new SesionUsuario();
                    }
                }
                return _Instancia;
            }
        }
    }
}
