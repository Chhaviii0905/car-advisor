import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecommendationForm } from './recommendation-form';

describe('RecommendationForm', () => {
  let component: RecommendationForm;
  let fixture: ComponentFixture<RecommendationForm>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RecommendationForm],
    }).compileComponents();

    fixture = TestBed.createComponent(RecommendationForm);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
