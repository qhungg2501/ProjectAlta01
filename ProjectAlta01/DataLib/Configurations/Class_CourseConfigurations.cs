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
    public class Class_CourseConfigurations : IEntityTypeConfiguration<Class_Course>
    {
        public void Configure(EntityTypeBuilder<Class_Course> builder)
        {
            builder.ToTable("Class_Course");
            builder.HasKey(x => x.classCourseId); 
            builder.Property(x => x.Class).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Status).HasDefaultValue(true);
            builder.Property(x=>x.lession).HasColumnType("date");
           
        }
    }
}
