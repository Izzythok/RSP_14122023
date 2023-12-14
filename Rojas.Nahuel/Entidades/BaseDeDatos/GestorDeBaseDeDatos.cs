using Entidades.Excepciones;
using System.Data.SqlClient;

namespace Entidades.BaseDeDatos
{
    public static class GestorDeBaseDeDatos
    {
        private static SqlConnection connection;
        private static string stringConnection;

        static GestorDeBaseDeDatos()
        {
            GestorDeBaseDeDatos.stringConnection = "Server=.;Database=14122023-rsp;Trusted_Connection=True;";
        }

        public static bool RegistrarTrabajo(string nombreAlumno, int cantidadPacientes)
        {
            try
            {
                using (GestorDeBaseDeDatos.connection = new SqlConnection(GestorDeBaseDeDatos.stringConnection))
                {
                    string query = "INSERT INTO tickets (pacientes_atendidos,alumno) values (@pacientes_atendidos,@alumno)";
                    SqlCommand command = new SqlCommand(query, GestorDeBaseDeDatos.connection);
                    command.Parameters.AddWithValue("pacientes_atendidos", cantidadPacientes);
                    command.Parameters.AddWithValue("alumno", nombreAlumno);
                    GestorDeBaseDeDatos.connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw new ServidorPublicoInvalidoException("Error al insertar datos a la base", ex);
            }
        }
    }
}
