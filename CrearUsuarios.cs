using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBlaiotta2705
{
    public partial class CrearUsuarios : Form
    {
        public CrearUsuarios()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            // Obtener la información del usuario ingresada por el usuario
            string nombreUsuario = txtNombre.Text;
            string contraseña = txtContraseña.Text;
            string tipoUsuario = "";

            // Determinar el tipo de usuario seleccionado
            if (rbCompra.Checked)
            {
                tipoUsuario = "Compra";
            }
            else if (rbVenta.Checked)
            {
                tipoUsuario = "Venta";
            }

            // Validar que se haya seleccionado un tipo de usuario
            if (string.IsNullOrEmpty(tipoUsuario))
            {
                MessageBox.Show("Por favor seleccione un tipo de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Establecer la conexión con la base de datos
                using (OleDbConnection conexion = new OleDbConnection("tu_cadena_de_conexion"))
                {
                    // Abrir la conexión
                    conexion.Open();

                    // Crear un comando SQL para insertar el nuevo usuario en la base de datos
                    string consulta = "INSERT INTO Usuarios (NombreUsuario, Contraseña, TipoUsuario) VALUES (@nombreUsuario, @contraseña, @tipoUsuario)";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        // Asignar los valores de los parámetros
                        comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        comando.Parameters.AddWithValue("@contraseña", contraseña);
                        comando.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);

                        // Ejecutar la consulta SQL
                        comando.ExecuteNonQuery();
                    }
                }

                // Mostrar un mensaje de éxito
                MessageBox.Show("Usuario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre algún problema durante la creación del usuario
                MessageBox.Show("Error al crear usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
