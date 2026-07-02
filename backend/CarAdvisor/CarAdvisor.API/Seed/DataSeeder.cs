using System.Collections.Generic;
using System.Linq;
using CarAdvisor.API.Data;
using CarAdvisor.API.Models;

namespace CarAdvisor.API.Seed
{
    public static class DataSeeder
    {
        public static void SeedData(AppDbContext context)
        {
            var seedCars = new List<Car>
            {
                // Maruti Suzuki
                new Car
                {
                    Make = "Maruti Suzuki",
                    Model = "Alto 800",
                    Variant = "LXI",
                    Price = 350000,
                    FuelType = "Petrol",
                    Transmission = "Manual",
                    BodyType = "Hatchback",
                    Mileage = 22,
                    SafetyRating = 3,
                    Seats = 5,
                    UserRating = 4.0,
                    ImageUrl = "assets/cars/alto.webp"
                },
                new Car
                {
                    Make = "Maruti Suzuki",
                    Model = "WagonR",
                    Variant = "VXi",
                    Price = 540000,
                    FuelType = "Petrol",
                    Transmission = "Manual",
                    BodyType = "Hatchback",
                    Mileage = 20,
                    SafetyRating = 3,
                    Seats = 5,
                    UserRating = 4.1,
                    ImageUrl = "assets/cars/wagonr.webp"
                },
                new Car
                {
                    Make = "Maruti Suzuki",
                    Model = "Swift",
                    Variant = "ZXI",
                    Price = 650000,
                    FuelType = "Petrol",
                    Transmission = "Manual",
                    BodyType = "Hatchback",
                    Mileage = 21,
                    SafetyRating = 4,
                    Seats = 5,
                    UserRating = 4.3,
                    ImageUrl = "assets/cars/swift.webp"
                },
                new Car
                {
                    Make = "Maruti Suzuki",
                    Model = "Dzire",
                    Variant = "VXi",
                    Price = 750000,
                    FuelType = "Petrol",
                    Transmission = "Manual",
                    BodyType = "Sedan",
                    Mileage = 23,
                    SafetyRating = 4,
                    Seats = 5,
                    UserRating = 4.2,
                    ImageUrl = "assets/cars/dzire.webp"
                },

                // Hyundai
                new Car
                {
                    Make = "Hyundai",
                    Model = "i20",
                    Variant = "Magna",
                    Price = 750000,
                    FuelType = "Petrol",
                    Transmission = "Manual",
                    BodyType = "Hatchback",
                    Mileage = 19,
                    SafetyRating = 4,
                    Seats = 5,
                    UserRating = 4.3,
                    ImageUrl = "assets/cars/i20.webp"
                },
                new Car
                {
                    Make = "Hyundai",
                    Model = "Venue",
                    Variant = "S",
                    Price = 900000,
                    FuelType = "Petrol",
                    Transmission = "Manual",
                    BodyType = "SUV",
                    Mileage = 17,
                    SafetyRating = 4,
                    Seats = 5,
                    UserRating = 4.2,
                    ImageUrl = "assets/cars/venue.webp"
                },
                new Car
                {
                    Make = "Hyundai",
                    Model = "Creta",
                    Variant = "S",
                    Price = 1500000,
                    FuelType = "Petrol",
                    Transmission = "Automatic",
                    BodyType = "SUV",
                    Mileage = 15,
                    SafetyRating = 5,
                    Seats = 5,
                    UserRating = 4.4,
                    ImageUrl = "assets/cars/creta.webp"
                },

                // Kia
                new Car
                {
                    Make = "Kia",
                    Model = "Sonet",
                    Variant = "HTE",
                    Price = 1000000,
                    FuelType = "Petrol",
                    Transmission = "Manual",
                    BodyType = "SUV",
                    Mileage = 18,
                    SafetyRating = 4,
                    Seats = 5,
                    UserRating = 4.1,
                    ImageUrl = "assets/cars/sonet.webp"
                },
                new Car
                {
                    Make = "Kia",
                    Model = "Seltos",
                    Variant = "HTE",
                    Price = 1500000,
                    FuelType = "Petrol",
                    Transmission = "Automatic",
                    BodyType = "SUV",
                    Mileage = 16,
                    SafetyRating = 5,
                    Seats = 5,
                    UserRating = 4.3,
                    ImageUrl = "assets/cars/seltos.webp"
                },

                // Tata
                new Car
                {
                    Make = "Tata",
                    Model = "Tiago",
                    Variant = "XE",
                    Price = 600000,
                    FuelType = "Petrol",
                    Transmission = "Manual",
                    BodyType = "Hatchback",
                    Mileage = 20,
                    SafetyRating = 4,
                    Seats = 5,
                    UserRating = 4.0,
                    ImageUrl = "assets/cars/tiago.webp"
                },
                new Car
                {
                    Make = "Tata",
                    Model = "Altroz",
                    Variant = "XE",
                    Price = 700000,
                    FuelType = "Petrol",
                    Transmission = "Manual",
                    BodyType = "Hatchback",
                    Mileage = 20,
                    SafetyRating = 5,
                    Seats = 5,
                    UserRating = 4.1,
                    ImageUrl = "assets/cars/altroz.webp"
                },
                new Car
                {
                    Make = "Tata",
                    Model = "Nexon",
                    Variant = "XM",
                    Price = 1100000,
                    FuelType = "Petrol",
                    Transmission = "Manual",
                    BodyType = "SUV",
                    Mileage = 17,
                    SafetyRating = 5,
                    Seats = 5,
                    UserRating = 4.2,
                    ImageUrl = "assets/cars/nexon.webp"
                },

                // Mahindra
                new Car
                {
                    Make = "Mahindra",
                    Model = "Thar",
                    Variant = "LX",
                    Price = 1200000,
                    FuelType = "Petrol",
                    Transmission = "Manual",
                    BodyType = "SUV",
                    Mileage = 13,
                    SafetyRating = 4,
                    Seats = 4,
                    UserRating = 4.0,
                    ImageUrl = "assets/cars/thar.webp"
                },
                new Car
                {
                    Make = "Mahindra",
                    Model = "Scorpio-N",
                    Variant = "Z8",
                    Price = 1600000,
                    FuelType = "Petrol",
                    Transmission = "Manual",
                    BodyType = "SUV",
                    Mileage = 12,
                    SafetyRating = 5,
                    Seats = 7,
                    UserRating = 4.2,
                    ImageUrl = "assets/cars/scorpio.webp"
                },
                new Car
                {
                    Make = "Mahindra",
                    Model = "XUV700",
                    Variant = "AX3",
                    Price = 1800000,
                    FuelType = "Petrol",
                    Transmission = "Automatic",
                    BodyType = "SUV",
                    Mileage = 13,
                    SafetyRating = 5,
                    Seats = 7,
                    UserRating = 4.4,
                    ImageUrl = "assets/cars/xuv700.webp"
                },

                // Toyota
                new Car
                {
                    Make = "Toyota",
                    Model = "Innova Crysta",
                    Variant = "GX",
                    Price = 2400000,
                    FuelType = "Diesel",
                    Transmission = "Automatic",
                    BodyType = "MPV",
                    Mileage = 12,
                    SafetyRating = 4,
                    Seats = 7,
                    UserRating = 4.4,
                    ImageUrl = "assets/cars/crysta.webp"
                },
                new Car
                {
                    Make = "Toyota",
                    Model = "Fortuner",
                    Variant = "4x2",
                    Price = 3500000,
                    FuelType = "Diesel",
                    Transmission = "Automatic",
                    BodyType = "SUV",
                    Mileage = 10,
                    SafetyRating = 5,
                    Seats = 7,
                    UserRating = 4.5,
                    ImageUrl = "assets/cars/fortuner.webp"
                },

                // Honda
                new Car
                {
                    Make = "Honda",
                    Model = "City",
                    Variant = "V",
                    Price = 1300000,
                    FuelType = "Petrol",
                    Transmission = "Automatic",
                    BodyType = "Sedan",
                    Mileage = 18,
                    SafetyRating = 4,
                    Seats = 5,
                    UserRating = 4.3,
                    ImageUrl = "assets/cars/honda-city.webp"
                },
                new Car
                {
                    Make = "Honda",
                    Model = "Amaze",
                    Variant = "S",
                    Price = 700000,
                    FuelType = "Petrol",
                    Transmission = "Manual",
                    BodyType = "Sedan",
                    Mileage = 18,
                    SafetyRating = 4,
                    Seats = 5,
                    UserRating = 4.0,
                    ImageUrl = "assets/cars/amaze.webp"
                },

                // Luxury
                new Car
                {
                    Make = "BMW",
                    Model = "3 Series",
                    Variant = "320i",
                    Price = 4500000,
                    FuelType = "Petrol",
                    Transmission = "Automatic",
                    BodyType = "Sedan",
                    Mileage = 14,
                    SafetyRating = 5,
                    Seats = 5,
                    UserRating = 4.4,
                    ImageUrl = "assets/cars/bmw.webp"
                },
                new Car
                {
                    Make = "Audi",
                    Model = "Q3",
                    Variant = "Premium",
                    Price = 4200000,
                    FuelType = "Petrol",
                    Transmission = "Automatic",
                    BodyType = "SUV",
                    Mileage = 13,
                    SafetyRating = 5,
                    Seats = 5,
                    UserRating = 4.3,
                    ImageUrl = "assets/cars/audi.webp"
                }
            };

            foreach (var car in seedCars)
            {
                var existingCar = context.Cars.FirstOrDefault(c =>
                    c.Make == car.Make &&
                    c.Model == car.Model &&
                    c.Variant == car.Variant);

                if (existingCar == null)
                {
                    context.Cars.Add(car);
                }
                else
                {
                    existingCar.ImageUrl = car.ImageUrl;
                    existingCar.Price = car.Price;
                    existingCar.FuelType = car.FuelType;
                    existingCar.Transmission = car.Transmission;
                    existingCar.BodyType = car.BodyType;
                    existingCar.Mileage = car.Mileage;
                    existingCar.SafetyRating = car.SafetyRating;
                    existingCar.Seats = car.Seats;
                    existingCar.UserRating = car.UserRating;
                }
            }

            context.SaveChanges();
        }
    }
}