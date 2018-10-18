using Core.Entities.Plantations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class PlantingMap : IEntityTypeConfiguration<Planting>
    {
        public void Configure(EntityTypeBuilder<Planting> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.ToTable("Planting");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Sytem)
                .IsRequired()
                .HasColumnName("System");

            builder.Property(c => c.Lot)
                .IsRequired()
                .HasColumnName("Lot");

            builder.Property(c => c.Variety)
                .IsRequired()
                .HasColumnName("SeedName");

            builder.Property(c => c.Type)
                .IsRequired()
                .HasColumnName("SeedType");

            builder.Property(c => c.Brand)
                .IsRequired()
                .HasColumnName("SeedBrand");

            builder.Property(c => c.Quantity)
                .IsRequired()
                .HasColumnName("SeedBrand");
        }
    }
}
