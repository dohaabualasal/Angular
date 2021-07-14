import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { Router } from 'angular-routing';
import { Admin } from 'app/model/Admin';
import { AdminService } from 'app/services/Admin.service';
import { UserServiceService } from 'app/services/userService.service';
import Swal from 'sweetalert2';


@Component({
  selector: 'app-Admin-Register',
  templateUrl: './Admin-Register.component.html',
  styleUrls: ['./Admin-Register.component.scss']
})
export class AdminRegisterComponent implements OnInit {

  form!: FormGroup;
  submitted = false;
  user: Admin = {
    fullname: "",
    email: "",
    password: "",
    mobile: 772201833,
  };
   emails=[];
   allemails=[];
  emailPattern = "^[a-z0-9._%+-]+@gmail+.com";
  constructor(
    private formBuilder: FormBuilder,
    private UserService: AdminService,
    private router:Router
  ) {}

  getProperty(email: string) :boolean {
    if (this.allemails.find(element => element ===email)) {
      console.log("duplicate");
      return true;
    } 
    else {
      console.log("ok");
      return false;
    }
  }
  ngOnInit(): void {
   this.GetAllEmails();
    this.form = this.formBuilder.group(
      {
        fullname: ["", Validators.required],

        email: [
          "",
          [Validators.required, Validators.pattern(this.emailPattern)],
          
        ],
        mobile: [
          "",
          [
            Validators.required,
            Validators.minLength(10),
            Validators.maxLength(10),
          ],
        ],
        password: [
          "",
          [
            Validators.required,
            Validators.minLength(6),
            Validators.maxLength(40),
          ],
        ],
        confirmPassword: ["", Validators.required],
      },
      {
        validators: [Validation.match("password", "confirmPassword")],
      }
    );
  }
  get f(): { [key: string]: AbstractControl } {
    return this.form.controls;
  }

  onSubmit(): void {
    this.user = Object.assign(this.user, this.form.value);

   
    this.submitted = true;

    if (this.form.invalid) {
      Swal.fire({
        icon: "error",
        title: "Oops...",
        text: "Something went wrong!",
      });
    }
    else if ( this.getProperty(this.user.email)){
      Swal.fire({
        icon: "error",
        title: "Oops...",
        text: "Duplicate Email!",
      });
    } 
    else {
      
      Swal.fire("Thank you...", "You Regitsered succesfully!", "success");
      this.user = Object.assign(this.user, this.form.value);
      this.getProperty(this.user.email);
      this.UserService.addUser(this.user);

      let Admins = [];
      Admins.push(JSON.stringify(this.form.value, null, 2));
      console.log(JSON.stringify(this.form.value, null, 2));
      // this.router.navigate(['/Adminlogin'])

      console.log(Admins);
    }
  }

  onReset(): void {
    this.submitted = false;
    this.form.reset();
  }
  GetAllEmails():any {
    const myData = JSON.parse(localStorage.getItem("Admins"));
    
    //console.log(myData);
   // return myData;
    for (const i in myData){
     this.emails.push(myData[i])
     // console.log(myData[i])
     this.emails.forEach(element => {
        this.allemails.push(element.email);
       console.log(element.email)
       
     });

    }
    return this.allemails;
  }
}

export default class Validation {
  static match(controlName: string, checkControlName: string): ValidatorFn {
    return (controls: AbstractControl) => {
      const control = controls.get(controlName);
      const checkControl = controls.get(checkControlName);

      if (checkControl!.errors && !checkControl!.errors.matching) {
        return null;
      }

      if (control!.value !== checkControl!.value) {
        controls.get(checkControlName)!.setErrors({ matching: true });
        return { matching: true };
      } else {
        return null;
      }
    };
  }
  alertWithSuccess() {
    Swal.fire("Thank you...", "You submitted succesfully!", "success");
  }
}

