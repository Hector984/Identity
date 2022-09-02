using ASP_Identity.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_Identity.Models
{
    public class TipoInstitucion
    {
        public int TipoInstitucionId { get; set; }
        public string NombreInstitucion { get; set; }
        //Propiedades de navegacion
        public virtual List<ApplicationUser> Usuario { get; set; }
    }

}
