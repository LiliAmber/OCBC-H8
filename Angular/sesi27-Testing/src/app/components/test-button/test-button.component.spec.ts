import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TestButtonComponent } from './test-button.component';

describe('TestButtonComponent', () => {
  let component: TestButtonComponent;
  let fixture: ComponentFixture<TestButtonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TestButtonComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TestButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should render a title', () => {
    fixture = TestBed.createComponent(TestButtonComponent)
    fixture.detectChanges()
    const compiled = fixture.nativeElement as HTMLElement
    expect(compiled.querySelector('button.title')?.textContent).toContain('Klik aku dong')
  })
});
