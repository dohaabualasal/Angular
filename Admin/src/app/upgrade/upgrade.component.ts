import { Component, Input, OnInit } from '@angular/core';
import { HousingService } from 'app/services/housing.service';

@Component({
  selector: 'app-upgrade',
  templateUrl: './upgrade.component.html',
  styleUrls: ['./upgrade.component.css']
})
export class UpgradeComponent implements OnInit {
  @Input() ClinicList: any;
  constructor(private housingservice:HousingService) { }

  ngOnInit() {
    this.housingservice.GetAllClinic().subscribe(
      (data:any)=>{
        
        this.ClinicList=data;
  })}

}
