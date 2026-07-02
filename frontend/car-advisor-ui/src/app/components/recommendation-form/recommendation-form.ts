import { Component, EventEmitter, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RecommendationRequest } from '../../models/recommendation-request';

@Component({
  selector: 'app-recommendation-form',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './recommendation-form.html',
  styleUrls: ['./recommendation-form.scss']
})
export class RecommendationFormComponent {

  @Output() search = new EventEmitter<RecommendationRequest>();

  request: RecommendationRequest = {
    budget: 10000000,
    fuelType: 'Any',
    transmission: 'Any',
    bodyType: 'Any',
    minimumSafetyRating: 4,
    familySize: 5
  };

  fuelTypeOptions = [
    'Any',
    'Petrol',
    'Diesel'
  ];

  transmissionOptions = [
    'Any',
    'Manual',
    'Automatic'
  ];

  bodyTypeOptions = [
    'Any',
    'SUV',
    'Sedan',
    'Hatchback',
    'MPV'
  ];

  safetyRatings = [1, 2, 3, 4, 5];

  familySizes = [2, 3, 4, 5, 6, 7];

  submitted = false;

  onSubmit(): void {
    this.submitted = true;
    this.search.emit(this.request);
  }
}