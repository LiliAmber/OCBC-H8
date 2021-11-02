import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from 'src/app/shared/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  constructor(public authService: AuthService, public router: Router) { }
  registerForm = new FormGroup({
    name: new FormControl('', [Validators.required, Validators.minLength(5)]),
    password: new FormControl('', [Validators.required, Validators.minLength(5)]),
    email: new FormControl('', [Validators.required, Validators.email])
  })

  get name() {
    return this.registerForm.get('name')
  }

  get password() {
    return this.registerForm.get('password')
  }

  get email() {
    return this. registerForm.get('email')
  }

  ngOnInit(): void {
  }

  registerUser() {
    console.log(this.registerForm, '<<<')
    this.authService.signup(this.registerForm.value).subscribe((res) => {
      console.log('aku ke triggerrr')
      if(res) {
        console.log(res, '<<<<res')
        this.registerForm.reset()
        this.router.navigate(['session26/login'])
      }
    })
  }

}
