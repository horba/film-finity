using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Models;

namespace Entities.DataAccess
{
    class NewsCategoryConfiguration : IEntityTypeConfiguration<NewsCategories>
    {
        public void Configure(EntityTypeBuilder<NewsCategories> modelBuilder)
        {
            modelBuilder
             .HasKey(nc => new { nc.CategoryId, nc.NewsId });

            modelBuilder
                .HasOne(nc => nc.Category)
                .WithMany(c => c.NewsCategories)
                .HasForeignKey(nc => nc.CategoryId);

            modelBuilder
                .HasOne(nc => nc.News)
                .WithMany(n => n.NewsCategories)
                .HasForeignKey(nc => nc.NewsId);
        }
    }
}
