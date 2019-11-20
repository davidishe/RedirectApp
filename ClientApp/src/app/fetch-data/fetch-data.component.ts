import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})

export class FetchDataComponent {
  record: CounterRecord = {
    userId: 333,
    userName: 'Vishnu',
    countValue: 1,
    createDateTime: 'test test',
  };

  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) {
    http.get<CounterRecord[]>(baseUrl + 'Counter').subscribe(result => {
      console.log(result);
    }, error => console.error(error));

  }

  postData() {
    this.http.post('https://localhost:5001/Counter/AddRecord/', this.record)
    .subscribe(result => {
      console.log(result);
    }, error => {
      console.log(error);
    });
  }

  // end export class
}

interface CounterRecord {
  userId: number;
  userName: string;
  createDateTime?: string;
  countValue: number;
}


