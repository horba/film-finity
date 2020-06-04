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
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorsList> ActorsLists { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<ActorsList>()
                .HasKey(cj => new { cj.MovieId, cj.ActorId });

            modelBuilder.Entity<ActorsList>()
                .HasOne(cj => cj.Actor)
                .WithMany(j => j.ActorsList)
                .HasForeignKey(cjt => cjt.ActorId);

            modelBuilder.Entity<ActorsList>()
                .HasOne(cj => cj.Movie)
                .WithMany(j => j.ActorsList)
                .HasForeignKey(cjt => cjt.MovieId);

            modelBuilder.Seed();
        }

    }
}
