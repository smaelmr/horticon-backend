using Core.Entities.WaterChanges;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class WaterChangeMap : IEntityTypeConfiguration<WaterChange>
    {
        public void Configure(EntityTypeBuilder<WaterChange> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.ToTable("WaterChange");

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
