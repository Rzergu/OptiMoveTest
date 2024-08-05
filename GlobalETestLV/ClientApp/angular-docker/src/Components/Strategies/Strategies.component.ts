import {HttpClient} from '@angular/common/http';
import {Component, ViewChild, AfterViewInit, inject} from '@angular/core';
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
import { StrategyDialog } from './StratigiesDialog/stratigiesDialog.component';
import { FiltersComponent } from '../Filters/filters.component';
@Component({
  selector: 'strategies',
  styleUrl: 'Strategies.component.scss',
  templateUrl: 'Strategies.component.html',
  standalone: true,
  imports: [MatProgressSpinnerModule, MatTableModule, MatSortModule, MatPaginatorModule, DatePipe, CustomersComponent, 
            MatFormFieldModule, MatInputModule, FormsModule, MatButtonModule, FiltersComponent],
})
export class StratiegiesComponent implements AfterViewInit {
  displayedColumns: string[] = ['id', 'filterId', 'time', 'templateId', 'priority'];
  exampleDatabase: StrategiesHttpDatabase | null;
  data: Strategy[] = [];
  readonly dialog = inject(MatDialog);
  resultsLength = 0;
  isLoadingResults = true;
  isRateLimitReached = false;
  activeRow:Strategy | null = null;

  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  constructor(private _httpClient: HttpClient) {}

  ngAfterViewInit() {
    this.exampleDatabase = new StrategiesHttpDatabase(this._httpClient);

    this.sort.sortChange.subscribe(() => (this.paginator.pageIndex = 0));

    merge(this.sort.sortChange, this.paginator.page)
      .pipe(
        startWith({}),
        switchMap(() => {
          this.isLoadingResults = true;
          return this.exampleDatabase!.getRepoStrategies(
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
    this.exampleDatabase = new StrategiesHttpDatabase(this._httpClient);
    const dialogRef = this.dialog.open(StrategyDialog, {
      data: {},
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      result.id = 0;
      return this.exampleDatabase!.addStrategy(
        result
      ).subscribe(res => {
        this.ngAfterViewInit();
        this.activeRow = res;
      })
    });
  }
  

}


export interface Strategy {
  id: number;
  filterId :number;
  templateId:number;
  time:string;
  priority:number;
}

export class StrategiesHttpDatabase {
  constructor(private _httpClient: HttpClient) {}
  href = 'http://localhost:4300/timer';
  getRepoStrategies(sort: string, order: SortDirection, page: number): Observable<Strategy[]> {
    const requestUrl = `${this.href}`;

    return this._httpClient.get<Strategy[]>(requestUrl);
  }
  addStrategy(filter: Strategy): Observable<Strategy> {

    const requestUrl = `${this.href}`;

    return this._httpClient.post<Strategy>(requestUrl, filter);
  }
}
