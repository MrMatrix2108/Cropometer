using Microsoft.EntityFrameworkCore;

namespace CropsAppMVC.Models;

public partial class CropDatabaseContext : DbContext
{
    public CropDatabaseContext()
    {
    }

    public CropDatabaseContext(DbContextOptions<CropDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Crop> Crops { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=st10083511server.database.windows.net;Initial Catalog=CropDatabase;Persist Security Info=False;User ID=st10083511;Password=CropPassword123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Crop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Crops__3214EC0729AABA17");

            entity.Property(e => e.CropName).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
