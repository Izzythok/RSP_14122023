namespace Entidades.MetodosDeExtension
{
    public static class TiempoExtension
    {
        public static double SegundosTrasncurridos(this DateTime inicio)
        {
            DateTime tiempoActual = DateTime.Now;
            TimeSpan diferencia = tiempoActual - inicio;
            return diferencia.TotalSeconds;
        }
    }
}
