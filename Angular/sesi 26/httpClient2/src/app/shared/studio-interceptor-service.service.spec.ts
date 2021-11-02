import { TestBed } from '@angular/core/testing';

import { StudioInterceptorServiceService } from './studio-interceptor-service.service';

describe('StudioInterceptorServiceService', () => {
  let service: StudioInterceptorServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StudioInterceptorServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
