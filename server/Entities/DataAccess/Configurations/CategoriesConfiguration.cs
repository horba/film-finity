using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace Entities.DataAccess
{
    class CategoriesConfiguration : IEntityTypeConfiguration<NewsCategory>
    {
        public void Configure(EntityTypeBuilder<NewsCategory> modelBuilder)
        {
            modelBuilder.Property(c => c.Name)
                .HasMaxLength(20)
                .IsRequired(true);
        }
    }
}
