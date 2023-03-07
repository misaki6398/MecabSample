import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JapanesenlpComponent } from './japanesenlp.component';

describe('JapanesenlpComponent', () => {
  let component: JapanesenlpComponent;
  let fixture: ComponentFixture<JapanesenlpComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ JapanesenlpComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(JapanesenlpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
