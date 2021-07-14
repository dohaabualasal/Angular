import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Doctor } from 'app/Classes/Doctor';
import { DoctorsService } from 'app/services/Doctors.service';
import { DoctorsInclinicService } from 'app/services/DoctorsInclinic.service';
//import { inputs } from '@syncfusion/ej2-angular-schedule/src/schedule/schedule.component';
import { ToastContainerDirective, ToastrService } from 'ngx-toastr';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-Add-Edit-Doctors',
  templateUrl: './Add-Edit-Doctors.component.html',
  styleUrls: ['./Add-Edit-Doctors.component.css']
})
export class AddEditDoctorsComponent implements OnInit {
  clinicId?: number;
  @ViewChild(ToastContainerDirective, { static: true })
  toastContainer!: ToastContainerDirective;
  @Input() DoctorList: any;
  @Input() doc:any;
  constructor(private doctorsClinic:DoctorsInclinicService, private route :ActivatedRoute,
     private router :Router,
    public Doctorservice:DoctorsService,private ToastrService: ToastrService,private fb: FormBuilder) {}

  ngOnInit() {
    this.ToastrService.overlayContainer = this.toastContainer;
    this.resetForm();
    this.clinicId=+this.route.snapshot.params['id'];
    this.Doctorservice.formData.ClinicId=this.clinicId;
    this.doctorsClinic.GetAllDoctors(this.clinicId).subscribe(
      (data:any)=>{
        this.DoctorList=data;});
        console.log(this.DoctorList)

    }
  resetForm(form?: NgForm) {
    if (form != null) form.resetForm();
    this.Doctorservice.formData = {

    Name  : '',
    Email  : '',
    Phone  : '',
    Password:'',
    ClinicId:this.clinicId


    };
  }






  onSubmit(form: NgForm) {
    if (form.value.Id == null)


    {
      this.insertRecord(form);
      console.log(form);
    }
    else
      this.updateRecord(form);
  }
  insertRecord(form: NgForm) {

    this.Doctorservice.postDoctor(form.value).subscribe(res => {

      this.resetForm(form);
      this.Doctorservice.refreshList();
       this.Doctorservice.refreshList().subscribe(
        (data:any)=>{
          this.Doctorservice.list=data;});
    });
  }
  // insertRecord(form: NgForm) {
  //   this.Doctorservice.postDoctor(form.value).subscribe(res => {
  //     Swal.fire({
  //       position: 'top-end',
  //       icon: 'success',
  //       title: 'Your work has been saved',
  //       showConfirmButton: false,
  //       timer: 1500
  //     })
  //     this.resetForm(form);
  //     this.doctorsClinic.GetAllDoctors(this.clinicId).subscribe(
  //       (data:any)=>{
  //         this.DoctorList=data;});

  //   });
  // }

  updateRecord(form: NgForm) {
    this.Doctorservice.putDoctor(form.value).subscribe(res => {
      this.ToastrService.info('Updated successfully', 'EMP. Register');
      this.resetForm(form);
      this.doctorsClinic.GetAllDoctors(this.clinicId).subscribe(
        (data:any)=>{
          this.DoctorList=data;});
    });

  }
  populateForm(emp: Doctor) {
    this.Doctorservice.formData = Object.assign({}, emp);
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
    })) {
      this.Doctorservice.deleteDoctor(id).subscribe(res => {
        this.Doctorservice.refreshList();

      this.doctorsClinic.GetAllDoctors(this.clinicId).subscribe(
        (data:any)=>{
          this.DoctorList=data;});
      });
    }
  }


}


