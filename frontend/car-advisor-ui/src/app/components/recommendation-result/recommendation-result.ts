import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Input, Output } from '@angular/core';
import { CarCard } from '../car-card/car-card';
import { RecommendationResponse } from '../../models/recommendation-response';

@Component({
  selector: 'app-recommendation-result',
  standalone: true,
  imports: [CommonModule, CarCard],
  templateUrl: './recommendation-result.html',
  styleUrls: ['./recommendation-result.scss'],
})
export class RecommendationResult {
  @Input() recommendations: RecommendationResponse[] = [];
  @Input() loading = false;
  @Input() error = '';
  @Output() reset = new EventEmitter<void>();

  onReset(): void {
    this.reset.emit();
  }
}
