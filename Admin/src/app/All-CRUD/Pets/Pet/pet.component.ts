import { Component, Input, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import * as _ from 'lodash';

import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import Swal from 'sweetalert2';
import { PetService } from 'app/services/pet.service';

@Component({
  selector: 'app-pet',
  templateUrl: './pet.component.html',
  styleUrls: ['./pet.component.css']
})
export class PetComponent implements OnInit {
  Categories: any = [];
  @Input() emp: any;
  mySelect = '2';
  selectedValue: any;

  Id?: number;
  Name?: string;
  Age?: string;
  Gender?: string;
  Image?: string;
  ClinicId?: number;
  Category?: string;
  Biography?: string;
  Price?:number;

  //PhotoFileName:string;
  PhotoFilePath?:string;

  propertyView: any={

  Name:'',
  Age:'',
  Gender:'',
  Image: '',
  Price :0,
  Category:'',
  Biography:'',
  //PhotoFileName:string;


  }
  constructor(public service: PetService, private rout :ActivatedRoute,private router :Router,
    public toastr: ToastrService) { }
  ngOnInit() {
    this.loadCategory();
    //this.resetForm();
  }
  loadCategory() {
    this.service.Category().subscribe((data: any) => {
      this.Categories = data;
      this.Category = this.emp.Categories;
      this.Id = this.emp.Id;
      this.Name=this.emp.Name;
      this.Age=this.emp.Age;
      this.Gender = this.emp.Gender;
      this.Price=this.emp.Price ;
      this.ClinicId=+this.rout.snapshot.params['Id'];
      this.Image=this.emp.Image;
      this.PhotoFilePath=this.service.PhotoUrl+this.Image;
      this.Biography = this.emp.Biography;
    });
  }

  addPet(){
    var val = {
              //Id:this.Id,
              Name:this.Name,
              Category:this.Categories,
              Age:this.Age,
              Price:this.Price,
              Gender:this.Gender,
              ClinicId:+this.rout.snapshot.params['Id'],
              Biography:this.Biography,
              Image:this.Image
          }

    this.service.postPet(val).subscribe(res=>{
      Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Your work has been saved',
        showConfirmButton: false,
        timer: 1500
      })
      this.router.navigate(['/']);


    });

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

getDropDownText(id:any, object:any){
  const selObj = _.filter(object, function (o) {
      return (_.includes(id,o.id));
  });
  return selObj;
}
}
