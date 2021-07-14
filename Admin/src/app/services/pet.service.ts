import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders}from "@angular/common/http";
import { Observable } from 'rxjs';
import { Pet } from '../shared/pet.model';
import { BookPet } from '../Classes/BookPet';
@Injectable({
  providedIn: 'root'
})
export class PetService {
  formData!: Pet;
  list: Pet []=[];
  PetList:any=[];
  form!: BookPet;


  readonly rootURL="http://localhost:5000/api"
  readonly PhotoUrl = "http://localhost:5000/Photos/";

  refresh(CilincId:number){
    this.GetPetsByClinic(CilincId).subscribe((data: any)=>{
      this.PetList=data;
    });}
  constructor(private http:HttpClient) { }

  postPet(val:any)
  {
    return this.http.post('http://localhost:5000/api/Pets',val);
  }
  Book(val:any)
  {
    return this.http.post('http://localhost:5000/api/Pets/Book',val);
  }
  getList():Observable<any[]>{
    return this.http.get<any>(this.rootURL+'/Pets');
  }
  refreshList(): Observable<Pet>{
    return  this.http.get<Pet>('http://localhost:5000/api/Pets');
  }
  Category(): Observable<any>{
    return  this.http.get<any>('http://localhost:5000/api/Offer/GetAllCategoryName');
  }
  putPet(formData : Pet) : Observable<Pet>{
   // return this.http.put(this.rootURL+'/Clinic/'+formData.Id,formData);
   {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) };
    return this.http.put<Pet>(this.rootURL + '/Pets/',
    formData, httpOptions);
  }
   }
   deletePet(id : number){
    return this.http.delete(this.rootURL+'/Pets/'+id);
   }
   UploadPhoto(val:any){
    return this.http.post(this.rootURL+'/Pets/SaveFile',val);
  }
  GetPetsByClinic (val:any):Observable<any[]>
  {

       return this.http.get<any>('http://localhost:5000/api/Pets/GetPetsByClinic?id='+val);
       //return this.http.post(this.APIUrl+'/Department',val);

  }

}
