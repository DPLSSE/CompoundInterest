import { TestBed } from '@angular/core/testing';

import { HiDougService } from './hi-doug.service';

describe('HiDougService', () => {
  let service: HiDougService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HiDougService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
