using Core.Entities.WashingPipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
   
    public class WashingPipeMap : IEntityTypeConfiguration<WashingPipe>
    {
        public void Configure(EntityTypeBuilder<WashingPipe> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.ToTable("WashingPipe");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Sytem)
                .IsRequired()
                .HasColumnName("System");

            builder.Property(c => c.Lot)
                .IsRequired()
                .HasColumnName("Lot");


        }
    }
}
