using ASP_Identity.Areas.Identity.Data;

namespace ASP_Identity.Models
{
    public class TipoInstitucion
    {
        public int TipoInstitucionId { get; set; }
        public string NombreInstitucion { get; set; }
        //Propiedades de navegacion
        public int UsuarioId { get; set; }
        public virtual ApplicationUser Usuario { get; set; }
    }

}
