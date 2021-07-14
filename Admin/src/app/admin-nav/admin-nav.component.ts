import { Component, OnInit } from '@angular/core';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-admin-nav',
  templateUrl: './admin-nav.component.html',
  styleUrls: ['./admin-nav.component.scss']
})
export class AdminNavComponent implements OnInit {
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
