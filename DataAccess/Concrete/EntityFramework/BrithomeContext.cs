﻿using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;



namespace DataAccess.Concrete.EntityFramework
{
    public class BrithomeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Brithome;User Id=sa;Password=123456;TrustServerCertificate=True");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Listing> Listings { get; set; }
       // public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}
