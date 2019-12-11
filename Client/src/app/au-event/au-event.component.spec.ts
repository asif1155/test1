import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AuEventComponent } from './au-event.component';

describe('AuEventComponent', () => {
  let component: AuEventComponent;
  let fixture: ComponentFixture<AuEventComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AuEventComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AuEventComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
