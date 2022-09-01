namespace ASP_Identity.Models
{
    public class NivelSeguimiento
    {
        public int NivelSeguimientoId { get; set; }
        public Niveles Nivel { get; set; }
    }

    public enum Niveles
    {
        Nacional,
        Estatal,
        Regional,
        Municipal,
        Local
    }
}
