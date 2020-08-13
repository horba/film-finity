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
        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<NewsAuthor> Authors { get; set; }
        public DbSet<NewsCategory> Categories { get; set; }
        public DbSet<NewsCategories> NewsCategories { get; set; }
        public DbSet<Serial> Serials { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<SerialGenreTitles> SerialGenreTitles { get; set; }
        public DbSet<SerialCelebrity> SerialCelebrities { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorsList> ActorsLists { get; set; }
        public DbSet<VideoFile> VideoFiles { get; set; }
        public DbSet<MovieGenreTitles> MovieGenres { get; set; }
        public DbSet<FilmAgeRating> FilmAgeRatings { get; set; }

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

            modelBuilder.Entity<Review>()
                .HasOne(cj => cj.User)
                .WithMany(j => j.Reviews)
                .HasForeignKey(cjt => cjt.UserId);

            modelBuilder
             .ApplyConfiguration(new NewsConfiguration());

            modelBuilder
             .ApplyConfiguration(new NewsCategoryConfiguration());

            modelBuilder
              .ApplyConfiguration(new CategoriesConfiguration());

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

            modelBuilder.Entity<MovieGenreTitles>()
                .HasKey(cj => new { cj.MovieId, cj.GenreId });
            modelBuilder.Entity<MovieGenreTitles>()
                .HasOne(cj => cj.GenreTitle)
                .WithMany(j => j.MovieGenres)
                .HasForeignKey(cjt => cjt.GenreId);
            modelBuilder.Entity<MovieGenreTitles>()
                .HasOne(cj => cj.Movie)
                .WithMany(j => j.Genres)
                .HasForeignKey(cjt => cjt.MovieId);

            modelBuilder.Entity<Movie>()
                .HasOne(_ => _.VideoFile)
                .WithOne(_ => _.Movie)
                .HasForeignKey<VideoFile>(_ => _.MovieId);

            modelBuilder.Entity<FilmAgeRating>()
                .HasMany(m => m.Movie)
                .WithOne(a => a.FilmAgeRating)
                .HasForeignKey(p => p.FilmAgeRatingId);

            modelBuilder.Seed();
        }

    }
}
