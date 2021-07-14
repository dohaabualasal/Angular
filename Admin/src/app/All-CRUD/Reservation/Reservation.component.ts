import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-Reservation',
  templateUrl: './Reservation.component.html',
  styleUrls: ['./Reservation.component.css'],
})
export class ReservationComponent implements OnInit {
  public propertyId: number = 0;
 // @Input() Reservation: any;
  //Reservation: Array<any> = [];
  Reservation: Array<any>=[];
  SortbyParam = '';
  SortDirection = 'asc';
  Name = '';
  Date='';
  searchDate='';
  SearchName = '';
  max = 10;
  rate = 7;
  isReadonly = true;
  ClinicId:number=+this.route.snapshot.params['Id'];

  constructor(
    private route: ActivatedRoute,
    private http: HttpClient,
    private router: Router
  ) {}

  ngOnInit() {
    this.GetReservation(this.ClinicId).subscribe(
      (data:any)=>{
        this.Reservation=data;
        console.log(this.Reservation)});
        return (this.Reservation);



  }
  onSortDirection() {
    if (this.SortDirection === 'desc') {
      this.SortDirection = 'asc';
    } else {
      this.SortDirection = 'desc';
    }
  }
  onFilter() {
    this.SearchName = this.Name;
  }
  onFilter2() {
    this.searchDate = this.Date;
  }

  onFilterClear() {
    this.SearchName = '';
    this.Name = '';
    this.searchDate='';
    this.Date='';
  }
  GetReservation(val:any):Observable<any[]> {


   return this.http.get<any>('http://localhost:5000/api/Clinic/GetReservation?id='+val)
    //return this.http.post(this.APIUrl+'/Department',val);
  }
  DeleteReservation(val : number){
    return this.http.delete('http://localhost:5000/api/Clinic/DeleteReservation?id='+val);
   }

   Delete(id:any){
    if (Swal.fire({
      title: 'Are you sure?',
      text: "You won't be able to revert this!",
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
      if (result.isConfirmed) {
        Swal.fire(
          'Deleted!',
          'Your file has been deleted.',
          'success'
        )
      }
    }))
     {
      this.DeleteReservation(id).subscribe(res => {
        this.GetReservation(this.ClinicId);
        this.GetReservation(this.ClinicId).subscribe(
          (data:any)=>{
            this.Reservation=data;});
      });
    }
   }
  }

