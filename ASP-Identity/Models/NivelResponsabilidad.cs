using ASP_Identity.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_Identity.Models
{
    public class NivelResponsabilidad
    {
        public int NivelResponsabilidadId { get; set; }
        public string Nombre { get; set; }
        //Propiedades de navegacion
        public virtual List<ApplicationUser> Usuario { get; set; }
    }
}
