using Entidades.Enumerados;
using Entidades.Interfaces;

namespace Entidades.Modelos
{


    public class CentroDeEmergencia
    {

        private string nombre;
        private Emergencia emergenciaEnCurso;
        private List<Emergencia> emergenciasAtendidas;


        public CentroDeEmergencia(string nombre)
        {
            this.nombre = nombre;
            this.emergenciasAtendidas = new List<Emergencia>();
        }

        public string Nombre { get => this.nombre; }
        public List<Emergencia> EmergenciasAtendidas { get => this.emergenciasAtendidas; }

        public void HabilitarIngreso()
        {
            Random random = new Random();
            List<EEmergencia> emergencias = new List<EEmergencia>() { EEmergencia.Incendios, EEmergencia.Rescates, EEmergencia.Emergencias_Medicas, EEmergencia.Desastres_Naturales, EEmergencia.Accidentes_De_Trafico};

            this.emergenciaEnCurso = new Emergencia(emergencias.Find((e) => (int)e == random.Next(0, 4)));
        }

        private void DarSeguimientoAEmergencia()
        {

        }

        public void EnviarServidorPublico<T>(T servidorPublico) where T : IServidorPublico
        {


        }

        public void DeshabilitarIngreso()
        {

        }

        private void NotificarEstadoDeEmergenciaEnCurso()
        {

        }
    }
}
