using ASP_Identity.Areas.Identity.Data;

namespace ASP_Identity.Models
{
    public class NivelSeguimiento
    {
        public int NivelSeguimientoId { get; set; }
        public Niveles Nivel { get; set; }
        //Propiedades de navegacion
        public int UsuarioId { get; set; }
        public virtual ApplicationUser Usuario { get; set; }
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
