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
    public class GradeConfigurations : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable("Grade");
            builder.HasKey(x => x.gradeId);
            builder.Property(x => x.gradeName).IsUnicode(false).HasMaxLength(3).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(true);
            builder.HasMany(e => e.Classes)
                .WithOne(e => e.Grade1)
                .HasForeignKey(e => e.Grade);
        }
    }
}
