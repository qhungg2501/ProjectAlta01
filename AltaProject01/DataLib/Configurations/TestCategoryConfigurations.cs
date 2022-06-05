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
    public class TestCategoryConfigurations : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.ToTable("Test");
            builder.HasKey(x => x.testId);
            builder.Property(x => x.Status).HasDefaultValue(true);
            builder.Property(x => x.title).HasMaxLength(100).IsRequired();
            builder.HasMany(e => e.Class_Test)
                .WithOne(e => e.Test1)
                .HasForeignKey(e => e.Test);
        }
    }

}
