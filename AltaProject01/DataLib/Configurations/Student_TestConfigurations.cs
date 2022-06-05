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
    public class Student_TestConfigurations : IEntityTypeConfiguration<Student_Test>
    {
        public void Configure(EntityTypeBuilder<Student_Test> builder)
        {
            builder.ToTable("Student_Test");
            builder.HasKey(x => x.studentTestId);
            builder.Property(x => x.documentTest).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(true);
            builder.HasMany(e => e.LearningOutcomes)
                .WithOne(e => e.Student_Test1)
                .HasForeignKey(e => e.Student_Test);
            builder.Property(x=>x.Student).IsUnicode(false).HasMaxLength(10);
        }
    }
  
}
