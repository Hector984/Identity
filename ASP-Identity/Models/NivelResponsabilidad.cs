using ASP_Identity.Areas.Identity.Data;

namespace ASP_Identity.Models
{
    public class NivelResponsabilidad
    {
        public int NivelResponsabilidadId { get; set; }
        public string Nombre { get; set; }
        //Propiedades de navegacion
        public int UsuarioId { get; set; }
        public virtual ApplicationUser Usuario { get; set; }
    }
}
