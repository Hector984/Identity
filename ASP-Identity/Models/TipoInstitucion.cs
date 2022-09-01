using ASP_Identity.Areas.Identity.Data;

namespace ASP_Identity.Models
{
    public class TipoInstitucion
    {
        public int TipoInstitucionId { get; set; }
        public string NombreInstitucion { get; set; }
        public int UserId { get; set; }
        public ApplicationUser User  { get; set; }
    }

}
