import { isNull } from '@angular/compiler/src/output/output_ast';
import { Component, Input, OnInit } from '@angular/core';
import { HousingService } from 'app/services/housing.service';
import { isUndefined } from 'ngx-bootstrap/chronos/utils/type-checks';
import { IProperty } from '../IProperty.Interface';

@Component({
  selector: 'app-property-card',
  templateUrl: './property-card.component.html',
  styleUrls: ['./property-card.component.css']
})
export class PropertyCardComponent implements OnInit {
  @Input() hideIcons!: boolean;
  @Input() ClinicList: any;

  /*@Input()  property: IProperty ={

   Id:100,
    Name:'',
    Email:'',
    City: '',
    Image:'clinic'

  };*/


	constructor(private housing :HousingService) {

	}



  ngOnInit() {
  }

}
