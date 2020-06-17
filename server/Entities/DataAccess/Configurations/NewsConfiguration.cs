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
               .WithMany(a => a.News);
        }
    }
}
