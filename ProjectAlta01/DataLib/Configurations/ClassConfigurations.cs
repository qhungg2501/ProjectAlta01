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
    public class ClassConfigurations : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("Class");
            builder.HasKey(x => x.classId);

            builder.Property(x => x.classId).IsUnicode(false).HasMaxLength(5);

            builder.HasMany(x=>x.Class_Course)
            .WithOne(x => x.Class1)
            .HasForeignKey(x => x.Class);

            builder.HasMany(x => x.Class_Test)
            .WithOne(x => x.Class1)
            .HasForeignKey(x => x.Class);

           builder.HasMany(x => x.Students)
           .WithOne(x => x.Class1)
           .HasForeignKey(x => x.Class);
            builder.Property(x => x.Status).HasDefaultValue(true);
        }  
    }
}
