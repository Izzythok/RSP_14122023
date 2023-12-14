using Entidades.Enumerados;
using System.Linq;

namespace Entidades.MetodosDeExtension
{
    public static class EmergenciaExtension
    {
        public static bool ValidarEmergencia(this List<EEmergencia> lista, EEmergencia eEmergencia)
        {
            return lista.Any((e) => e == eEmergencia);
        } 
    }
}
