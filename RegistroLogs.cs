using pryInicioSesionLogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBlaiotta2705
{
    public partial class RegistroLogs : Form
    {
        clsUsuario usuario;
        public RegistroLogs()
        {
            InitializeComponent();
            usuario = new clsUsuario();
        }

        private void btnRegistrarLogs_Click(object sender, EventArgs e)
        {
            string categoria = txtCategoria.Text;
            string descripcion = txtDescripcion.Text;

            // Validar que se haya ingresado la categoría y la descripción
            if (string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor ingrese la categoría y la descripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Registrar el log
            usuario.RegistroLogInicioSesion(categoria, descripcion);

            // Verificar el estado de la conexión
            if (usuario.estadoConexion == "Registro exitoso de log")
            {
                MessageBox.Show("Registro de log exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Puedes cerrar el formulario o realizar otras acciones necesarias después del registro exitoso.
            }
            else
            {
                MessageBox.Show("Error al registrar el log: " + usuario.estadoConexion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearUsuarios_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario CrearUsuarios.cs
            CrearUsuarios crearUsuariosForm = new CrearUsuarios();

            // Mostrar el formulario CrearUsuarios.cs
            crearUsuariosForm.Show();
        }
    }
}
