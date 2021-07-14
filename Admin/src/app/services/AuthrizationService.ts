import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AutherizationServiceService {

constructor() { }
authUser(user:any){
  let UserArray=[];
  if(localStorage.getItem('Users')){
    UserArray=JSON.parse(localStorage.getItem('Users')!);
  }
 return UserArray.find((p:any)=>p.email===user.email && p.password===user.password);
}
authAdmin(user:any){
  let UserArray=[];
  if(localStorage.getItem('Admins')){
    UserArray=JSON.parse(localStorage.getItem('Admins')!);
  }
 return UserArray.find((p:any)=>p.email===user.email && p.password===user.password);
}

}
