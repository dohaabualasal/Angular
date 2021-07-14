import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-table-list',
  templateUrl: './table-list.component.html',
  styleUrls: ['./table-list.component.css'],
})
export class TableListComponent implements OnInit {
  Sales: Array<any> = [];
  SortDirection = 'asc';
  Date = '';
  searchDate = '';
  Profit: Array<any>;
  constructor(
    private route: ActivatedRoute,
    private http: HttpClient,
    private router: Router
  ) {}
  ngOnInit() {
    this.GetSales().subscribe((data: any) => {
      this.Sales = data;
    });
    this.GetProfit().subscribe((data: any) => {
      this.Profit = data;
    });
  }
  GetSales(): Observable<any[]> {
    return this.http.get<any>('http://localhost:5000/api/Clinic/Sales');
  }

  GetProfit(): Observable<any[]> {
    return this.http.get<any>('http://localhost:5000/api/Clinic/Profit');
  }

  onFilter2() {
    this.searchDate = this.Date;
  }

  onFilterClear() {

    this.searchDate = '';
    this.Date = '';
  }
  onSortDirection() {
    if (this.SortDirection === 'desc') {
      this.SortDirection = 'asc';
    } else {
      this.SortDirection = 'desc';
    }
  }
}



