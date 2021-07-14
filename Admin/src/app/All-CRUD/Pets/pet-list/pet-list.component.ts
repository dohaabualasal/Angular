import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, NgForm } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { PetService } from 'app/services/pet.service';
import { Pet } from 'app/shared/pet.model';
import { ToastrService } from 'ngx-toastr';

import Swal from 'sweetalert2';
@Component({
  selector: 'app-pet-list',
  templateUrl: './pet-list.component.html',
  styleUrls: ['./pet-list.component.css'],
})
export class PetListComponent implements OnInit {
  toastr: any;
  public show: boolean = false;
  public buttonName: any = 'Show';
  currDiv: any;
  PetList: any = [];
  DoctorList: Array<any> = [];
  SortbyParam = '';
  SortDirection = 'asc';
  Name = '';
  SearchName = '';
  CilincId?: number;
  @Input() emp: any;
  PetId?: number;
  PhoneNumber?: string;
  @Input() hideIcons!: boolean;
  LoggedInUser: any;

  constructor(
    public service: PetService,
    private formbulider: FormBuilder,
    private rout: ActivatedRoute
  ) {}
  ngOnInit() {
    this.Loggedin()

    //this.Name = this.emp.Name;

    this.CilincId = +this.rout.snapshot.params['Id'];
    this.refreshList(this.CilincId);
  }
  populateForm(pet: Pet) {
    this.service.formData = Object.assign({}, pet);
  }
  onDelete(id: number) {
    if (confirm('Are you sure to delete this record')) {
      if (confirm('Are you sure to delete this record?')) {
        this.service.deletePet(id).subscribe((res) => {
          this.service.refreshList();
          this.toastr.warning('Deleted successfully', 'EMP. Register');
        });
      }
    }
  }

  refreshList(CilincId: number) {
    this.service.GetPetsByClinic(CilincId).subscribe((data: any) => {
      this.PetList = data;
    });
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

  onFilterClear() {
    this.SearchName = '';
    this.Name = '';
  }

  toggle(Id: any) {
    this.show = !this.show;
    if (this.show) this.buttonName = 'Hide';
    else this.buttonName = 'Show';
    this.PetId = Id;
    console.log(Id)

  }
  BookThis(form: NgForm) {

      console.log(this.PetId)
      //this.insertRecord(form);
        this.toastr.success('Inserted successfully')
        this.service.GetPetsByClinic(+this.rout.snapshot.params["Id"]).subscribe(
          (data:any)=>{
            this.service.list=data;});





    // this.PhoneNumber = this.emp.PhoneNumber.value;
    // console.log(this.PhoneNumber)
    // var val = {
    //   PetId: this.PetId,
    //   PhoneNumber: this.PhoneNumber
    // };
    // console.log(val);
    // this.service.Book(val).subscribe((res) => {
    //   Swal.fire({
    //     position: 'top-end',
    //     icon: 'success',
    //     title: 'Your work has been saved',
    //     showConfirmButton: false,
    //     timer: 1500,
    //   });
    // });


  }
  insertRecord(Id: any,Img:string) {
    if (this.LoggedInUser==null ){
      Swal.fire("Please login!","", "warning");

    }
    else{
      if (Swal.fire({
      title: 'Are you sure To Bookt this sweet pet ?',
      text: "You won't be able to Cancle this !",
      imageUrl: 'http://localhost:5000/Photos/'+Img,
      imageHeight:200,

      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: 'Yes I Want, Book it!'
    }).then((result) => {
      if (result.isConfirmed) {
        Swal.fire(
          'Booked!',

          'success'
        )
      }
    }))

  this.PetId=Id;
  var val = {
         PhoneNumber :this.LoggedInUser,
          PetId :Id
    }
    console.log(val)
      this.service.Book(val).subscribe(res => {
      this.toastr.success('Inserted successfully');

    });
    console.log(val);
    }



  }
  Loggedin(){

   ( this.LoggedInUser=localStorage.getItem('token')as string )
    return this.LoggedInUser;


  }
}
