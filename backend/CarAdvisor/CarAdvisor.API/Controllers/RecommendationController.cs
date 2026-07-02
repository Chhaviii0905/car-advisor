using CarAdvisor.API.DTOs;
using CarAdvisor.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarAdvisor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecommendationController : ControllerBase
    {
        private readonly ICarRecommendationService _carRecommendationService;
        public RecommendationController(ICarRecommendationService carRecommendationService)
        {
            _carRecommendationService = carRecommendationService;
        }
        [HttpPost]
        public async Task<IActionResult> GetRecommendedCars([FromBody] RecommendationRequestDto request)
        {
            var recommendedCars = await _carRecommendationService.GetRecommendedCarsAsync(request);
            return Ok(recommendedCars);
        }
    }
}
