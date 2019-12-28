import { Component, OnInit } from '@angular/core';
import { DataService } from './data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  products = [];

  constructor(private dataService: DataService) {}

  ngOnInit() {
    this.dataService
    .sendGetRequest().subscribe((data: any[]) => {
      console.log(data);
      this.products = data;
    });
  }
}
