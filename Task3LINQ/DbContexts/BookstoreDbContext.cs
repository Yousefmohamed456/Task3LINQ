using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Task3LINQ.Models;
using Task3LINQ.ConfigurationClasses;


namespace Task3LINQ.DbContexts
{
    internal class BookstoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=BookstoreDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        // Define DbSet properties for your entities
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        // Add other DbSet properties for additional entities as needed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply configurations for the Book entity
            modelBuilder.ApplyConfiguration(new BookConfigurations());  
        }
    }
}
