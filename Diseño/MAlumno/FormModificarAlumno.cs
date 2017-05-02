using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Datos;
using Servicio;
using MVP.Presentadores;
using MVP.Vistas;
namespace Diseño.MAlumno
{
    public partial class FormModificarAlumno : Form,IActualizarAlumno
    {
        private PresentadorModificarAlumno presentadorModificarAlumno;
        private Alumno alumno;
        Alumno alumnoseleccionado;
        public Action _Refresh;
        public FormModificarAlumno(Alumno nuevo)
        {
            InitializeComponent();
            alumnoseleccionado = new Alumno();
            alumnoseleccionado = nuevo;
            txtCodigo.Text = alumnoseleccionado.Id.ToString();
            txtNombre.Text = alumnoseleccionado.Nombre;
            txtApellidos.Text = alumnoseleccionado.Apellidos;
            txtExpediente.Text = alumnoseleccionado.Expediente.ToString();
            presentadorModificarAlumno = new PresentadorModificarAlumno(new SQLAlumnoRepositorio(), this);
            alumno = new Alumno();
        }

        public Alumno alumnoActualizar
        {
            get { return alumno; }
        }

        public void ModificarAlumno(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ErrorModificar(string errormodificar)
        {
            MessageBox.Show(errormodificar,"Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            alumno.Id = alumnoseleccionado.Id;
            alumno.Nombre = txtNombre.Text;
            alumno.Apellidos = txtApellidos.Text;
            alumno.Expediente = int.Parse(txtExpediente.Text);
            presentadorModificarAlumno.PresentarModificarAlumno();
            _Refresh();
            this.Hide();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
