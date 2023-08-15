using DoctorWho.DB.Enums;
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


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed Authors
        modelBuilder.Entity<Author>().HasData(
            new Author { Id = 1, Name = "Author 1" },
            new Author { Id = 2, Name = "Author 2" },
            new Author { Id = 3, Name = "Author 3" },
            new Author { Id = 4, Name = "Author 4" },
            new Author { Id = 5, Name = "Author 5" }
        );

        // Seed Companions
        modelBuilder.Entity<Companion>().HasData(
            new Companion { Id = 1, Name = "Companion 1", WhoPlayed = "Actor A" },
            new Companion { Id = 2, Name = "Companion 2", WhoPlayed = "Actor B" },
            new Companion { Id = 3, Name = "Companion 3", WhoPlayed = "Actor C" },
            new Companion { Id = 4, Name = "Companion 4", WhoPlayed = "Actor D" },
            new Companion { Id = 5, Name = "Companion 5", WhoPlayed = "Actor E" }
        );

        // Seed Doctors
        modelBuilder.Entity<Doctor>().HasData(
            new Doctor { Id = 1, Number = 9, Name = "Doctor 9", BirthDate = new DateTime(2000, 1, 1), FirstEpisodeDate = new DateTime(2005, 3, 26), LastEpisodeDate = new DateTime(2005, 12, 31) },
            new Doctor { Id = 2, Number = 10, Name = "Doctor 10", BirthDate = new DateTime(2000, 1, 1), FirstEpisodeDate = new DateTime(2006, 4, 1), LastEpisodeDate = new DateTime(2010, 12, 31) },
            new Doctor { Id = 3, Number = 11, Name = "Doctor 11", BirthDate = new DateTime(2000, 1, 1), FirstEpisodeDate = new DateTime(2011, 1, 1), LastEpisodeDate = new DateTime(2017, 12, 31) },
            new Doctor { Id = 4, Number = 12, Name = "Doctor 12", BirthDate = new DateTime(2000, 1, 1), FirstEpisodeDate = new DateTime(2018, 1, 1), LastEpisodeDate = new DateTime(2022, 12, 31) },
            new Doctor { Id = 5, Number = 13, Name = "Doctor 13", BirthDate = new DateTime(2000, 1, 1), FirstEpisodeDate = new DateTime(2023, 1, 1), LastEpisodeDate = new DateTime(2023, 12, 31) }
        );

        // Seed Enemies
        modelBuilder.Entity<Enemy>().HasData(
            new Enemy { Id = 1, Name = "Enemy 1", Description = "Description for Enemy 1" },
            new Enemy { Id = 2, Name = "Enemy 2", Description = "Description for Enemy 2" },
            new Enemy { Id = 3, Name = "Enemy 3", Description = "Description for Enemy 3" },
            new Enemy { Id = 4, Name = "Enemy 4", Description = "Description for Enemy 4" },
            new Enemy { Id = 5, Name = "Enemy 5", Description = "Description for Enemy 5" }
        );

        // Seed Episodes
        modelBuilder.Entity<Episode>().HasData(
            new Episode { Id = 1, SeriesNumber = 1, EpisodeNumber = 1, EpisodeType = EpisodeType.Regular, Title = "Episode 1", EpisodeDate = new DateTime(2020, 1, 1), AuthorId = 1, DoctorId = 1, Notes = "Notes for Episode 1" },
            new Episode { Id = 2, SeriesNumber = 1, EpisodeNumber = 2, EpisodeType = EpisodeType.Regular, Title = "Episode 2", EpisodeDate = new DateTime(2020, 1, 8), AuthorId = 2, DoctorId = 1, Notes = "Notes for Episode 2" },
            new Episode { Id = 3, SeriesNumber = 2, EpisodeNumber = 1, EpisodeType = EpisodeType.Regular, Title = "Episode 1", EpisodeDate = new DateTime(2021, 1, 1), AuthorId = 3, DoctorId = 2, Notes = "Notes for Episode 1" },
            new Episode { Id = 4, SeriesNumber = 2, EpisodeNumber = 2, EpisodeType = EpisodeType.Regular, Title = "Episode 2", EpisodeDate = new DateTime(2021, 1, 8), AuthorId = 4, DoctorId = 2, Notes = "Notes for Episode 2" },
            new Episode { Id = 5, SeriesNumber = 3, EpisodeNumber = 1, EpisodeType = EpisodeType.Regular, Title = "Episode 1", EpisodeDate = new DateTime(2022, 1, 1), AuthorId = 5, DoctorId = 3, Notes = "Notes for Episode 1" }
        );

        // Seed EpisodeCompanions
        modelBuilder.Entity<EpisodeCompanion>().HasData(
            new EpisodeCompanion { Id = 1, EpisodeId = 1, CompanionId = 1 },
            new EpisodeCompanion { Id = 2, EpisodeId = 2, CompanionId = 2 },
            new EpisodeCompanion { Id = 3, EpisodeId = 3, CompanionId = 3 },
            new EpisodeCompanion { Id = 4, EpisodeId = 4, CompanionId = 4 },
            new EpisodeCompanion { Id = 5, EpisodeId = 5, CompanionId = 5 }
        );

        // Seed EpisodeEnemies
        modelBuilder.Entity<EpisodeEnemy>().HasData(
            new EpisodeEnemy { Id = 1, EpisodeId = 1, EnemyId = 1 },
            new EpisodeEnemy { Id = 2, EpisodeId = 2, EnemyId = 2 },
            new EpisodeEnemy { Id = 3, EpisodeId = 3, EnemyId = 3 },
            new EpisodeEnemy { Id = 4, EpisodeId = 4, EnemyId = 4 },
            new EpisodeEnemy { Id = 5, EpisodeId = 5, EnemyId = 5 }
        );
    }

}
