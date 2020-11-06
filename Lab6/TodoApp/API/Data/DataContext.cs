using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace API.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Todo> Products {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(new Todo { Id = 1, Description = "tema ml", IsDone = true });
            modelBuilder.Entity<Todo>().HasData(new Todo { Id = 2, Description = "tema si", IsDone = false });
            modelBuilder.Entity<Todo>().HasData(new Todo { Id = 3, Description = "tema ai", IsDone = false });
            //modelBuilder.Entity<Todo>().HasData(ProductFactory.Create(2, "apa", 3.00, DateTime.Now, new DateTime(2020, 10, 12)));
            //modelBuilder.Entity<Todo>().HasData(ProductFactory.Create(3, "biscuiti", 5.00, DateTime.Now, new DateTime(2020, 10, 10)));

        }
    }
}