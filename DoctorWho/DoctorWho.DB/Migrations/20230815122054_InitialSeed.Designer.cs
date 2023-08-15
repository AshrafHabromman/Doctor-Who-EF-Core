﻿// <auto-generated />
using System;
using DoctorWho;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.DB.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDBContext))]
    [Migration("20230815122054_InitialSeed")]
    partial class InitialSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CompanionEpisode", b =>
                {
                    b.Property<int>("CompanionsId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodesId")
                        .HasColumnType("int");

                    b.HasKey("CompanionsId", "EpisodesId");

                    b.HasIndex("EpisodesId");

                    b.ToTable("CompanionEpisode");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Author 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Author 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Author 3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Author 4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Author 5"
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Models.Companion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPlayed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Companion 1",
                            WhoPlayed = "Actor A"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Companion 2",
                            WhoPlayed = "Actor B"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Companion 3",
                            WhoPlayed = "Actor C"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Companion 4",
                            WhoPlayed = "Actor D"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Companion 5",
                            WhoPlayed = "Actor E"
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstEpisodeDate = new DateTime(2005, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2005, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Doctor 9",
                            Number = 9
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstEpisodeDate = new DateTime(2006, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Doctor 10",
                            Number = 10
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstEpisodeDate = new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2017, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Doctor 11",
                            Number = 11
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstEpisodeDate = new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Doctor 12",
                            Number = 12
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstEpisodeDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Doctor 13",
                            Number = 13
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Models.Enemy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Enemies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description for Enemy 1",
                            Name = "Enemy 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description for Enemy 2",
                            Name = "Enemy 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description for Enemy 3",
                            Name = "Enemy 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Description for Enemy 4",
                            Name = "Enemy 4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Description for Enemy 5",
                            Name = "Enemy 5"
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Models.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeType")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = 0,
                            Notes = "Notes for Episode 1",
                            SeriesNumber = 1,
                            Title = "Episode 1"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = 0,
                            Notes = "Notes for Episode 2",
                            SeriesNumber = 1,
                            Title = "Episode 2"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = 0,
                            Notes = "Notes for Episode 1",
                            SeriesNumber = 2,
                            Title = "Episode 1"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = 0,
                            Notes = "Notes for Episode 2",
                            SeriesNumber = 2,
                            Title = "Episode 2"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 5,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = 0,
                            Notes = "Notes for Episode 1",
                            SeriesNumber = 3,
                            Title = "Episode 1"
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Models.EpisodeCompanion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeCompanion");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanionId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            Id = 2,
                            CompanionId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            Id = 3,
                            CompanionId = 3,
                            EpisodeId = 3
                        },
                        new
                        {
                            Id = 4,
                            CompanionId = 4,
                            EpisodeId = 4
                        },
                        new
                        {
                            Id = 5,
                            CompanionId = 5,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Models.EpisodeEnemy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeEnemy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EnemyId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            Id = 2,
                            EnemyId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            Id = 3,
                            EnemyId = 3,
                            EpisodeId = 3
                        },
                        new
                        {
                            Id = 4,
                            EnemyId = 4,
                            EpisodeId = 4
                        },
                        new
                        {
                            Id = 5,
                            EnemyId = 5,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("EnemyEpisode", b =>
                {
                    b.Property<int>("EnemiesId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodesId")
                        .HasColumnType("int");

                    b.HasKey("EnemiesId", "EpisodesId");

                    b.HasIndex("EpisodesId");

                    b.ToTable("EnemyEpisode");
                });

            modelBuilder.Entity("CompanionEpisode", b =>
                {
                    b.HasOne("DoctorWho.DB.Models.Companion", null)
                        .WithMany()
                        .HasForeignKey("CompanionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.DB.Models.Episode", null)
                        .WithMany()
                        .HasForeignKey("EpisodesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorWho.DB.Models.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.DB.Models.Companion", "Companion")
                        .WithMany()
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.DB.Models.Episode", "Episode")
                        .WithMany()
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.DB.Models.Enemy", "Enemy")
                        .WithMany()
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.DB.Models.Episode", "Episode")
                        .WithMany()
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("EnemyEpisode", b =>
                {
                    b.HasOne("DoctorWho.DB.Models.Enemy", null)
                        .WithMany()
                        .HasForeignKey("EnemiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.DB.Models.Episode", null)
                        .WithMany()
                        .HasForeignKey("EpisodesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}