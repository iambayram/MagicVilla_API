using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id=1,
                    Name="Royal Villa",
                    Details= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vitae neque ex. Cras blandit sed urna vitae tempor. Sed vitae odio id lectus aliquam eleifend. Mauris tincidunt nisi a nunc tincidunt pulvinar. Suspendisse potenti. Pellentesque lobortis scelerisque pellentesque. Suspendisse non tellus sit amet arcu volutpat sollicitudin. Etiam blandit, lorem sed vehicula convallis, ipsum arcu blandit quam, at semper mauris lacus malesuada erat.",
                    ImageUrl= "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg",
                    Occupancy=4,
                    Rate=200,
                    Sqrmt=550,
                    Amenity="",
                    CreatedDate= DateTime.Now
                }, new Villa()
                {
                    Id = 2,
                    Name = "Premium Pool Villa",
                    Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vitae neque ex. Cras blandit sed urna vitae tempor. Sed vitae odio id lectus aliquam eleifend. Mauris tincidunt nisi a nunc tincidunt pulvinar. Suspendisse potenti. Pellentesque lobortis scelerisque pellentesque. Suspendisse non tellus sit amet arcu volutpat sollicitudin. Etiam blandit, lorem sed vehicula convallis, ipsum arcu blandit quam, at semper mauris lacus malesuada erat.",
                    ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg",
                    Occupancy = 4,
                    Rate = 300,
                    Sqrmt = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                }, new Villa()
                {
                    Id = 3,
                    Name = "Luxury Pool Villa",
                    Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vitae neque ex. Cras blandit sed urna vitae tempor. Sed vitae odio id lectus aliquam eleifend. Mauris tincidunt nisi a nunc tincidunt pulvinar. Suspendisse potenti. Pellentesque lobortis scelerisque pellentesque. Suspendisse non tellus sit amet arcu volutpat sollicitudin. Etiam blandit, lorem sed vehicula convallis, ipsum arcu blandit quam, at semper mauris lacus malesuada erat.",
                    ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg",
                    Occupancy = 4,
                    Rate = 400,
                    Sqrmt = 750,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                }, new Villa()
                {
                    Id = 4,
                    Name = "Royal Villa",
                    Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vitae neque ex. Cras blandit sed urna vitae tempor. Sed vitae odio id lectus aliquam eleifend. Mauris tincidunt nisi a nunc tincidunt pulvinar. Suspendisse potenti. Pellentesque lobortis scelerisque pellentesque. Suspendisse non tellus sit amet arcu volutpat sollicitudin. Etiam blandit, lorem sed vehicula convallis, ipsum arcu blandit quam, at semper mauris lacus malesuada erat.",
                    ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg",
                    Occupancy = 4,
                    Rate = 550,
                    Sqrmt = 900,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                }, new Villa()
                {
                    Id = 5,
                    Name = "Diamond Pool Villa",
                    Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vitae neque ex. Cras blandit sed urna vitae tempor. Sed vitae odio id lectus aliquam eleifend. Mauris tincidunt nisi a nunc tincidunt pulvinar. Suspendisse potenti. Pellentesque lobortis scelerisque pellentesque. Suspendisse non tellus sit amet arcu volutpat sollicitudin. Etiam blandit, lorem sed vehicula convallis, ipsum arcu blandit quam, at semper mauris lacus malesuada erat.",
                    ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg",
                    Occupancy = 4,
                    Rate = 600,
                    Sqrmt = 1100,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                });
        }
    }
}
