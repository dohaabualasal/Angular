import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, NgForm } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { OfferService } from 'app/services/Offer.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-list-offer',
  templateUrl: './list-offer.component.html',
  styleUrls: ['./list-offer.component.css']
})
export class ListOfferComponent implements OnInit {
  toastr: any;
  public show: boolean = false;
  public buttonName: any = 'Show';
  currDiv: any;
  LoggedInUser:string='';

  OfferList: any = [];
  DoctorList: Array<any> = [];
  SortbyParam = '';
  SortDirection = 'asc';
  Name = '';
  SearchName = '';
  CilincId?: number;
  @Input() emp: any;
  OfferId?: number;
  PhoneNumber?: string;
  @Input() hideIcons!: boolean;
  PetId: any;

  constructor(
    public service: OfferService,
    private formbulider: FormBuilder,
    private rout: ActivatedRoute
  ) {}
  ngOnInit() {
    this.Loggedin()
    //this.Name = this.emp.Name;

    this.CilincId = +this.rout.snapshot.params['Id'];
    this.refreshList();
  }
  /*populateForm(Offer: Offer) {
    this.service.formData = Object.assign({}, Offer);
  }*/
  onDelete(id: number) {
    if (confirm('Are you sure to delete this record')) {
      if (confirm('Are you sure to delete this record?')) {
        this.service.deleteOffer(id).subscribe((res) => {
          this.service.refreshList();
          this.toastr.warning('Deleted successfully', 'EMP. Register');
        });
      }
    }
  }

  refreshList() {
    this.service.GetOfferByClinic().subscribe((data: any) => {
      this.OfferList = data;
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
    this.OfferId=Id;

    this.show = !this.show;
    if (this.show) this.buttonName = 'Hide';
    else this.buttonName = 'Show';
    this.OfferId = Id;
    console.log(Id)

  }
  BookThis(form: NgForm) {

     // this.insertRecord(form);
      this.toastr.success('Inserted successfully')
       this.service.GetOfferByClinic().subscribe(
          (data:any)=>{
            this.service.list=data;});







  }
  insertRecord(Id:any, Img:string)
  {
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
    console.log(val);}

  }
  Loggedin(){
    this.LoggedInUser=localStorage.getItem('token')as string;
    return this.LoggedInUser;

  }
}
