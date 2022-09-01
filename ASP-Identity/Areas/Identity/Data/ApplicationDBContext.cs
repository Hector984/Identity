using ASP_Identity.Areas.Identity.Data;
using ASP_Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASP_Identity.Data;

public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }

    DbSet<NivelResponsabilidad> NivelResponsabilidad { get; set; }
    DbSet<NivelSeguimiento> NivelSeguimiento { get; set; }
    DbSet<TipoInstitucion> TipoInstitucion { get; set; }
    DbSet<Politica> Politica { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Identity Tables
        builder.Entity<ApplicationUser>(b =>
        {
            b.ToTable("tb_usuario");

            b.Property(u => u.Id).HasColumnType("varchar")
                                 .HasMaxLength(256)
                                 .HasColumnName("id_usuario");

            b.Property(u => u.UserName).HasColumnType("varchar")
                                       .HasMaxLength(256)
                                       .HasColumnName("ln_usuario");

            b.Property(u => u.NormalizedUserName).HasColumnType("varchar")
                                                 .HasMaxLength(256)
                                                 .HasColumnName("ln_usuario_normalizado");

            b.Property(u => u.Email).HasColumnType("varchar")
                                    .HasMaxLength(256).HasColumnName("ln_correo_laboral");

            b.Property(u => u.NormalizedEmail).HasColumnType("varchar")
                                              .HasMaxLength(256).HasColumnName("ln_c_normalizado");

            b.Property(u => u.EmailConfirmed).HasColumnType("boolean")
                                             .HasColumnName("ind_correo_confirmado");

            b.Property(u => u.PasswordHash).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_hash_contrasenia");

            b.Property(u => u.SecurityStamp).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_security_stamp");

            b.Property(u => u.ConcurrencyStamp).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_concurrency_stamp");

            b.Property(u => u.PhoneNumber).HasColumnType("varchar").HasColumnName("ln_tel_laboral");

            b.Property(u => u.PhoneNumberConfirmed).HasColumnType("boolean").HasColumnName("ind_tel_laboral_conf");

            b.Property(u => u.TwoFactorEnabled).HasColumnType("boolean").HasColumnName("ind_two_factor_enabled");

            b.Ignore(u => u.LockoutEnd);

            b.Property(u => u.LockoutEnabled).HasColumnType("boolean").HasColumnName("ind_bloqueo_habilitado");

            b.Property(u => u.AccessFailedCount).HasColumnName("nu_num_acceso_fallido");

            b.Property(u => u.Nombre).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_nombre_usuario");

            b.Property(u => u.PrimerApellido).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_primer_apellido");

            b.Property(u => u.SegundoApellido).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_segundo_apellido");

            b.Property(u => u.CURP).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_curp");

            b.Property(u => u.CorreoPersonal).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_correo_personal");

            b.Property(u => u.TelefonoPersonal).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_tel_personal");

            b.Property(u => u.TipoInstitucion).HasColumnName("n_tipo_institucion");

            b.Property(u => u.NombreInstitucion).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_nombre_institucion");

            b.Property(u => u.CargoLaboral).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_cargo_laboral");

            b.Property(u => u.Politica).HasColumnName("n_politica");

            b.Property(u => u.NivelSeguimiento).HasColumnName("n_nivel_seguimiento");

            b.Property(u => u.NivelResponsabilidad).HasColumnName("n_nivel_responsabilidad");

        });

        builder.Entity<IdentityRole>(b =>
        {
            b.ToTable("tb_rol");
            b.Property(r => r.Id).HasColumnType("varchar").HasMaxLength(256).HasColumnName("id_nivel_responsabilidad");
            b.Property(r => r.Name).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_nombre_nivel_resp");
            b.Property(r => r.NormalizedName).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_n_nivel_normalizado");
            b.Property(r => r.ConcurrencyStamp).HasColumnType("varchar").HasMaxLength(256);

        });

        builder.Entity<IdentityRoleClaim<string>>(b =>
        {
            b.ToTable("tb_rol_claim");
            b.Property(rc => rc.RoleId).HasColumnType("varchar").HasMaxLength(256).HasColumnName("id_rol");
            b.Property(rc => rc.ClaimType).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_tipo_claim");
            b.Property(rc => rc.ClaimValue).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_valor_claim");
        });

        builder.Entity<IdentityUserClaim<string>>(b =>
        {
            b.ToTable("tb_usuario_claim");
            b.Property(uc => uc.UserId).HasColumnType("varchar").HasMaxLength(256).HasColumnName("id_usuario");
            b.Property(uc => uc.ClaimValue).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_valor_claim");
            b.Property(uc => uc.ClaimType).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_tipo_claim");
        });

        builder.Entity<IdentityUserLogin<string>>(b =>
        {
            b.ToTable("tb_usuario_sesion");
            b.Property(ul => ul.LoginProvider).HasColumnType("varchar").HasMaxLength(256).HasColumnName("id_usuario_sesion");
            b.Property(ul => ul.ProviderKey).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_llave_proveedor");
            b.Property(ul => ul.ProviderDisplayName).HasColumnType("varchar").HasMaxLength(256).HasColumnName("txt_nombre_proveedor");
            b.Property(ul => ul.UserId).HasColumnType("varchar").HasMaxLength(256).HasColumnName("id_usuario");
        });

        builder.Entity<IdentityUserRole<string>>(b =>
        {
            b.ToTable("tb_usuario_rol");
            b.Property(ur => ur.UserId).HasColumnType("varchar").HasMaxLength(256).HasColumnName("id_usuario");
            b.Property(ur => ur.RoleId).HasColumnType("varchar").HasMaxLength(256).HasColumnName("id_rol");
        });

        builder.Entity<IdentityUserToken<string>>(b =>
        {
            b.ToTable("tb_usuario_llave");
            b.HasKey(ut => new { ut.UserId, ut.LoginProvider, ut.Name });
            b.Property(ut => ut.LoginProvider).HasColumnType("varchar").HasMaxLength(256).HasColumnName("id_usuario_sesion");
            b.Property(ut => ut.Name).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_nombre");
            b.Property(ut => ut.Value).HasColumnType("varchar").HasMaxLength(500).HasColumnName("txt_valor");
            b.Property(ut => ut.UserId).HasColumnType("varchar").HasMaxLength(256).HasColumnName("id_usuario");
        });
        #endregion Identity tables

        #region Tablas catalogos
        builder.Entity<TipoInstitucion>(b =>
        {
            b.ToTable("tb_cat_tipo_institucion");

            b.HasKey(ti => ti.TipoInstitucionId);

            b.Property(ti => ti.TipoInstitucionId).HasColumnName("id_tipo_institucion").UseIdentityByDefaultColumn();

            b.HasIndex(ti => ti.NombreInstitucion).HasDatabaseName("ln_institucion_ind").IsUnique();

            b.Property(ti => ti.NombreInstitucion).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_institucion");
        });

        builder.Entity<NivelSeguimiento>(b =>
        {
            b.ToTable("tb_cat_nivel_seguimiento");

            b.HasKey(ns => ns.NivelSeguimientoId);

            b.Property(ns => ns.NivelSeguimientoId).HasColumnName("id_nivel_seguimiento").UseIdentityByDefaultColumn();

            b.HasIndex(ns => ns.Nivel).HasDatabaseName("ln_nivel_indice").IsUnique();

            b.Property(ns => ns.Nivel).HasColumnType("varchar").HasMaxLength(256).HasColumnName("ln_nivel");
        });

        builder.Entity<Politica>(b =>
        {
            b.ToTable("tb_cat_politica");

            b.HasKey(pa => pa.PoliticaId);

            b.Property(pa => pa.PoliticaId).HasColumnName("id_politica").UseIdentityByDefaultColumn();

            b.HasIndex(pa => pa.NombrePolitica)
             .HasDatabaseName("ln_politica_ind").IsUnique();

            b.Property(pa => pa.NombrePolitica)
             .HasColumnType("varchar")
             .HasMaxLength(256).HasColumnName("ln_politica");
        });
        #endregion Tablas catalogos
    }
}

