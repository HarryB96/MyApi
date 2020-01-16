using System;
using Microsoft.EntityFrameworkCore;
namespace MyApi.Models
{
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options)
        {
        }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Day> Days { get; set; }
    }
}