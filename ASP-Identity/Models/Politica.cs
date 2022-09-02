using ASP_Identity.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_Identity.Models
{
    public class Politica
    {
        public int PoliticaId { get; set; }
        public string NombrePolitica { get; set; }

        //Propiedades de navegacion
        //public virtual List<ApplicationUser> Usuario { get; set; }
    }
}
