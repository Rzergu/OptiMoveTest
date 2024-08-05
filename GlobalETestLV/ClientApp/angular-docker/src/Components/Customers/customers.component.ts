import {HttpClient} from '@angular/common/http';
import {Component, ViewChild, AfterViewInit, Input, OnInit} from '@angular/core';
import {MatPaginator, MatPaginatorModule} from '@angular/material/paginator';
import {MatSort, MatSortModule, SortDirection} from '@angular/material/sort';
import {merge, Observable, of as observableOf, ReplaySubject} from 'rxjs';
import {catchError, map, startWith, switchMap} from 'rxjs/operators';
import {MatTableModule} from '@angular/material/table';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import {DatePipe} from '@angular/common';
import { Filter } from '../Filters/filters.component';

@Component({
  selector: 'customers',
  styleUrl: 'customers.component.scss',
  templateUrl: 'customers.component.html',
  standalone: true,
  imports: [MatProgressSpinnerModule, MatTableModule, MatSortModule, MatPaginatorModule, DatePipe],
})
export class CustomersComponent implements AfterViewInit {
  @Input() filterId:number|null
  displayedColumns: string[] = ['id', 'age', 'gender', 'city', 'deposit', 'new'];
  exampleDatabase: ExampleHttpDatabase | null;
  data: Customer[] = [];
  initialized = false;

  resultsLength = 0;
  isLoadingResults = true;
  isRateLimitReached = false;

  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  constructor(private _httpClient: HttpClient) {}

  ngOnChanges()
  {
    if(this.initialized)
    {
      merge(this.sort.sortChange, this.paginator.page)
      .pipe(
        startWith({}),
        switchMap(() => {
          this.isLoadingResults = true;
          return this.exampleDatabase!.getRepoCustomers(
            this.filterId
          ).pipe(catchError(() => observableOf(null)));
        }),
        map(data => {
          this.isLoadingResults = false;
          this.isRateLimitReached = data === null;
  
          if (data === null) {
            return [];
          }
          this.resultsLength = data.length;
          return data;
        }),
      )
      .subscribe(data => (this.data = data));
    }
  }
  ngAfterViewInit() {
    this.exampleDatabase = new ExampleHttpDatabase(this._httpClient);
    this.initialized = true;
    this.filterId = 1;
  }
}


export interface Customer {
  id: number;
  age: number;
  gender: string;
  city: string;
  deposit: number;
  isNew: boolean;
}

export class ExampleHttpDatabase {
  constructor(private _httpClient: HttpClient) {}

  getRepoCustomers(filterId: number|null): Observable<Customer[]> {
    const href = 'http://localhost:4300/customers';
    var requestUrl = `${href}`;
    if(filterId != null)
    {
        requestUrl =  `${href}?filterId=${filterId}`;
    }


    return this._httpClient.get<Customer[]>(requestUrl);
  }
}
