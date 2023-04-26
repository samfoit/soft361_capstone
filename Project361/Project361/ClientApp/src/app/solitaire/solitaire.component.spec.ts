import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SolitaireComponent } from './solitaire.component';

describe('SolitaireComponent', () => {
  let component: SolitaireComponent;
  let fixture: ComponentFixture<SolitaireComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SolitaireComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SolitaireComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
