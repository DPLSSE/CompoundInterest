import { Component, OnInit } from '@angular/core';
import { InterestService } from '../services/interest.service';

@Component({
  selector: 'app-calc',
  templateUrl: './calc.page.html',
  styleUrls: ['./calc.page.scss'],
})
export class CalcPage implements OnInit {

  finalResult = 0;

  constructor(private interest: InterestService) { }

  async Calculate() {
    this.finalResult = await this.interest.calculate();
  }

  ngOnInit() {
  }

}
