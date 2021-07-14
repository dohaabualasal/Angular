import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { scedual } from '../Classes/scedual';

@Injectable({
  providedIn: 'root'
})
export class ScedualService {
  formData!: scedual ;
  list: scedual[]=[];
 readonly rootURL ="http://localhost:5000//api/Doctor/Scehdual"

 constructor(private http : HttpClient) { }

  postScedual(formData : scedual){
  // this.http.post('http://localhost:5000/api/Doctor',formData);
  return this.http.post('http://localhost:5000/api/Doctor/Scehdual',formData)

 }

 refreshList(){

   return  this.http.get<scedual>(this.rootURL);

 }

}


