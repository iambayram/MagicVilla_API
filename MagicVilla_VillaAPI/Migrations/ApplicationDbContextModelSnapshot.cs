﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqrmt")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 5, 7, 13, 3, 4, 123, DateTimeKind.Local).AddTicks(168),
                            Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vitae neque ex. Cras blandit sed urna vitae tempor. Sed vitae odio id lectus aliquam eleifend. Mauris tincidunt nisi a nunc tincidunt pulvinar. Suspendisse potenti. Pellentesque lobortis scelerisque pellentesque. Suspendisse non tellus sit amet arcu volutpat sollicitudin. Etiam blandit, lorem sed vehicula convallis, ipsum arcu blandit quam, at semper mauris lacus malesuada erat.",
                            ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg",
                            Name = "Royal Villa",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqrmt = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 5, 7, 13, 3, 4, 123, DateTimeKind.Local).AddTicks(199),
                            Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vitae neque ex. Cras blandit sed urna vitae tempor. Sed vitae odio id lectus aliquam eleifend. Mauris tincidunt nisi a nunc tincidunt pulvinar. Suspendisse potenti. Pellentesque lobortis scelerisque pellentesque. Suspendisse non tellus sit amet arcu volutpat sollicitudin. Etiam blandit, lorem sed vehicula convallis, ipsum arcu blandit quam, at semper mauris lacus malesuada erat.",
                            ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg",
                            Name = "Premium Pool Villa",
                            Occupancy = 4,
                            Rate = 300.0,
                            Sqrmt = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 5, 7, 13, 3, 4, 123, DateTimeKind.Local).AddTicks(201),
                            Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vitae neque ex. Cras blandit sed urna vitae tempor. Sed vitae odio id lectus aliquam eleifend. Mauris tincidunt nisi a nunc tincidunt pulvinar. Suspendisse potenti. Pellentesque lobortis scelerisque pellentesque. Suspendisse non tellus sit amet arcu volutpat sollicitudin. Etiam blandit, lorem sed vehicula convallis, ipsum arcu blandit quam, at semper mauris lacus malesuada erat.",
                            ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg",
                            Name = "Luxury Pool Villa",
                            Occupancy = 4,
                            Rate = 400.0,
                            Sqrmt = 750,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 5, 7, 13, 3, 4, 123, DateTimeKind.Local).AddTicks(205),
                            Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vitae neque ex. Cras blandit sed urna vitae tempor. Sed vitae odio id lectus aliquam eleifend. Mauris tincidunt nisi a nunc tincidunt pulvinar. Suspendisse potenti. Pellentesque lobortis scelerisque pellentesque. Suspendisse non tellus sit amet arcu volutpat sollicitudin. Etiam blandit, lorem sed vehicula convallis, ipsum arcu blandit quam, at semper mauris lacus malesuada erat.",
                            ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg",
                            Name = "Royal Villa",
                            Occupancy = 4,
                            Rate = 550.0,
                            Sqrmt = 900,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 5, 7, 13, 3, 4, 123, DateTimeKind.Local).AddTicks(293),
                            Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vitae neque ex. Cras blandit sed urna vitae tempor. Sed vitae odio id lectus aliquam eleifend. Mauris tincidunt nisi a nunc tincidunt pulvinar. Suspendisse potenti. Pellentesque lobortis scelerisque pellentesque. Suspendisse non tellus sit amet arcu volutpat sollicitudin. Etiam blandit, lorem sed vehicula convallis, ipsum arcu blandit quam, at semper mauris lacus malesuada erat.",
                            ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg",
                            Name = "Diamond Pool Villa",
                            Occupancy = 4,
                            Rate = 600.0,
                            Sqrmt = 1100,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
