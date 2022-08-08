using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using alibabaproy2022_v2.Models;

namespace alibabaproy2022_v2.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<alibabaproy2022_v2.Models.Contacto> DataContactos { get; set; }

    public DbSet<alibabaproy2022_v2.Models.Producto> DataProductos { get; set; }

    public DbSet<alibabaproy2022_v2.Models.Proforma> DataProforma { get; set; }
}