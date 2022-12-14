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

    [Column("n_tipo_institucion", Order =14)]
    public int TipoInstitucionId { get; set; }

    //[ForeignKey("_")]
    public virtual TipoInstitucion TipoInstitucion { get; set; }
    public string NombreInstitucion { get; set; }
    public string CargoLaboral { get; set; }

    //[Column("n_politica")]
    //public int PoliticaId { get; set; }
    //public virtual Politica Politica { get; set; }

    [Column("n_nivel_seguimiento", Order = 17)]
    public int NivelSeguimientoId { get; set; }

    //[ForeignKey("_")]
    public virtual NivelSeguimiento NivelSeguimiento { get; set; }

    [Column("n_nivel_responsabilidad", Order = 18)]
    public int NivelResponsabilidadId { get; set; }

    //[ForeignKey("_")]
    public virtual NivelResponsabilidad NivelResponsabilidad { get; set; }
}