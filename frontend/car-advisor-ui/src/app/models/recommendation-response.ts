export interface RecommendationResponse {
    id: number;
    make: string;
    model: string;
    variant: string;
    price: number;
    mileage: number;
    safetyRating: number;
    userRating: number;
    imageUrl: string;
    matchScore: number;
    reasons: string[];
}