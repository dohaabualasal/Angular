import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { scedual } from 'app/Classes/scedual';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-Scedual',
  templateUrl: './Scedual.component.html',
  styleUrls: ['./Scedual.component.css']
})
export class ScedualComponent implements OnInit {
  formData: scedual={
  DoctorId:+this.route.snapshot.params['Id'],



  } ;
  DoctorId?:number;
  @Input() DoctorList: any;
  constructor(private http : HttpClient,private route :ActivatedRoute, private router: Router,) { }

  ngOnInit() {

    this.DoctorId=+this.route.snapshot.params['Id'];
    this.formData.DoctorId=this.DoctorId;



  }

  postScedual(form : scedual){
     console.log(form)

    // this.http.post('http://localhost:5000/api/Doctor',formData);
    return this.http.post('http://localhost:5000/api/Clinic/Scehdual',form)

   }

   insertRecord(form: NgForm) {
    this.formData.DoctorId=this.DoctorId;
    this.postScedual(form.value).subscribe(res => {
      Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Your work has been saved',
        showConfirmButton: false,
        timer: 1500
      })
      this.router.navigate(['/home']);


    });
  }


}
