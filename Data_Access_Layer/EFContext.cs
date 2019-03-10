using System;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Entities;

namespace Data_Access_Layer
{
    public class EFContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DatabaseForWebAPI;Trusted_Connection=True;");
        }
    }
}
