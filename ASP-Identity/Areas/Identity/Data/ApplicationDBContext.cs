using ASP_Identity.Areas.Identity.Data;
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

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>(b =>
        {
            b.Property(u => u.Id).HasColumnType("varchar");
            b.Property(u => u.Nombre).HasColumnType("varchar");
            b.Property(u => u.Apellidos).HasColumnType("varchar");
            b.Ignore(u => u.LockoutEnd);
            b.Property(u => u.LockoutEnabled).HasColumnType("boolean");
            b.Property(u => u.Email).HasColumnType("varchar");
            b.Property(u => u.NormalizedEmail).HasColumnType("varchar");
            b.Property(u => u.EmailConfirmed).HasColumnType("boolean");
            b.Property(u => u.PasswordHash).HasColumnType("varchar");
            b.Property(u => u.SecurityStamp).HasColumnType("varchar");
            b.Property(u => u.ConcurrencyStamp).HasColumnType("varchar");
            b.Property(u => u.PhoneNumber).HasColumnType("varchar");
            b.Property(u => u.PhoneNumberConfirmed).HasColumnType("boolean");
            b.Property(u => u.UserName).HasColumnType("varchar");
            b.Property(u => u.NormalizedUserName).HasColumnType("varchar");
        });
            
    }
}

