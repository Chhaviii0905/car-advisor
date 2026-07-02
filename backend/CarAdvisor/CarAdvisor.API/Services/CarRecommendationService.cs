using CarAdvisor.API.Data;
using CarAdvisor.API.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CarAdvisor.API.Services
{
    public class CarRecommendationService : ICarRecommendationService
    {
        private readonly AppDbContext _context;
        public CarRecommendationService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<RecommendationResponseDto>> GetRecommendedCarsAsync(RecommendationRequestDto request)
        {
            var cars = await _context.Cars.ToListAsync();
            var recommendations = new List<RecommendationResponseDto>();

            foreach (var car in cars)
            {
                int score = 0;
                var reasons = new List<string>();

                //Price
                if (car.Price <= request.Budget)
                {
                    score += 30;
                    reasons.Add("Fits within your budget");
                }
                //Fuel Type
                if (car.FuelType.Equals(request.FuelType, StringComparison.OrdinalIgnoreCase))
                {
                    score += 20;
                    reasons.Add("Matches your preferred fuel type");
                }
                //Transmission
                if (car.Transmission.Equals(request.Transmission, StringComparison.OrdinalIgnoreCase))
                {
                    score += 15;
                    reasons.Add("Matches your preferred transmission");
                }
                // Body Type
                if (car.BodyType.Equals(request.BodyType, StringComparison.OrdinalIgnoreCase))
                {
                    score += 10;
                    reasons.Add("Preferred body type");
                }

                // Safety
                if (car.SafetyRating >= request.MinimumSafetyRating)
                {
                    score += 20;
                    reasons.Add("Meets your safety requirement");
                }

                // Family Size
                if (car.Seats >= request.FamilySize)
                {
                    score += 10;
                    reasons.Add("Suitable for your family size");
                }

                // User Rating
                if (car.UserRating >= 4.5)
                {
                    score += 5;
                    reasons.Add("Highly rated by users");
                }

                recommendations.Add(new RecommendationResponseDto
                {
                    Id = car.Id,
                    Make = car.Make,
                    Model = car.Model,
                    Variant = car.Variant,
                    Price = car.Price,
                    Mileage = car.Mileage,
                    SafetyRating = car.SafetyRating,
                    UserRating = car.UserRating,
                    ImageUrl = car.ImageUrl ?? string.Empty,
                    MatchScore = score,
                    Reasons = reasons
                });
            }

            return recommendations
                        .OrderByDescending(c => c.MatchScore)
                        .Take(5)
                        .ToList();
        }
    }
}
