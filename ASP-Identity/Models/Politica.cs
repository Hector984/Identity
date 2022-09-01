using ASP_Identity.Areas.Identity.Data;

namespace ASP_Identity.Models
{
    public class Politica
    {
        public int PoliticaId { get; set; }
        public string NombrePolitica { get; set; }

        //Propiedades de navegacion
        public int UsuarioId { get; set; }
        public virtual ApplicationUser Usuario { get; set; }
    }
}
