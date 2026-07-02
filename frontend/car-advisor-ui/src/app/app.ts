import { CommonModule } from '@angular/common';
import { Component, inject, signal } from '@angular/core';
import { RecommendationFormComponent } from './components/recommendation-form/recommendation-form';
import { RecommendationResult } from './components/recommendation-result/recommendation-result';
import { CarService } from './services/car.service';
import { RecommendationRequest } from './models/recommendation-request';
import { RecommendationResponse } from './models/recommendation-response';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RecommendationFormComponent, RecommendationResult],
  templateUrl: './app.html',
  styleUrls: ['./app.scss'],
})
export class App {
  protected readonly title = signal('car-advisor-ui');
  protected readonly recommendations = signal<RecommendationResponse[]>([]);
  protected readonly loading = signal(false);
  protected readonly error = signal('');
  protected readonly showResults = signal(false);

  private readonly carService = inject(CarService);

  protected onSearch(request: RecommendationRequest): void {
    this.showResults.set(true);
    this.loading.set(true);
    this.error.set('');

    this.carService.getRecommendations(request).subscribe({
      next: (results) => {
        this.recommendations.set(results.slice(0, 5));
        this.loading.set(false);
      },
      error: () => {
        this.recommendations.set([]);
        this.error.set('Unable to get recommendations. Please try again.');
        this.loading.set(false);
      }
    });
  }

  protected reset(): void {
    this.showResults.set(false);
    this.recommendations.set([]);
    this.error.set('');
    this.loading.set(false);
  }
}
