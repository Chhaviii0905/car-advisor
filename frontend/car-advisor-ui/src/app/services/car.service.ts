import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { RecommendationRequest } from '../models/recommendation-request';
import { RecommendationResponse } from '../models/recommendation-response';

@Injectable({
  providedIn: 'root'
})
export class CarService {

  private http = inject(HttpClient);
  private apiUrl = 'http://localhost:5005/api/Recommendation';

  getRecommendations(request: RecommendationRequest): Observable<RecommendationResponse[]> {
    return this.http.post<RecommendationResponse[]>(this.apiUrl, request);
  }
}