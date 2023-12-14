using Entidades.Excepciones;
using System.Text.Json;

namespace Entidades.Archivos
{
    public static class GestorDeArchivos
    {

        private static string basePath;

        static GestorDeArchivos()
        {
            GestorDeArchivos.basePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\14122023_Alumno\\";
            GestorDeArchivos.ValidaExistenciaDeDirectorio();

        }

        private static void ValidaExistenciaDeDirectorio()
        {
            if (!Directory.Exists(GestorDeArchivos.basePath))
            {
                try
                {
                    Directory.CreateDirectory(GestorDeArchivos.basePath);
                }
                catch (Exception ex)
                {
                    throw new ServidorPublicoInvalidoException("Error al crear el direcctorio", ex);
                }
            }
        }

        public static void Guardar(string informacion, string path)
        {
            try 
            {
                string archivo = Path.Combine(GestorDeArchivos.basePath, path);
                using (StreamWriter writeFile = new StreamWriter(archivo))
                {
                    writeFile.Write(informacion);
                }
            }
            catch(Exception ex) 
            {
                throw new ServidorPublicoInvalidoException("Error al guardar",ex);
            }
        }

        public static void Serializar<T>(T elemento, string nombreDelArchivo) where T : class
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;
                string json = JsonSerializer.Serialize(elemento, options);
                if (json != null)
                {
                    GestorDeArchivos.Guardar(json, nombreDelArchivo);
                }
            }
            catch(Exception ex)
            {
                throw new ServidorPublicoInvalidoException("Erro al serializar",ex);
            }
           
        }

    }
}
