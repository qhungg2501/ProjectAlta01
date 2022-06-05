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
    public class LearningOutcomesConfigurations : IEntityTypeConfiguration<LearningOutcome>
    {
        public void Configure(EntityTypeBuilder<LearningOutcome> builder)
        {
            builder.ToTable("LearnintOutcome");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Student).IsUnicode(false).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(true);
       
        }
    }
    
}
