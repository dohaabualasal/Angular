import { Component, Input, OnInit } from '@angular/core';

import {
  FormBuilder,
  FormControl,
  FormGroup,
  NgForm,
  Validators,
} from '@angular/forms';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';
import { HttpClient } from '@angular/common/http';
import * as _ from 'lodash';
import { Clinic } from 'app/Classes/Clinic';
import { ClinicServiceService } from 'app/services/ClinicService.service';
@Component({
  selector: 'app-Clinic',
  templateUrl: './Clinic.component.html',
  styleUrls: ['./Clinic.component.css'],
})
export class ClinicComponent implements OnInit {
  Categories: any = [];
  PhotoFilePath?: string;
  //Id?: number;
  Name?: string;
  Phone?: string;
  Email?: string;
  Country?: string;
  City?: string;
  Street?: string;
  Building?: string;
  PartmentNum?: string;
  Image?: string;

  Cities: Array<string> = [
    'Irbid',
    'Amman',
    'Aqaba',
    'Jeresh',
    'Mada',
    'Alzarqaa',
    'Alkarak',
    'Almafraq',
    'Ajloon',
    'Alsalt',
  ];
  propertyView: Clinic = {
    Id: 0,
    Name: '',
    Email: '',
    Phone: '',
    //adminId  : 3,
    Country: '',
    City: '',
    Street: '',
    Building: '',
    PartmentNum: '',
    Image: '',
  };
  @Input() emp: any;
  selectedValue: any;
  constructor(
    public service: ClinicServiceService,
    private router: Router,
    private toastr: ToastrService,
    private fb: FormBuilder,
    private httpClient: HttpClient
  ) {}

  ngOnInit() {
    this.Email = this.emp.Email;
   // this.Id = this.emp.Id;
    this.Name = this.emp.Name;
    this.Phone = this.emp.Phone;
    this.Country = this.emp.Country;
    this.City = this.emp.City;
    this.Street = this.emp.Street;
    this.Building = this.emp.Building;
    this.PartmentNum = this.emp.PartmentNum;
    this.Image = this.emp.Image;
    this.PhotoFilePath = this.service.PhotoUrl + this.Image;

    // this.resetForm();
  }
  addClinic() {
    var val = {

    Name:this.Name,
    Email:this.Email,
    Phone:this.Phone,
    //adminId  : 3,
    Country:this.Country,
    City:this.City,
    Street:this.Street,
    Building:this.Building,
    PartmentNum:this.PartmentNum,
    Image:this.Image,

    };
    this.service.postClinic(val).subscribe((res) => {
      Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Your work has been saved',
        showConfirmButton: false,
        timer: 1500

      })
      this.service.refreshList();
      this.router.navigate(['/']);
    });
  }

  resetForm(form?: NgForm) {
    if (form != null) form.resetForm();
    this.service.formData = {
      Name: '',
      Email: '',
      Phone: '',

      Country: '',
      City: '',
      Street: '',
      Building: '',
      PartmentNum: '',
      Image: 'assets/images/clinic.jpg',
    };
  }
  uploadPhoto(event:any){
    var file=event.target.files[0];
    const formData:FormData=new FormData();
    formData.append('uploadedFile',file,file.name);

    this.service.UploadPhoto(formData).subscribe((data:any)=>{
      this.Image=data.toString();
      this.PhotoFilePath=this.service.PhotoUrl+this.Image;
    })
  }
  selectChange() {
    this.selectedValue = this.getDropDownText(this.mySelect, this.Categories)[0].name;
}
  mySelect(mySelect: any, Categories: any) {
    throw new Error('Method not implemented.');
  }

getDropDownText(id:any, object:any){
  const selObj = _.filter(object, function (o) {
      return (_.includes(id,o.id));
  });
  return selObj;
}
}
