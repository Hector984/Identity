using ASP_Identity.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_Identity.Models
{
    public class NivelSeguimiento
    {
        public int NivelSeguimientoId { get; set; }
        public Niveles Nivel { get; set; }
        //Propiedades de navegacion
        public virtual List<ApplicationUser> Usuario { get; set; }
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
