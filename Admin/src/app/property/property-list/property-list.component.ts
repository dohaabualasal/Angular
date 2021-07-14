import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Property } from 'app/model/Property';
import Swal from 'sweetalert2';
import { HousingService } from '../../services/housing.service';
import { IProperty } from '../IProperty.Interface';
@Component({
  selector: 'app-property-list',
  templateUrl: './property-list.component.html',
  styleUrls: ['./property-list.component.css']
})
export class PropertyListComponent implements OnInit {
  properties:Array<IProperty>=[];
  Location="Irbid";
  City = '';
  SearchCity = '';
  SortbyParam = '';
  SortDirection = 'asc';
  //ClinicList: Array<IProperty>=[];
  Property = new Property();
  @Input() hideIcons!: boolean;
  @Input() ClinicList: any;

 constructor(private route:ActivatedRoute,private housingservice:HousingService) {
 }

  ngOnInit():void {


    if(this.route.snapshot.url.toString()){
      this.Location="Irbid";

    }

    this.housingservice.GetAllClinic().subscribe(
      (data:any)=>{
        
        this.ClinicList=data;
       /* this.Property.Name = data.Name;
        this.Property.Email = data.email;
        this.Property.Phone = data.Phone;
        this.Property.Country = data.Country;
        this.Property.City = data.City;
        this.Property.Street = data.Street;
        this.Property.Building = data.Building;
        this.Property.PartmentNum = data.PartmentNum;
             */


      /*  const newProperty= JSON.parse(localStorage.getItem('newProp')as any)
        if (newProperty){
          this.properties=[newProperty, ...this.properties]
        }*/

      },

          );
      }



      onCityFilter() {
        this.SearchCity = this.City;
      }

      onCityFilterClear() {
        this.SearchCity = '';
        this.City = '';
      }

      onSortDirection() {
        if (this.SortDirection === 'desc') {
          this.SortDirection = 'asc';
        } else {
          this.SortDirection = 'desc';
        }
      }
    
}


