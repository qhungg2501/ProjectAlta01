using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Configurations;
using DataLib.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLib.Dbcontext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdminAccount> AdminAccounts { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Class_Course> Class_Course { get; set; }
        public DbSet<Class_Test> Class_Test { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<LearningOutcome> LearningOutcomes { get; set; }
        public DbSet<Position> Positions { get; set; }
      
        public DbSet<Student> Students { get; set; }
        public DbSet<Student_Test> Student_Test { get; set; }
        public DbSet<StudentAccount> StudentAccounts { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestCategory> TestCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfigurations());
            modelBuilder.ApplyConfiguration(new AdminAccountConfigurations());
            modelBuilder.ApplyConfiguration(new ClassConfigurations());
            modelBuilder.ApplyConfiguration(new Class_CourseConfigurations());
            modelBuilder.ApplyConfiguration(new Class_TestConfigurations());
            modelBuilder.ApplyConfiguration(new CourseConfigurations());
            modelBuilder.ApplyConfiguration(new DocumentConfigurations());
            modelBuilder.ApplyConfiguration(new GradeConfigurations());
            modelBuilder.ApplyConfiguration(new LearningOutcomesConfigurations());
            modelBuilder.ApplyConfiguration(new PositionConfigurations());
            modelBuilder.ApplyConfiguration(new StudentConfigurations());
            modelBuilder.ApplyConfiguration(new Student_TestConfigurations());
            modelBuilder.ApplyConfiguration(new StudentAccountConfigurations());
            modelBuilder.ApplyConfiguration(new SubjectConfigurations());
            modelBuilder.ApplyConfiguration(new TestConfigurations());
            modelBuilder.ApplyConfiguration(new TestCategoryConfigurations());




        }
    }
}
