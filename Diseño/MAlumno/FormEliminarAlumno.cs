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
using MVP.Vistas;
using MVP.Presentadores;
namespace Diseño.MAlumno
{
    public partial class FormEliminarAlumno : Form,IEliminarAlumno
    {
        private Alumno alumno;
        private PresentadorEliminarAlumno presentadorEliminarAlumno;
        public Action _Refresh;
        public FormEliminarAlumno(Alumno entrada)
        {
            InitializeComponent();
            alumno = new Alumno();
            alumno = entrada;
            txtCodigo.Text = alumno.Id.ToString();
            txtNombre.Text = alumno.Nombre;
            txtApellidos.Text = alumno.Apellidos;
            txtExpediente.Text = alumno.Expediente.ToString();
            presentadorEliminarAlumno = new PresentadorEliminarAlumno(new SQLAlumnoRepositorio(), this);


        }

        public int idAlumno
        {
            get { return alumno.Id; }
        }

        public void EliminarAlumno(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void ErrorEliminarAlumno(string erroreliminar)
        {
            MessageBox.Show(erroreliminar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            presentadorEliminarAlumno.PresentarEliminarAlumno();
            _Refresh();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
