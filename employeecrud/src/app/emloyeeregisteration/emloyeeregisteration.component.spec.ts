import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmloyeeregisterationComponent } from './emloyeeregisteration.component';

describe('EmloyeeregisterationComponent', () => {
  let component: EmloyeeregisterationComponent;
  let fixture: ComponentFixture<EmloyeeregisterationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmloyeeregisterationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EmloyeeregisterationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
