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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            // Consulta para obtener el número total de usuarios registrados
            string consultaUsuarios = "SELECT COUNT(*) FROM Usuarios";
            int totalUsuarios = 0;

            using (OleDbConnection conexion = new OleDbConnection("tu_cadena_de_conexion"))
            {
                using (OleDbCommand comandoUsuarios = new OleDbCommand(consultaUsuarios, conexion))
                {
                    conexion.Open();
                    totalUsuarios = (int)comandoUsuarios.ExecuteScalar();
                }
            }

            // Consulta para obtener el número total de sesiones iniciadas
            string consultaSesiones = "SELECT COUNT(*) FROM Sesiones";
            int totalSesiones = 0;

            using (OleDbConnection conexion = new OleDbConnection("tu_cadena_de_conexion"))
            {
                using (OleDbCommand comandoSesiones = new OleDbCommand(consultaSesiones, conexion))
                {
                    conexion.Open();
                    totalSesiones = (int)comandoSesiones.ExecuteScalar();
                }
            }

            // Mostrar los resultados en un MessageBox (solo a modo de ejemplo)
            MessageBox.Show($"Número total de usuarios registrados: {totalUsuarios}\nNúmero total de sesiones iniciadas: {totalSesiones}", "Reporte de actividad de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
