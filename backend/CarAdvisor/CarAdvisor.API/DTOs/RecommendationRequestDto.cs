namespace CarAdvisor.API.DTOs
{
    public class RecommendationRequestDto
    {
        public decimal Budget { get; set; }
        public string FuelType { get; set; } = string.Empty;

        public string Transmission { get; set; } = string.Empty;

        public string BodyType { get; set; } = string.Empty;

        public int MinimumSafetyRating { get; set; }

        public int FamilySize { get; set; }
    }
}
