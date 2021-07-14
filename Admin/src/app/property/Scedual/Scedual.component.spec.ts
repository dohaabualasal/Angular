/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { ScedualComponent } from './Scedual.component';

describe('ScedualComponent', () => {
  let component: ScedualComponent;
  let fixture: ComponentFixture<ScedualComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ScedualComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ScedualComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
