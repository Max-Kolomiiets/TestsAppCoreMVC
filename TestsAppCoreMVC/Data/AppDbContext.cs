using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestsAppCoreMVC.Models;

namespace TestsAppCoreMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            TestData.Init(6);
            modelBuilder.Entity<Test>().HasData(TestData.Tests);
            modelBuilder.Entity<Question>().HasData(TestData.Questions);
            modelBuilder.Entity<Answer>().HasData(TestData.Answers);
        }
    }
}
