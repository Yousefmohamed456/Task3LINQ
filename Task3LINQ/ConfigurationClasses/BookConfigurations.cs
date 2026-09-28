using System;
using System.Collections.Generic;
using System.Text;
using Task3LINQ.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Task3LINQ.ConfigurationClasses
{
    internal class BookConfigurations: IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> B)
        {
            // Title → Required, Max Length 150
            B.Property(b => b.Title)
                  .IsRequired()
                  .HasMaxLength(150);

            // Price → decimal(8,2)
            B.Property(b => b.Price)
                  .HasColumnType("decimal(8,2)");

            // PublishedDate → Explicitly Optional
            B.Property(b => b.PublishedDate)
                  .IsRequired(false);
        }
    }
}
