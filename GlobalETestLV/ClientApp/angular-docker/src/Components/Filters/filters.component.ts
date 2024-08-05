import {HttpClient} from '@angular/common/http';
import {Component, ViewChild, AfterViewInit, inject, Input} from '@angular/core';
import {MatPaginator, MatPaginatorModule} from '@angular/material/paginator';
import {MatSort, MatSortModule, SortDirection} from '@angular/material/sort';
import {merge, Observable, of as observableOf} from 'rxjs';
import {catchError, map, startWith, switchMap} from 'rxjs/operators';
import {MatTableModule} from '@angular/material/table';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import {DatePipe} from '@angular/common';
import { CustomersComponent } from '../Customers/customers.component';
import {FormsModule} from '@angular/forms';
import {MatButtonModule} from '@angular/material/button';
import {
  MAT_DIALOG_DATA,
  MatDialog,
  MatDialogActions,
  MatDialogClose,
  MatDialogContent,
  MatDialogRef,
  MatDialogTitle,
} from '@angular/material/dialog';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import { FilterDialog } from './FilterDialog/filterDialog.component';
@Component({
  selector: 'filters',
  styleUrl: 'filters.component.scss',
  templateUrl: 'filters.component.html',
  standalone: true,
  imports: [MatProgressSpinnerModule, MatTableModule, MatSortModule, MatPaginatorModule, DatePipe, CustomersComponent, 
            MatFormFieldModule, MatInputModule, FormsModule, MatButtonModule],
})
export class FiltersComponent implements AfterViewInit {
  @Input() filterId:number|null
  displayedColumns: string[] = ['id', 'name', 'genders', 'cities', 'depositFrom', 'depositTo', 'ageFrom', 'ageTo', 'isNew'];
  exampleDatabase: FiltersHttpDatabase | null;
  data: Filter[] = [];
  readonly dialog = inject(MatDialog);
  resultsLength = 0;
  isLoadingResults = true;
  isRateLimitReached = false;
  activeRow:Filter | null | undefined = null;

  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  constructor(private _httpClient: HttpClient) {}

  ngOnChanges()
  {
    this.activeRow = this.data.find(x => x.id == this.filterId)
  }
  ngAfterViewInit() {
    this.exampleDatabase = new FiltersHttpDatabase(this._httpClient);

    this.sort.sortChange.subscribe(() => (this.paginator.pageIndex = 0));

    merge(this.sort.sortChange, this.paginator.page)
      .pipe(
        startWith({}),
        switchMap(() => {
          this.isLoadingResults = true;
          return this.exampleDatabase!.getRepoFilters(
            this.sort.active,
            this.sort.direction,
            this.paginator.pageIndex,
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
  openDialog(): void {
    this.exampleDatabase = new FiltersHttpDatabase(this._httpClient);
    const dialogRef = this.dialog.open(FilterDialog, {
      data: {},
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      result.id = 0;
      var genders = result.genders.split(',');
      result.genders = genders;
      var cities = result.cities.split(',');
      result.cities = cities;
      result.isNew = result.isNew === 'true' ? true : false;
      return this.exampleDatabase!.addFilter(
        result
      ).subscribe(res => {
        this.ngAfterViewInit();
        this.activeRow = res;
      })
    });
  }
  

}


export interface Filter {
  id: number;
  name: string;
  genders: Set<string>;
  cities: Set<string>;
  depositFrom: number;
  depositTo: number;
  ageFrom: number;
  ageTo: number;
  isNew: boolean;
}

export class FiltersHttpDatabase {
  constructor(private _httpClient: HttpClient) {}
  href = 'http://localhost:4300/timerfilter';
  getRepoFilters(sort: string, order: SortDirection, page: number): Observable<Filter[]> {
    const requestUrl = `${this.href}`;

    return this._httpClient.get<Filter[]>(requestUrl);
  }
  addFilter(filter: Filter): Observable<Filter> {

    const requestUrl = `${this.href}`;

    return this._httpClient.post<Filter>(requestUrl, filter);
  }
}
