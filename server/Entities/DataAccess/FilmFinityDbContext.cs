using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;
using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;
using Entities.Models;

namespace Entities.DataAccess
{
    public class FilmFinityDbContext : DbContext
    {
        public FilmFinityDbContext(DbContextOptions options) : base(options) { }

        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Celebrity> Celebrities { get; set; }
        public DbSet<CelebrityJobTitles> CelebrityJobTitles { get; set; }
        public DbSet<Serial> Serials { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<SerialGenreTitles> SerialGenreTitles { get; set; }
        public DbSet<SerialCelebrity> SerialCelebrities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SerialCelebrity>()
                .HasKey(cj => new { cj.SerialId, cj.CelebrityId });

            modelBuilder.Entity<SerialCelebrity>()
                .HasOne(cj => cj.Celebrity)
                .WithMany(j => j.SerialCelebrity)
                .HasForeignKey(cjt => cjt.CelebrityId);

            modelBuilder.Entity<SerialCelebrity>()
               .HasOne(cj => cj.Serial)
               .WithMany(j => j.SerialCelebrity)
               .HasForeignKey(cjt => cjt.SerialId);

            modelBuilder.Entity<SerialGenreTitles>()
                .HasKey(cj => new { cj.SerialId, cj.GenreId });

            modelBuilder.Entity<SerialGenreTitles>()
                .HasOne(cj => cj.GenreTitle)
                .WithMany(j => j.SerialGenreTitles)
                .HasForeignKey(cjt => cjt.GenreId);

            modelBuilder.Entity<SerialGenreTitles>()
               .HasOne(cj => cj.Serial)
               .WithMany(j => j.SerialGenreTitles)
               .HasForeignKey(cjt => cjt.SerialId);

            modelBuilder.Entity<CelebrityJobTitles>()
                .HasKey(cj => new { cj.CelebrityId, cj.JobTitleId });

            modelBuilder.Entity<CelebrityJobTitles>()
                .HasOne(cj => cj.JobTitle)
                .WithMany(j => j.CelebrityJobTitles)
                .HasForeignKey(cjt => cjt.JobTitleId);

            modelBuilder.Entity<CelebrityJobTitles>()
                .HasOne(cj => cj.Celebrity)
                .WithMany(j => j.CelebrityJobTitles)
                .HasForeignKey(cjt => cjt.CelebrityId);

            modelBuilder.Seed();
        }

    }
}
