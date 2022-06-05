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
    public class AdminConfigurations : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admin");
            builder.HasKey(x => x.teacherId);           
            builder.Property(x => x.teacherId).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.firstName).HasMaxLength(10);
            builder.Property(x => x.lastName).HasMaxLength(50);
            builder.HasOne<AdminAccount>(x => x.AdminAccount)
            .WithOne(x => x.Admin1)
            .HasForeignKey<AdminAccount>(x => x.Admin)
            .OnDelete(DeleteBehavior.Cascade);
            builder.Property(x => x.Status).HasDefaultValue(true);

        }
    }
}
