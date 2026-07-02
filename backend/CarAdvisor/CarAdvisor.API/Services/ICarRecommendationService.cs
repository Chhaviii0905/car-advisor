using CarAdvisor.API.DTOs;

namespace CarAdvisor.API.Services
{
    public interface ICarRecommendationService
    {
        Task<List<RecommendationResponseDto>> GetRecommendedCarsAsync(RecommendationRequestDto request);
    }
}
