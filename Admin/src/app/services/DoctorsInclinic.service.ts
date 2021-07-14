import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { analyzeAndValidateNgModules } from '@angular/compiler';
import { IProperty } from '../property/IProperty.Interface';
import { Observable } from 'rxjs';
import { Property } from '../model/Property';


@Injectable({
  providedIn: 'root'
})
export class DoctorsInclinicService {

constructor(private http: HttpClient) { }

GetAllDoctors (val:any):Observable<any[]>
  {

       return this.http.get<any>('http://localhost:5000/api/Clinic/GetDoctors?id='+val);
       //return this.http.post(this.APIUrl+'/Department',val);

  }
 RateDoctor(val:any):any
  {

       return this.http.get<any>('http://localhost:5000/api/Doctor/RateDoctor?id='+val);
       //return this.http.post(this.APIUrl+'/Department',val);

  }
}

