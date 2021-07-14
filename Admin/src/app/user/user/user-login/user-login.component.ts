import { Component, NgModule, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { AutherizationServiceService } from 'app/services/AuthrizationService';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.css']
})
export class UserLoginComponent implements OnInit {

  constructor(private authService: AutherizationServiceService,private router:Router) { }

  ngOnInit() {
  }
  onLogin(loginForm:NgForm){
    console.log(loginForm.value);
    const user=this.authService.authUser(loginForm.value);
    const token =this.authService.authUser(loginForm.value);
    if (token){
      localStorage.setItem('token',user.email)
      console.log("Login Succesfully");
      this.router.navigate(['/'])
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
