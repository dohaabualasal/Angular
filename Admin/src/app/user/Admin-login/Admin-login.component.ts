import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from 'angular-routing';
import { AutherizationServiceService } from 'app/services/AuthrizationService';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-Admin-login',
  templateUrl: './Admin-login.component.html',
  styleUrls: ['./Admin-login.component.scss']
})
export class AdminLoginComponent implements OnInit {

  constructor(private authService: AutherizationServiceService,private router:Router) { }

  ngOnInit() {
  }



onLogin(loginForm:NgForm){
  console.log(loginForm.value);
  const user=this.authService.authAdmin(loginForm.value);
  const token =this.authService.authAdmin(loginForm.value);
  if (token){
    localStorage.setItem('token',user.email)
    console.log("Login Succesfully");
    
    Swal.fire( 'You login succesfully!', 'success');
  }
  else{
    console.log("not ");
    Swal.fire({
      icon: 'error',
      title: 'Oops...',
      text: 'user name or password not correct!',

    })

  }
}
}

