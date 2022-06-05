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
    public class PositionConfigurations : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.ToTable("Position");
            builder.HasKey(x => x.positionId);
            builder.Property(x => x.positionName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(true);
            builder.HasMany(e => e.Admins)
                .WithOne(e => e.Position1)
                .HasForeignKey(e => e.Position);
        }
    }
 
}
