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
    internal class Class_TestConfigurations : IEntityTypeConfiguration<Class_Test>
    {
        public void Configure(EntityTypeBuilder<Class_Test> builder)
        {
            builder.ToTable("Class_Test");
            builder.HasKey(x => x.classTestId);
            builder.Property(x => x.Class).IsUnicode(false).HasMaxLength(5);
            builder.HasMany(x => x.Student_Test)
            .WithOne(x => x.Class_Test1)
            .HasForeignKey(x => x.Class_Test);
            builder.Property(x => x.Status).HasDefaultValue(true);
            builder.Property(x=>x.isComplete).HasDefaultValue(1);
        }
    }
}
