﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20181018042558_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Plantations.Planting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Brand")
                        .HasColumnName("SeedBrand");

                    b.Property<int>("Lot")
                        .HasColumnName("Lot");

                    b.Property<int>("Quantity")
                        .HasColumnName("SeedBrand");

                    b.Property<int>("Sytem")
                        .HasColumnName("System");

                    b.Property<int>("Type")
                        .HasColumnName("SeedType");

                    b.Property<int>("Variety")
                        .HasColumnName("SeedName");

                    b.HasKey("Id");

                    b.ToTable("Planting");
                });

            modelBuilder.Entity("Core.Entities.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Lot");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name");

                    b.Property<int>("Sytem");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
