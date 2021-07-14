import { Injectable } from '@angular/core';
import { User } from '../model/User';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

constructor() { }
addUser(user: User) {
  let Users = [];
  if (localStorage.getItem('Users')) {

    Users = JSON.parse(localStorage.getItem('Users')!);
    Users = [user,...Users];
    console.log(Users)
  }
  else
  {
    Users = [user];
  }
  localStorage.setItem('Users', JSON.stringify(Users));
  Users.push(user);
  console.log(Users);
}

}

