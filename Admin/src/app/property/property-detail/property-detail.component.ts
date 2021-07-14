import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import {
  NgxGalleryAnimation,
  NgxGalleryImage,
  NgxGalleryOptions,
} from '@kolkov/ngx-gallery';
import { map } from 'rxjs/operators';

import { HttpClient, HttpClientModule } from '@angular/common/http';
import { NgxGalleryModule } from '@kolkov/ngx-gallery';

import Swal from 'sweetalert2';
import { Property } from 'app/model/Property';
import { Doctors } from 'app/model/DoctorsInClincs';
import { DoctorsInclinicService } from 'app/services/DoctorsInclinic.service';
import { HousingService } from 'app/services/housing.service';
import { PetService } from 'app/services/pet.service';
import { Observable } from 'rxjs';
@Component({
  selector: 'app-property-detail',
  templateUrl: './property-detail.component.html',
  styleUrls: ['./property-detail.component.css'],
})
export class PropertyDetailComponent implements OnInit {
  public propertyId = 0;
  galleryOptions!: NgxGalleryOptions[];
  galleryImages!: NgxGalleryImage[];
  Property = new Property();
  Doctor = new Doctors();
  DoctorList: Array<any> = [];
  SortbyParam = '';
  SortDirection = 'asc';
  Name = '';
  SearchName = '';

  property: Array<any> = [];
  isReadonly = true;

  constructor(
    private route: ActivatedRoute,
    private http: HttpClient,
    private router: Router,
    private housingService: HousingService,
    private doctor: DoctorsInclinicService,
    public service: PetService
  ) {}

  ngOnInit(): void {
    this.getclinicinfo(+this.route.snapshot.params['Id']).subscribe(
      (data: any) => {
        this.Property = data;
  })

    this.galleryOptions = [
      {
        width: '600px',
        height: '400px',
        thumbnailsColumns: 4,
        imageAnimation: NgxGalleryAnimation.Slide,
      },
      // max-width 800
      {
        breakpoint: 800,
        width: '100%',
        height: '600px',
        imagePercent: 80,
        thumbnailsPercent: 20,
        thumbnailsMargin: 20,
        thumbnailMargin: 20,
      },
      // max-width 400
      {
        breakpoint: 400,
        preview: false,
      },
    ];

    this.galleryImages = [
      {
        small: 'assets/ssssssssssssssss.jpg',
        medium: 'assets/ssssssssssssssss.jpg',
        big: 'assets/ssssssssssssssss.jpg',
      },
      {
        small: 'assets/aaa.jpg',
        medium: 'assets/aaa.jpg',
        big: 'assets/aaa.jpg',
      },
      {
        small: 'assets/aa.jpg',
        medium: 'assets/aa.jpg',
        big: 'assets/aa.jpg',
      },
      {
        small: 'assets/aaaaa.jpg',
        medium: 'assets/aaaaa.jpg',
        big: 'assets/aaaaa.jpg',
      },
      {
        small: 'assets/g1.jpg',
        medium: 'assets/g1.jpg',
        big: 'assets/g1.jpg',
      },
    ];

    this.propertyId = +this.route.snapshot.params['Id'];

    /* this.route.data.subscribe(
      (data:Property)=>
      {
        this.property=data['prp'];
      }
    )*/

    this.route.params.subscribe((params) => {
      this.propertyId = params['Id'];
      this.housingService.getProperty(this.propertyId).subscribe(
        (data: any) => {
          this.Property.Name = data.Name;
          this.Property.email = data.email;
          this.Property.Phone = data.Phone;
          this.Property.Country = data.Country;
          this.Property.City = data.City;
          this.Property.Street = data.Street;
          this.Property.Building = data.Building;
          this.Property.PartmentNum = data.PartmentNum;
          this.Property.Image = data.Image;

        } // error=> this.router.navigate(['/'])
      );
    });
    this.route.params.subscribe((params) => {
      this.propertyId = +params['Id'];
      this.doctor.GetAllDoctors(this.propertyId).subscribe(
        (data: any) => {
          this.Doctor.Name = data.Name;
          this.Doctor.Email = data.Email;
          this.Doctor.phone = data.Phone;
          this.Doctor.RateNumber = data.RateNumber;
          this.Doctor.Id = data.Id;
        } // error=> this.router.navigate(['/'])
      );
    });
    this.doctor.GetAllDoctors(this.propertyId).subscribe((data) => {
      this.DoctorList = data;
      console.log(this.DoctorList);
    });


  }
  getclinicinfo(val: any): Observable<any[]> {


    return this.http.get<any>('http://localhost:5000/api/Clinic/ClinicInfo?id=' + val);

  }

  /*  onSelectNext(){
    this.propertyId+=1;
    this.router.navigate(['property-detail',this.propertyId])
  }
*/
  getItem() {
    this.housingService.getProperty(this.propertyId);
    return this.doctor.GetAllDoctors(this.propertyId);
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
  RateReservation(val: number) {
    return this.http.get('http://localhost:5000/api/Clinic/RateDoctor?id=' + val);
   }

   rate(id: any) {
    if (Swal.fire({
      position: 'top-end',
      icon: 'success',
      title: 'Your work has been saved',
      showConfirmButton: false,
      timer: 1500
    })) {
      this.RateReservation(id).subscribe(res => {
        this.doctor.GetAllDoctors(this.propertyId);
        this.doctor.GetAllDoctors(this.propertyId).subscribe(
          (data: any) => {
            this.DoctorList = data; });
      });
    }
   }
  }
