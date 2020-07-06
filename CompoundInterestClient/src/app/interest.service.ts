import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class InterestService {

  constructor(private httpClient: HttpClient) { }

  public async calculateInterest(principle: number): Promise<number> {
    return this.httpClient.get<number>(
      'https://localhost:5001/Interest/CalculateInterest?principle=' + principle).toPromise();
  }
}
