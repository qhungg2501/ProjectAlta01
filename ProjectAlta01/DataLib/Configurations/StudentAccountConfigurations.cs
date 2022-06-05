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
    public class StudentAccountConfigurations : IEntityTypeConfiguration<StudentAccount>
    {
        public void Configure(EntityTypeBuilder<StudentAccount> builder)
        {
            builder.ToTable("StudentAccount");
            builder.HasKey(x => x.userName);
            builder.Property(x => x.userName).IsUnicode(false).HasMaxLength(50);
            builder.Property(x=>x.passWord).IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.Student).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Status).HasDefaultValue(true);
 
        }
    }
 
}
