/*import { Component, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { TabsetComponent } from 'ngx-bootstrap/tabs/public_api';
import { IProperty } from '../IProperty.Interface';
import Swal, { SweetAlertArrayOptions } from 'sweetalert2';
import { Clinic } from 'app/Classes/Clinic';
import { ClinicServiceService } from 'app/services/ClinicService.service';
import { HousingService } from 'app/services/housing.service';
import { Property } from 'app/model/Property';

@Component({
  selector: 'app-add-property',
  templateUrl: './add-property.component.html',
  styleUrls: ['./add-property.component.css']
})
export class AddPropertyComponent implements OnInit {
 //@ViewChild('Form') addPropertyForm!: FormGroup;
  //@ViewChild('Form') addPropertyForm!: FormGroup;
  //@ViewChild('Form') addPropertyForm!: FormGroup;
  //@ViewChild('Form') addPropertyForm!: FormGroup;
  @ViewChild('formTabs', { static: false })
  formTabs!: TabsetComponent;
  addPropertyForm!: FormGroup;
  property = new Clinic();




  propertyView: Clinic = {
    Id:0,
    Name  : '',
    Email  : '',
    Phone  : '',
    //adminId  : 3,
    Country  : '',
    City  : '',
    Street  : '',
    Building  : '',
    PartmentNum  : '',
    Image  : 'clinic.jpg',
  };


  constructor(private fb :FormBuilder,private service:ClinicServiceService,private router: Router,private housingService:HousingService) { }

  ngOnInit() {
    this.CreateAddPropertyForm();
    //this.housingService.GetAllClinic().subscribe(data=>(
      //console.log(data)

  //  ))
  }
  CreateAddPropertyForm() {
    this.addPropertyForm = this.fb.group({
      BasicInfo: this.fb.group({

        Email: [null, Validators.required,Validators.email],
         Name: [ null , Validators.required ],
        Phone: [null, Validators.required,Validators.minLength(0),Validators.maxLength(10)],

      }),

      AddressInfo: this.fb.group({
        Country: [null, Validators.required],
        City: [null, Validators.required],
        Street: [null],
        Building: [null],
        PartmentNum: [null]
      })});
    }
    get BasicInfo() {
      return this.addPropertyForm.controls.BasicInfo as FormGroup;
    }



    get AddressInfo() {
      return this.addPropertyForm.controls.AddressInfo as FormGroup;
    }

    get Name() {
      return this.BasicInfo.controls.Name as FormControl;
    }

    get Email() {
      return this.BasicInfo.controls.Email as FormControl;
    }

    get Phone() {
      return this.BasicInfo.controls.Phone as FormControl;
    }

    get Country() {
      return this.AddressInfo.controls.Country as FormControl;
    }

    get City() {
      return this.AddressInfo.controls.City as FormControl;
    }

    get Street() {
      return this.AddressInfo.controls.Street as FormControl;
    }

    get Building() {
      return this.AddressInfo.controls.Building as FormControl;
    }

    get PartmentNum() {
      return this.AddressInfo.controls.PartmentNum as FormControl;
    }


  onBack() {
    this.router.navigate(['/']);
  }

  onSubmit() {

    console.log(Property);
    this.mapProperty();
    this.service.postClinic(this.property);
    Swal.fire("success");
    console.log(this.addPropertyForm)
    console.log('Congrats, form Submitted');
    console.log('SellRent=' + this.addPropertyForm.value.Name);
  }
  mapProperty(): void {
    //this.property.id =+this.housingService.newPropID();
    this.property.Name = this.Name.value;
    this.property.Email = this.Email.value;
    this.property.Phone = this.Phone.value;
    this.property.Country = this.Country.value;
    this.property.City = this.City.value;
    this.property.Street = this.Street.value;
    this.property.Building = this.Building.value;
    this.property.PartmentNum =this.PartmentNum.value;}

 selectTab(tabId: any) {
    this.formTabs.tabs[tabId].active = true;
  }
}
*/