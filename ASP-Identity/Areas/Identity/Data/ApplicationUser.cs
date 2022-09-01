using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ASP_Identity.Models;
using Microsoft.AspNetCore.Identity;

namespace ASP_Identity.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string Nombre { get; set; }
    public string PrimerApellido { get; set; }
    public string SegundoApellido { get; set; }
    public string CURP { get; set; }
    public string CorreoPersonal { get; set; }
    public string TelefonoPersonal { get; set; }
    public IEnumerable<TipoInstitucion> TipoInstitucion { get; set; }
    public string NombreInstitucion { get; set; }
    public string CargoLaboral { get; set; }
    public IEnumerable<Politica> Politica { get; set; }
    public IEnumerable<NivelSeguimiento> NivelSeguimiento { get; set; }
    public IEnumerable<NivelResponsabilidad> NivelResponsabilidad { get; set; }
    public ICollection<IdentityUserRole<string>> TipoUsuario { get; set; }
}

