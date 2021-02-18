using Microsoft.EntityFrameworkCore;
using Modelslibrary;
using System;
using System.Collections.Generic;
using System.Text;



namespace serviceslibrary.data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }



        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Cartegory> Cartegories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tasks>().HasData(

                new Tasks
                {
                    Id = 1,
                    Title = "Code",
                    Description = "open visual studio",
                    DueDate = DateTime.Now,
                    StatusId = 1,
                    CartegoryId = 1
                }
                );

            modelBuilder.Entity<Cartegory>().HasData(
                new Cartegory
                {
                    Id = 1,
                    Name = "Pending",
                },
                  new Cartegory
                  {
                      Id = 2,
                      Name = "Normal",
                  }

                );

            modelBuilder.Entity<Status>().HasData(
                new Status
                {
                    Id = 1,
                    Name = "Completed",
                }
                );

        }






    }
}
