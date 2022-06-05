using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLib.Configurations
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.HasKey(x => x.studentId);
            builder.Property(x => x.studentId).HasMaxLength(10).IsUnicode(false).IsRequired();
            builder.Property(x => x.firstName).HasMaxLength(10).IsRequired();
            builder.Property(x => x.lastName).IsRequired().HasMaxLength(50);
            builder.Property<string>(x => x.Class).HasMaxLength(5).IsUnicode(false);    
            builder.Property(x => x.Status).HasDefaultValue(true);
            builder.HasMany(e => e.LearningOutcomes)
                .WithOne(e => e.Student1)
                .HasForeignKey(e => e.Student);
            builder.HasOne(x => x.StudentAccount)
                .WithOne(x => x.Student1)
                .HasForeignKey<StudentAccount>(x => x.Student)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(e => e.Student_Test)
              .WithOne(e => e.Student1)
              .HasForeignKey(e => e.Student);
        }
    }
}
