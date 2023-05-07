﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqrmt", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vitae neque ex. Cras blandit sed urna vitae tempor. Sed vitae odio id lectus aliquam eleifend. Mauris tincidunt nisi a nunc tincidunt pulvinar. Suspendisse potenti. Pellentesque lobortis scelerisque pellentesque. Suspendisse non tellus sit amet arcu volutpat sollicitudin. Etiam blandit, lorem sed vehicula convallis, ipsum arcu blandit quam, at semper mauris lacus malesuada erat.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg", "Royal Villa", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vitae neque ex. Cras blandit sed urna vitae tempor. Sed vitae odio id lectus aliquam eleifend. Mauris tincidunt nisi a nunc tincidunt pulvinar. Suspendisse potenti. Pellentesque lobortis scelerisque pellentesque. Suspendisse non tellus sit amet arcu volutpat sollicitudin. Etiam blandit, lorem sed vehicula convallis, ipsum arcu blandit quam, at semper mauris lacus malesuada erat.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg", "Premium Pool Villa", 4, 300.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vitae neque ex. Cras blandit sed urna vitae tempor. Sed vitae odio id lectus aliquam eleifend. Mauris tincidunt nisi a nunc tincidunt pulvinar. Suspendisse potenti. Pellentesque lobortis scelerisque pellentesque. Suspendisse non tellus sit amet arcu volutpat sollicitudin. Etiam blandit, lorem sed vehicula convallis, ipsum arcu blandit quam, at semper mauris lacus malesuada erat.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vitae neque ex. Cras blandit sed urna vitae tempor. Sed vitae odio id lectus aliquam eleifend. Mauris tincidunt nisi a nunc tincidunt pulvinar. Suspendisse potenti. Pellentesque lobortis scelerisque pellentesque. Suspendisse non tellus sit amet arcu volutpat sollicitudin. Etiam blandit, lorem sed vehicula convallis, ipsum arcu blandit quam, at semper mauris lacus malesuada erat.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg", "Royal Villa", 4, 550.0, 900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vitae neque ex. Cras blandit sed urna vitae tempor. Sed vitae odio id lectus aliquam eleifend. Mauris tincidunt nisi a nunc tincidunt pulvinar. Suspendisse potenti. Pellentesque lobortis scelerisque pellentesque. Suspendisse non tellus sit amet arcu volutpat sollicitudin. Etiam blandit, lorem sed vehicula convallis, ipsum arcu blandit quam, at semper mauris lacus malesuada erat.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg", "Diamond Pool Villa", 4, 600.0, 1100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
