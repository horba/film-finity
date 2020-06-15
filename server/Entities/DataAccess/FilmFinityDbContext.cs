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
        public DbSet<News> News { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<NewsCategory> NewsCategories { get; set; }

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


            modelBuilder.Entity<News>()
                .HasOne(n => n.Author)
                .WithMany(a => a.News);

            modelBuilder.Entity<NewsCategory>()
                .HasKey(nc => new { nc.CategoryId, nc.NewsId });

            modelBuilder.Entity<NewsCategory>()
                .HasOne(nc => nc.Category)
                .WithMany(c => c.NewsCategories)
                .HasForeignKey(nc => nc.CategoryId);

            modelBuilder.Entity<NewsCategory>()
                .HasOne(nc => nc.News)
                .WithMany(n => n.NewsCategories)
                .HasForeignKey(nc => nc.NewsId);

            modelBuilder.Seed();
        }

    }
}
