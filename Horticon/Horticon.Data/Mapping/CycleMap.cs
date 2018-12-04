using Core.Entities.Cycles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class CycleMap : IEntityTypeConfiguration<Cycle>
    {
        public void Configure(EntityTypeBuilder<Cycle> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.ToTable("Cycle");

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
