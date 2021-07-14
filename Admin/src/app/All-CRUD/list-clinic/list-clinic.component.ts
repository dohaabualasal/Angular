import { Component, Input, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { FormBuilder } from '@angular/forms';
import Swal from 'sweetalert2';
import { ClinicServiceService } from 'app/services/ClinicService.service';
import { HousingService } from 'app/services/housing.service';
import { Clinic } from 'app/Classes/Clinic';

@Component({
  selector: 'app-list-clinic',
  templateUrl: './list-clinic.component.html',
  styleUrls: ['./list-clinic.component.css']
})
export class ListClinicComponent implements OnInit {
  @Input() ClinicList: any;



  constructor(public service: ClinicServiceService,private housingservice:HousingService,
    private toastr: ToastrService,private formbulider: FormBuilder) { }

  ngOnInit() {

    this.service.refreshList().subscribe(
      (data:any)=>{
        this.ClinicList=data;});

    this.housingservice.GetAllClinic().subscribe(
      (data:any)=>{
        this.ClinicList=data;})
  }

  populateForm(emp: Clinic) {
    this.service.formData = Object.assign({}, emp);
  }

  onDelete(id: number) {
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
      this.service.deleteClinic(id).subscribe(res => {
        this.service.refreshList();
        this.toastr.warning('Deleted successfully', );
        this.service.refreshList().subscribe(
          (data:any)=>{
            this.ClinicList=data;});
      });
    }
  }


}
