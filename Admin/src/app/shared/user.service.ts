import { Injectable } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  constructor(private fb: FormBuilder, private http: HttpClient) {}
  readonly BaseURI = 'http://localhost:5000/api';
  formModel = this.fb.group({
    UserName: ['', Validators.required],
    Email: ['', Validators.email],
    FullName: [''],
    Passwords: this.fb.group(
      {
        Password: ['', [Validators.required, Validators.minLength(4)]],
        ConffirmPassword: ['', Validators.required],
      } //,{validator:this.comparePasswords
    ),
  });
  comparePasswords(fb: FormGroup) {
    let confirmPswdCtrl = fb.get('confirmPassword');

    if (
      confirmPswdCtrl?.errors == null ||
      'passwordMismatch' in confirmPswdCtrl.errors
    ) {
      if (fb.get('Password')?.value != confirmPswdCtrl?.value)
        confirmPswdCtrl?.setErrors({ passwordMismatch: true });
      else confirmPswdCtrl?.setErrors(null);
    }
  }
  register() {
    var body = {
      UserName: this.formModel.value.UserName,
      Email: this.formModel.value.email,
      FullName: this.formModel.value.FullName,
      Password: this.formModel.value.Password,
    };
    return this.http.post(this.BaseURI + '/JwtAuthController/Register', body);
  }
  loginEmployee(formData: any) {
    return this.http.post(
      this.BaseURI + '/JwtAuthController/EmployeeAuth',
      formData
    );
  }
  loginCustomer(formData: any) {
    return this.http.post(
      this.BaseURI + '/JwtAuthController/CustomerAuth',
      formData
    );
  }
  loginDoctor(formData: any) {
    return this.http.post(
      this.BaseURI + '/JwtAuthController/DoctorAuth',
      formData
    );
  }
}
/*
  constructor(private fb: FormBuilder, private http: HttpClient) { }
  readonly BaseURI = 'http://localhost:5000/api';

  formModel = this.fb.group({
    UserName: ['', Validators.required],
    Email: ['', Validators.email],
    FullName: [''],
    Passwords: this.fb.group({
      Password: ['', [Validators.required, Validators.minLength(4)]],
      ConfirmPassword: ['', Validators.required]
    }, { validator: this.comparePasswords })

  });

  comparePasswords(fb: FormGroup) {
    let confirmPswrdCtrl = fb.get('ConfirmPassword');
    //passwordMismatch
    //confirmPswrdCtrl.errors={passwordMismatch:true}
    if (confirmPswrdCtrl?.errors == null || 'passwordMismatch' in confirmPswrdCtrl.errors) {
      if (fb.get('Password')?.value != confirmPswrdCtrl?.value)
        confirmPswrdCtrl?.setErrors({ passwordMismatch: true });
      else
        confirmPswrdCtrl?.setErrors(null);
    }
  }

  register() {
    var body = {
      UserName: this.formModel.value.UserName,
      Email: this.formModel.value.Email,
      FullName: this.formModel.value.FullName,
      Password: this.formModel.value.Passwords.Password
    };
    return this.http.post(this.BaseURI + '/JwtAuth/Register', body);
  }

  login(formData:any) {
    return this.http.post(this.BaseURI + '/JwtAuth/Login', formData);
  }

  getUserProfile() {
    return this.http.get(this.BaseURI + '/UserProfile');
  }
}
*/
