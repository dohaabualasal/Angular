/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { AppClinicComponent } from './app-clinic.component';

describe('AppClinicComponent', () => {
  let component: AppClinicComponent;
  let fixture: ComponentFixture<AppClinicComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AppClinicComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AppClinicComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
