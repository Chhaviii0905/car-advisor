import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';
import { RecommendationResponse } from '../../models/recommendation-response';

@Component({
  selector: 'app-car-card',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './car-card.html',
  styleUrls: ['./car-card.scss'],
})
export class CarCard {
  @Input() car!: RecommendationResponse;
  private fallback = '/assets/placeholder.png';

  get imageSrc(): string {
    if (!this.car || !this.car.imageUrl) return this.fallback;
    const url = this.car.imageUrl.trim();
    return url.startsWith('/') ? url : '/' + url;
  }

  onImgError(event: Event): void {
    const img = event.target as HTMLImageElement | null;
    if (img) img.src = this.fallback;
  }
}
