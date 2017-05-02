using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Modelos;
using Servicio;
using MVP.Presentadores;
using MVP.Vistas;

namespace Diseño
{
    public partial class FormLogin : Form,IMostrarUsuario
    {
        private PresentadorUsuario presentadorUsuario;
        private Usuario _Usuario;
        public FormLogin()
        {
            InitializeComponent();
            presentadorUsuario = new PresentadorUsuario(new SQLUsuarioRepositorio(), this);
            _Usuario = new Usuario();

        }

        public Usuario Gusuario
        {
            get { return _Usuario; }
        }

        public void Mostrar(Usuario usuario)
        {
            SesionUsuario.Instancia.Usuarioactual = usuario;
            FormMenu frmMenu = new FormMenu(this);
            frmMenu.Show();
            this.Hide();
           
        }

        public void Error(string error)
        {
            MessageBox.Show(error, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {
            _Usuario.PUsuario = txtUsuario.Text;
            _Usuario.Contraseña = txtContrasena.Text;
            presentadorUsuario.PresentarInicioSesion();
        }
 
    }
}
