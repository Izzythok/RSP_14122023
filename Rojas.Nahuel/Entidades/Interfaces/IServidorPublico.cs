using Entidades.Modelos;

namespace Entidades.Interfaces
{
    public interface IServidorPublico
    {
        public string Imagen { get; }

        public void Atender(Emergencia emergencia);
    }
}
