import { Component, OnInit } from '@angular/core';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {
LoggedInUser:string='';
  constructor() { }

  ngOnInit() {
  }
  Loggedin(){
    this.LoggedInUser=localStorage.getItem('token')as string;
    return this.LoggedInUser;


  }
  onLogout(){
    localStorage.removeItem('token');
    Swal.fire('You are logged out');



  }

}
