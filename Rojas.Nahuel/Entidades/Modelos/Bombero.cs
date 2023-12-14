using Entidades.Interfaces;

namespace Entidades.Modelos
{
    public class Bombero : IServidorPublico
    {
        public string Imagen
        { 
            get 
            {
                return $"./assets/{this.GetType().Name}.gif";
            }
        }

        public void Atender(Emergencia emergencia)
        {
            emergencia.EstaAtendida = true;
        }
    }
}
