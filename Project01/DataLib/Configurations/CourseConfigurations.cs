using DataLib.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Configurations
{
    public  class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");
            builder.HasKey(x => x.courseId);
            builder.Property(x => x.linkOnline).IsUnicode(false).HasMaxLength(255).IsRequired();
            builder.HasMany(x => x.Class_Course)
                .WithOne(x => x.Course1)
                .HasForeignKey(x => x.Course);
         
            builder.Property(x => x.startDate).HasColumnType("date").IsRequired();
            builder.Property(x => x.endDate).HasColumnType("date").IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(true);
        }
    }
}
