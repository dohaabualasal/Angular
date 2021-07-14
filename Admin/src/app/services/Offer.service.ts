import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Offer } from '../model/Offer';

@Injectable({
  providedIn: 'root'
})
export class OfferService {
  formData!:Offer;
 list:Offer[]=[];
 OfferList:any=[];


  readonly rootURL="http://localhost:5000/api"
  readonly PhotoUrl = "http://localhost:5000/Photos/";

 /* refresh(CilincId:number){
    this.GetOfferByClinic(CilincId).subscribe((data: any)=>{
      this.OfferList=data;
    });}*/
  constructor(private http:HttpClient) { }

  postOffer(val:any)
  {
    return this.http.post('http://localhost:5000/api/Offer',val);
  }
  Book(val:any)
  {
    return this.http.post('http://localhost:5000/api/Pets/Book',val);
  }
  getList():Observable<any[]>{
    return this.http.get<any>(this.rootURL+'/Offer');
  }
  refreshList(): Observable<Offer>{
    return  this.http.get<Offer>('http://localhost:5000/api/Offer');
  }
  Category(): Observable<any>{
    return  this.http.get<any>('http://localhost:5000/api/Offer/GetAllCategoryName');
  }
  putOffer(formData :Offer) : Observable<Offer>{
   // return this.http.put(this.rootURL+'/Clinic/'+formData.Id,formData);
   {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) };
    return this.http.put<Offer>(this.rootURL + '/Offer/',
    formData, httpOptions);
  }
   }
   deleteOffer(id : number){
    return this.http.delete(this.rootURL+'/Offer/'+id);
   }
   UploadPhoto(val:any){
    return this.http.post(this.rootURL+'/Offer/SaveFile',val);
  }
  GetOfferByClinic ():Observable<any[]>
  {

       return this.http.get<any>('http://localhost:5000/api/Offer');
       //return this.http.post(this.APIUrl+'/Department',val);

  }

}
