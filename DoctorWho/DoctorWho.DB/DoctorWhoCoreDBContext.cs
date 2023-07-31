using DoctorWho.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.DB;
public class DoctorWhoCoreDBContext: DbContext
{
    public DbSet<Episode> Episodes { get; set; }
    public DbSet<Enemy> Enemies { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Companion> Companions { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<EpisodeCompanion> EpisodeCompanion { get; set; }
    public DbSet<EpisodeEnemy> EpisodeEnemy { get; set; }

    public DoctorWhoCoreDBContext(DbContextOptions<DoctorWhoCoreDBContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
          "Data Source=0.0.0.0:8089,1433;Initial Catalog=DoctorWho;User Id=sa;"
        );
    }
}
