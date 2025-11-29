using Learning.Models;
using Microsoft.EntityFrameworkCore;

namespace Learning.data
{
    public class LearningDBContext : DbContext
    {
        public LearningDBContext(DbContextOptions<LearningDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Materials> Materials { get; set; }
        public DbSet<Homework> Homeworks    { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Progress> Progresses { get; set; } 
    }
}
