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
    public class AdminAccountConfigurations : IEntityTypeConfiguration<AdminAccount>
    {
        public void Configure(EntityTypeBuilder<AdminAccount> builder)
        {
            builder.ToTable("AdminAccount");
            builder.HasKey(x => x.userName);         
            builder.Property(x => x.userName).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.passWord).HasMaxLength(255);
            builder.Property(x => x.Admin).HasMaxLength(10);
            builder.Property(x => x.Status).HasDefaultValue(true);

        }
    }
}
