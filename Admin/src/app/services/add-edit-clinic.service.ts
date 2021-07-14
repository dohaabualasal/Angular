import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AddEditClinicService {

constructor(private http:HttpClient) { }
readonly APIUrl="http:/localhost:5000/api";
readonly PhotoUrl = "http:/localhost:5000/Photos/";

addClinic(val:any){
  return this.http.post(this.APIUrl+'/Clinic',val);
}

updateClinic(val:any){
  return this.http.put(this.APIUrl+'/Clinic',val);
}

deleteClinic(val:any){
  return this.http.delete(this.APIUrl+'/Clinic/'+val);
}
UploadPhoto(val:any){
  return this.http.post(this.APIUrl+'/Clinic/SaveFile',val);
}
}
