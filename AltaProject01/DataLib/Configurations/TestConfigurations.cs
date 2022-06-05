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
    public class TestConfigurations : IEntityTypeConfiguration<TestCategory>
    {
        public void Configure(EntityTypeBuilder<TestCategory> builder)
        {
            builder.ToTable("TestCategory");
            builder.HasKey(x => x.testCateId);
            builder.Property(x => x.testCateName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(true);
            builder.HasMany(e => e.Tests)
                .WithOne(e => e.TestCategory1)
                .HasForeignKey(e => e.TestCategory);
        }
    }
    
}
