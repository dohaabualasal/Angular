import { Component, OnInit } from "@angular/core";
import Swal from "sweetalert2/dist/sweetalert2.js";
import {
  FormGroup,
  FormControl,
  Validators,
  FormBuilder,
  AbstractControl,
  ValidatorFn,
} from "@angular/forms";
import { isNull } from "@angular/compiler/src/output/output_ast";
import { User } from "app/model/User";
import { UserServiceService } from "app/services/userService.service";
import { map } from "rxjs/operators";
import { Observable } from "rxjs";

@Component({
  selector: "app-user-register",
  templateUrl: "./user-register.component.html",
  styleUrls: ["./user-register.component.css"],
})
export class UserRegisterComponent implements OnInit {
  form!: FormGroup;
  submitted = false;
  user: User = {
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
    private UserService: UserServiceService
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

      let Users = [];
      Users.push(JSON.stringify(this.form.value, null, 2));
      console.log(JSON.stringify(this.form.value, null, 2));

      console.log(Users);
    }
  }

  onReset(): void {
    this.submitted = false;
    this.form.reset();
  }
  GetAllEmails():any {
    const myData = JSON.parse(localStorage.getItem("Users"));
    
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
