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
    public partial class Form1 : Form
    {
        clsUsuario usuario;

        public Form1()
        {
            InitializeComponent();
            usuario = new clsUsuario();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Validar las credenciales
            usuario.ValidarUsuario(nombreUsuario, contraseña);

            // Verificar el estado de la conexión
            if (usuario.estadoConexion == "Usuario EXISTE")
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí puedes abrir la siguiente ventana o realizar otras acciones necesarias después de iniciar sesión correctamente.
                this.Hide();

                // Abrir el formulario de logs
                RegistroLogs registroLogsForm = new RegistroLogs();
                registroLogsForm.ShowDialog();

                // Una vez que se cierre el formulario de logs, cerrar la aplicación
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
