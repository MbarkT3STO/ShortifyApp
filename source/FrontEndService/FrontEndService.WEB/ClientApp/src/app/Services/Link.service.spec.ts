/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { LinkService } from './Link.service';

describe('Service: Link', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [LinkService]
    });
  });

  it('should ...', inject([LinkService], (service: LinkService) => {
    expect(service).toBeTruthy();
  }));
});
