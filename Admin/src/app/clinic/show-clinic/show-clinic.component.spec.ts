import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowClinicComponent } from './show-clinic.component';

describe('ShowClinicComponent', () => {
  let component: ShowClinicComponent;
  let fixture: ComponentFixture<ShowClinicComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowClinicComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowClinicComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
