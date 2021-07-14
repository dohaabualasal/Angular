import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-typography',
  templateUrl: './typography.component.html',
  styleUrls: ['./typography.component.css']
})
export class TypographyComponent implements OnInit {

  Doctors: Array<any> = [];
  constructor( private route: ActivatedRoute,
    private http: HttpClient,
    private router: Router) { }
   
  ngOnInit() {
    this.GetSales().subscribe(
      (data:any)=>{
        this.Doctors=data;
  })
}
  GetSales():Observable<any[]> {


    return this.http.get<any>('http://localhost:5000/api/Doctors');
     
   }
  }