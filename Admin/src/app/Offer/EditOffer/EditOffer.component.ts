import { Component, Input, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Offer } from 'app/model/Offer';
import { OfferService } from 'app/services/Offer.service';
import * as _ from 'lodash';
import { ToastrService } from 'ngx-toastr';

import Swal from 'sweetalert2';
@Component({
  selector: 'app-EditOffer',
  templateUrl: './EditOffer.component.html',
  styleUrls: ['./EditOffer.component.css']
})
export class EditOfferComponent implements OnInit {
  Categories: any = [];
  @Input() emp: any;
  mySelect = '2';
  selectedValue: any;

  OfferId ?:number;
  Name ?:string;
  Image ?:string;
  OldPrice ?:number;
  NewPrice ?:number;
  DateFrom ?:number;
  DateTo ?:Date;
  CategoryType ?:Date;

  //PhotoFileName:string;
  PhotoFilePath?:string;
  OfferList: any = [];

  propertyView: any={

    OfferId :'',
    Name :'',
    Image :'assets/img/pets.jpg',
    OldPrice :0.0,
    NewPrice :0.0,
    DateFrom :'1-1-2001',
    DateTo :'1-1-2001',
    CategoryType:''
  //PhotoFileName:string;


  }

  ToastrService: any;
  constructor(public service: OfferService, private rout :ActivatedRoute,private router :Router,
    public toastr: ToastrService) { }
  ngOnInit() {
    this.loadCategory();
    this.refreshList();
    //this.resetForm();
  }
  loadCategory() {
    this.service.Category().subscribe((data: any) => {
      this.Categories = data;
      this.CategoryType = this.emp.Categories;
      this.OfferId = this.emp.Id;
      this.Name=this.emp.Name;
      this.OldPrice=this.emp.OldPrice;
      this.NewPrice = this.emp.NewPrice;
      this.DateFrom=this.emp.DateFrom ;
      this.DateTo=this.emp.DateTo;
      this.Image=this.emp.Image;
      this.PhotoFilePath=this.service.PhotoUrl+this.Image;
    });
  }
  refreshList() {
    this.service.GetOfferByClinic().subscribe((data: any) => {
      this.OfferList = data;
    });
  }

  addOffer(){
    var val = {
      CategoryType : this.CategoryType,
      OfferId : this.OfferId,
      Name:this.Name,
     OldPrice:this.OldPrice,
      NewPrice : this.NewPrice,
      DateFrom:this.DateFrom ,
      DateTo:this.DateTo,
       Image:this.Image


          }

    this.service.postOffer(val).subscribe(res=>{
      Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Your work has been saved',
        showConfirmButton: false,
        timer: 1500
      })
      this.router.navigate(['/Offer-list/'+this.rout.snapshot.params['Id']]);


    });

  }




  // resetForm(form : NgForm)
  // {
  //       form.resetForm();
  //       if(form!= null)
  //   this.service.formData =
  //   {
  //     Id: 0,
  //     Name: '',
  //     Age: '',
  //     //Image:'',
  //     Gender: '',
  //     Clinicid: 0
  //   }
  // }
  // onSubmit(form: NgForm) {

  //   this.updateRecord(form);
  // }
  // insertRecord(form: NgForm) {
  //   this.service.postOffer(form.value).subscribe(res => {
  //     this.toastr.success('Inserted successfuly', 'Offer.Register');
  //     this.resetForm(form)
  //     this.service.refreshList();
  //   });
  // }
  // updateRecord(form: NgForm) {
  //   this.service.putOffer(form.value).subscribe(res => {
  //     this.toastr.warning('Update successfuly', 'Offer.Register');
  //     this.resetForm(form)
  //     this.service.refreshList();
  //   });
  // }
  populateForm(emp: Offer) {
    this.OfferList = Object.assign({}, emp);

   }
  // updateRecord(form: NgForm) {
  //   //this.OfferList = Object.assign({}, emp);
  //   this.updateRecord(form);
  //   this.service.postOffer(form.value).subscribe(res => {
  //     this.ToastrService.info('Updated successfully', 'EMP. Register');
  //     this.service.GetOfferByClinic().subscribe(
  //       (data:any)=>{
  //         this.OfferList=data;});
  //   });}
  update(){
    var val = {
      OfferId:this.OfferId,
      CategoryType : this.CategoryType,

      Name:this.Name,
     OldPrice:this.OldPrice,
      NewPrice : this.NewPrice,
      DateFrom:this.DateFrom ,
      DateTo:this.DateTo,
       Image:this.Image}

    this.service.putOffer(val).subscribe(res=>{
    alert(res.toString());
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
    this.service.deleteOffer(id).subscribe(res => {
      this.service.refreshList();
      this.ToastrService.warning('Deleted successfully');

    this.service.GetOfferByClinic().subscribe(
      (data:any)=>{
        this.OfferList=data;});
    });
  }
}
}
