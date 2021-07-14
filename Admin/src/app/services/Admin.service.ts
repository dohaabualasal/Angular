import { Injectable } from '@angular/core';
import { Admin } from 'app/model/Admin';

@Injectable({
  providedIn: 'root'
})
export class AdminService {

  addUser(user: Admin) {
    let Admins = [];
    if (localStorage.getItem('Admins')) {
  
      Admins = JSON.parse(localStorage.getItem('Admins')!);
      Admins = [user,...Admins];
      console.log(Admins)
    }
    else
    {
      Admins = [user];
    }
    localStorage.setItem('Admins', JSON.stringify(Admins));
    Admins.push(user);
    console.log(Admins);
  }}