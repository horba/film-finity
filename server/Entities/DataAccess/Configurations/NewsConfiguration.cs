using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Models;


namespace Entities.DataAccess
{
    class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> modelBuilder)
        {
            modelBuilder
               .HasOne(n => n.Author)
               .WithMany(a => a.News)
               .IsRequired(true);
            modelBuilder.Property(n => n.Content)
                .HasMaxLength(2000)
                .IsRequired(true);
            modelBuilder.Property(n => n.PreviewImage)
                .IsRequired(true);
            modelBuilder.Property(n => n.PublishTime)
                .IsRequired(true);
            modelBuilder.Property(n => n.Title)
                .HasMaxLength(100)
                .IsRequired(true);
 
        }
    }
}
