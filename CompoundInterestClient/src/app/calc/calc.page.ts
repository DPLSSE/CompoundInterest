import { Component, OnInit } from '@angular/core';
import { InterestService } from '../interest.service';

@Component({
  selector: 'app-calc',
  templateUrl: './calc.page.html',
  styleUrls: ['./calc.page.scss'],
})
export class CalcPage implements OnInit {

  principle = 1000;
  finalResult = 0;

  constructor(private interestService: InterestService) { }

  ngOnInit() {
  }

  public async calcInterest() {
    console.log('howdy Doug again');
    this.finalResult = await this.interestService.calculateInterest(this.principle);
    console.log(this.finalResult);
  }

}
