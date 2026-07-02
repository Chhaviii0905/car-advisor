namespace CarAdvisor.API.DTOs
{
    public class RecommendationResponseDto
    {
        public int Id { get; set; }

        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Variant { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public double Mileage { get; set; }

        public int SafetyRating { get; set; }

        public double UserRating { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public int MatchScore { get; set; }

        public List<string> Reasons { get; set; } = new();
    }
}
