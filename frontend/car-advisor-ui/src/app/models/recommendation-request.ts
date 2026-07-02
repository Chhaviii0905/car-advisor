export interface RecommendationRequest {
    budget: number;
    fuelType: string;
    transmission: string;
    bodyType: string;
    minimumSafetyRating: number;
    familySize: number;
}