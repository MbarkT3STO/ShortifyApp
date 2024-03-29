/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ShortenUrlInterceptorService } from './ShortenUrlInterceptor.service';

describe('Service: ShortenUrlInterceptor', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ShortenUrlInterceptorService]
    });
  });

  it('should ...', inject([ShortenUrlInterceptorService], (service: ShortenUrlInterceptorService) => {
    expect(service).toBeTruthy();
  }));
});
