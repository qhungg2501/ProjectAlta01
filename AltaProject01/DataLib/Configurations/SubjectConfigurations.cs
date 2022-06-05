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
    public class SubjectConfigurations : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("Subject");
            builder.HasKey(x => x.subjectId);
            builder.Property(x => x.subjectName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(true);
            builder.HasMany(e => e.Admins)
                .WithOne(e => e.Subject1)
                .HasForeignKey(e => e.Subject);
           builder.HasMany(e => e.Courses)
                .WithOne(e => e.Subject1)
                .HasForeignKey(e => e.Subject);
           builder.HasMany(e => e.Documents)
                .WithOne(e => e.Subject1)
                .HasForeignKey(e => e.Subject);
        }
    }
 
}
