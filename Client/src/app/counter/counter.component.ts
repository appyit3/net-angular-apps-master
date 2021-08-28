import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiConstants } from '../constants/api-constants';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public currentCount = 0;
  public message = { msg: " Loading..."};
  constructor(http: HttpClient) {
    http.get<any>(ApiConstants.uri + '/weatherforecast/getmessage').subscribe(result => {
      
      this.message = result;
      console.log(this.message);
    }, error => console.error(error));
  }

  public incrementCounter() {
    this.currentCount++;
  }
}
