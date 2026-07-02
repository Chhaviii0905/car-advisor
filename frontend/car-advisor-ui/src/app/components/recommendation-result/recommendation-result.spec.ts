import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecommendationResult } from './recommendation-result';

describe('RecommendationResult', () => {
  let component: RecommendationResult;
  let fixture: ComponentFixture<RecommendationResult>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecommendationResult],
    }).compileComponents();

    fixture = TestBed.createComponent(RecommendationResult);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
