using System.ComponentModel.DataAnnotations;

namespace CarAdvisor.API.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Make { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Model { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Variant { get; set; } = string.Empty;

        [Range(100000, 10000000)]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(20)]
        public string FuelType { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string Transmission { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string BodyType { get; set; } = string.Empty;

        [Range(1, 50)]
        public double Mileage { get; set; }

        [Range(0, 5)]
        public int SafetyRating { get; set; }

        [Range(2, 9)]
        public int Seats { get; set; }

        [Range(0, 5)]
        public double UserRating { get; set; }

        [Url]
        public string? ImageUrl { get; set; }
    }
}
