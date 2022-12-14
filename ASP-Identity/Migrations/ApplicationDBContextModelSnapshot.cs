// <auto-generated />
using ASP_Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ASP_Identity.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ASP_Identity.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("id_ln_usuario")
                        .HasColumnOrder(1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer")
                        .HasColumnName("nu_num_acceso_fallido")
                        .HasColumnOrder(24);

                    b.Property<string>("CURP")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_curp")
                        .HasColumnOrder(7);

                    b.Property<string>("CargoLaboral")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_cargo_laboral")
                        .HasColumnOrder(16);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_concurrency_stamp")
                        .HasColumnOrder(21);

                    b.Property<string>("CorreoPersonal")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_correo_personal")
                        .HasColumnOrder(11);

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_correo_laboral")
                        .HasColumnOrder(8);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("ind_correo_confirmado")
                        .HasColumnOrder(10);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("ind_bloqueo_habilitado")
                        .HasColumnOrder(23);

                    b.Property<int>("NivelResponsabilidadId")
                        .HasColumnType("integer")
                        .HasColumnName("n_nivel_responsabilidad")
                        .HasColumnOrder(18);

                    b.Property<int>("NivelSeguimientoId")
                        .HasColumnType("integer")
                        .HasColumnName("n_nivel_seguimiento")
                        .HasColumnOrder(17);

                    b.Property<string>("Nombre")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_nombre_usuario")
                        .HasColumnOrder(4);

                    b.Property<string>("NombreInstitucion")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_nombre_institucion")
                        .HasColumnOrder(15);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_c_normalizado")
                        .HasColumnOrder(9);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_usuario_normalizado")
                        .HasColumnOrder(3);

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_hash_contrasenia")
                        .HasColumnOrder(19);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar")
                        .HasColumnName("ln_tel_laboral")
                        .HasColumnOrder(12);

                    b.Property<string>("PrimerApellido")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_primer_apellido")
                        .HasColumnOrder(5);

                    b.Property<string>("SecurityStamp")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_security_stamp")
                        .HasColumnOrder(20);

                    b.Property<string>("SegundoApellido")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_segundo_apellido")
                        .HasColumnOrder(6);

                    b.Property<string>("TelefonoPersonal")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_tel_personal")
                        .HasColumnOrder(13);

                    b.Property<int>("TipoInstitucionId")
                        .HasColumnType("integer")
                        .HasColumnName("n_tipo_institucion")
                        .HasColumnOrder(14);

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("ind_two_factor_enabled")
                        .HasColumnOrder(22);

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_usuario")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.HasIndex("NivelResponsabilidadId");

                    b.HasIndex("NivelSeguimientoId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("TipoInstitucionId");

                    b.ToTable("tb_usuario", (string)null);
                });

            modelBuilder.Entity("ASP_Identity.Models.NivelResponsabilidad", b =>
                {
                    b.Property<int>("NivelResponsabilidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_n_nivel_respon");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("NivelResponsabilidadId"));

                    b.Property<string>("Nombre")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("ln_nombre");

                    b.HasKey("NivelResponsabilidadId")
                        .HasName("id_n_nivel_respon");

                    b.ToTable("tb_cat_nivel_resp", (string)null);
                });

            modelBuilder.Entity("ASP_Identity.Models.NivelSeguimiento", b =>
                {
                    b.Property<int>("NivelSeguimientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_n_nivel_seguimiento");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("NivelSeguimientoId"));

                    b.Property<string>("Nivel")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_nivel");

                    b.HasKey("NivelSeguimientoId")
                        .HasName("id_n_nivel_seguimiento");

                    b.ToTable("tb_cat_nivel_seguimiento", (string)null);
                });

            modelBuilder.Entity("ASP_Identity.Models.Politica", b =>
                {
                    b.Property<int>("PoliticaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_n_politica");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PoliticaId"));

                    b.Property<string>("NombrePolitica")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_politica");

                    b.HasKey("PoliticaId")
                        .HasName("id_n_politica");

                    b.ToTable("tb_cat_politica", (string)null);
                });

            modelBuilder.Entity("ASP_Identity.Models.TipoInstitucion", b =>
                {
                    b.Property<int>("TipoInstitucionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_n_tipo_institucion");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TipoInstitucionId"));

                    b.Property<string>("NombreInstitucion")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_institucion");

                    b.HasKey("TipoInstitucionId")
                        .HasName("id_n_tipo_institucion");

                    b.ToTable("tb_cat_tipo_institucion", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("id_ln_nivel_respon");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(256)
                        .HasColumnType("varchar");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_nombre_nivel_resp");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_n_nivel_normalizado");

                    b.HasKey("Id")
                        .HasName("id_ln_nivel_respon");

                    b.HasIndex("Name")
                        .HasDatabaseName("idx01_rol");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("tb_rol", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_tipo_claim");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_valor_claim");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("id_ln_rol");

                    b.HasKey("Id")
                        .HasName("id_ln_rol");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("idx01_rol_claim");

                    b.ToTable("tb_r_rol_claim", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_tipo_claim");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_valor_claim");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("id_ln_usuario");

                    b.HasKey("Id")
                        .HasName("id_ln_usuario_claim");

                    b.HasIndex("UserId")
                        .HasDatabaseName("idx01_usuario_claim");

                    b.ToTable("tb_r_usuario_claim", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("id_ln_usuario_sesion");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_llave_proveedor");

                    b.Property<string>("ProviderDisplayName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("txt_nombre_proveedor");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("id_usuario");

                    b.HasKey("LoginProvider", "ProviderKey")
                        .HasName("id_ln_usuario_sesion");

                    b.HasIndex("UserId")
                        .HasDatabaseName("idx01_usuario_sesion");

                    b.ToTable("tb_r_usuario_sesion", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("id_ln_usuario");

                    b.Property<string>("RoleId")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("id_ln_rol");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("idx01_usuario_rol");

                    b.ToTable("tb_r_usuario_rol", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("id_usuario");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("id_ln_usuario_sesion");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar")
                        .HasColumnName("ln_nombre");

                    b.Property<string>("Value")
                        .HasMaxLength(500)
                        .HasColumnType("varchar")
                        .HasColumnName("txt_valor");

                    b.HasKey("UserId", "LoginProvider", "Name")
                        .HasName("id_ln_usuario_llave");

                    b.HasIndex("UserId")
                        .HasDatabaseName("idx01_usuario_llave");

                    b.ToTable("tb_r_usuario_llave", (string)null);
                });

            modelBuilder.Entity("ASP_Identity.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.HasOne("ASP_Identity.Models.NivelResponsabilidad", "NivelResponsabilidad")
                        .WithMany("Usuario")
                        .HasForeignKey("NivelResponsabilidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP_Identity.Models.NivelSeguimiento", "NivelSeguimiento")
                        .WithMany("Usuario")
                        .HasForeignKey("NivelSeguimientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP_Identity.Models.TipoInstitucion", "TipoInstitucion")
                        .WithMany("Usuario")
                        .HasForeignKey("TipoInstitucionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NivelResponsabilidad");

                    b.Navigation("NivelSeguimiento");

                    b.Navigation("TipoInstitucion");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ASP_Identity.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ASP_Identity.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP_Identity.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ASP_Identity.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP_Identity.Models.NivelResponsabilidad", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ASP_Identity.Models.NivelSeguimiento", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ASP_Identity.Models.TipoInstitucion", b =>
                {
                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
