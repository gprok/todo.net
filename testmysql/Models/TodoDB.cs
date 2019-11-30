using System;
using Microsoft.EntityFrameworkCore;

namespace testmysql.Models
{
    public class TodoDB : DbContext 
    {
        public TodoDB() { }
        public TodoDB(DbContextOptions options) : base(options) { }

        public DbSet<Task> taskEntity { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseMySQL("server=localhost;database=todo;user=test;password=test");
        
        }
    }
}
