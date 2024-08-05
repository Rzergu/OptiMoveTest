import {HttpClient} from '@angular/common/http';
import {Component, ViewChild, AfterViewInit} from '@angular/core';
import {DatePipe} from '@angular/common';
import { CustomersComponent } from '../Components/Customers/customers.component';
import { FiltersComponent } from '../Components/Filters/filters.component';
import { StratiegiesComponent } from "../Components/Strategies/Strategies.component";



@Component({
  selector: 'app-root',
  styleUrl: 'app.component.scss',
  templateUrl: 'app.component.html',
  standalone: true,
  imports: [CustomersComponent, FiltersComponent, DatePipe, StratiegiesComponent],
})
export class AppComponent implements AfterViewInit {

  constructor(private _httpClient: HttpClient) {}

  ngAfterViewInit() {
  }
}
