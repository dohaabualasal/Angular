import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Doctor } from '../Classes/Doctor';
import { Doctors } from '../model/DoctorsInClincs';

@Injectable({
  providedIn: 'root'
})
export class DoctorsService {
  formData!: Doctor ;
  list: Doctor[]=[];
 readonly rootURL ="http://localhost:5000/api"

 constructor(private http : HttpClient) { }

  postDoctor(formData:Doctor){
  // this.http.post('http://localhost:5000/api/Doctor',formData);
  return this.http.post('http://localhost:5000/api/Doctors',formData)

 }

 refreshList(){

   return  this.http.get<Doctor>('http://localhost:5000/api/Doctors');

 }

 putDoctor(formData : Doctor) : Observable<Doctors>{
  {
   // return this.http.put(this.rootURL+'/Doctor/'+formData.Id,formData);

   const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) };
   return this.http.put<Doctors>(this.rootURL + '/Doctors/',
   formData, httpOptions);
 }

  }

  deleteDoctor(id : number){
   return this.http.delete('http://localhost:5000/api/Doctors/'+id);
  }
}


