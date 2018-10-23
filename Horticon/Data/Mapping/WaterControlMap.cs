using Core.Entities.WaterControls;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class WaterControlMap : IEntityTypeConfiguration<WaterControl>
    {
        public void Configure(EntityTypeBuilder<WaterControl> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.ToTable("WaterControl");

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
