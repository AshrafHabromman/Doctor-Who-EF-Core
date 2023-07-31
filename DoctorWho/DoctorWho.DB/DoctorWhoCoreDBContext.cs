using DoctorWho.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho;
public class DoctorWhoCoreDBContext: DbContext
{
    public DbSet<Episode> Episodes { get; set; }
    public DbSet<Enemy> Enemies { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Companion> Companions { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<EpisodeCompanion> EpisodeCompanion { get; set; }
    public DbSet<EpisodeEnemy> EpisodeEnemy { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
          "Data Source=localhost,1433;Database=Doctor;User ID=sa;password=Aa$123123;"
        );
    }
}
