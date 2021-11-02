import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

interface User {
  isLogin: boolean
  email?: string
}

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {
  currentUser: User = {
    isLogin: false
  }

  loginForm = new FormGroup({
    email: new FormControl('', [
      Validators.minLength(5),
      Validators.email,
      Validators.required
    ]),
    password: new FormControl('', [
      Validators.required
    ])
  })

  get email() {
    return this.loginForm.get('email')
  }

  get password() {
    return this.loginForm.get('password')
  }

  onLogin() {
    this.currentUser = {
      isLogin: true,
      email: this.loginForm.value.email
    }
  }

  constructor() { }

  ngOnInit(): void {
  }

}
