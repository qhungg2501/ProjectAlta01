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
    public class DocumentConfigurations : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable("Document");
            builder.HasKey(x => x.docId);
            builder.Property(x => x.docPath).HasMaxLength(255).IsRequired();
   
            builder.Property(x => x.Status).HasDefaultValue(true);
        }
    }
}
