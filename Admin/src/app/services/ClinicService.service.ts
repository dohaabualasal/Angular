import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable, Input } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Clinic } from '../Classes/Clinic';

@Injectable({
  providedIn: 'root'
})
export class ClinicServiceService {
  formData!: Clinic ;
   list: Clinic []=[];
  readonly rootURL ="http://localhost:5000/api"
  readonly PhotoUrl = "http://localhost:5000/Photos/";
 //readonly PhotoUrl = "assets/images/";


  constructor(private http : HttpClient) { }

 postClinic(val:any){
   return this.http.post('http://localhost:5000/api/Clinic',val)


  }

  refreshList(): Observable<Clinic>{

    return  this.http.get<Clinic>('http://localhost:5000/api/Clinic');

  }

  putClinic(formData : Clinic) : Observable<Clinic>{
   // return this.http.put(this.rootURL+'/Clinic/'+formData.Id,formData);
   {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) };
    return this.http.put<Clinic>(this.rootURL + '/Clinic/',
    formData, httpOptions);
  }

   }

   deleteClinic(id : number){
    return this.http.delete(this.rootURL+'/Clinic/'+id);
   }

   UploadPhoto(val:any){
    return this.http.post(this.rootURL+'/Clinic/SaveFile',val);
  }

}


