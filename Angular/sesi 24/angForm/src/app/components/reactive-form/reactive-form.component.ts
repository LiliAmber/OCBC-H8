import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-reactive-form',
  templateUrl: './reactive-form.component.html',
  styleUrls: ['./reactive-form.component.css']
})
export class ReactiveFormComponent implements OnInit {
  isSubmitted: boolean = false

  currentUser: {
    isLogin: boolean
    username: string
    password: string
  } = {
    isLogin: false,
    username: '',
    password: ''
  }

  loginForm = new FormGroup ({
    username: new FormControl('', [
      Validators.required,
      Validators.minLength(5)
    ]),
    password: new FormControl('', [
      Validators.required
    ])
    
  })

  //==getter untuk nampilin value di html==
  get username() {
    return this.loginForm.get('username')
  }

  get password() {
    return this.loginForm.get('password')
  }

  onLogin() {
    // console.log(this.loginForm, "<<log")
    console.log(this.username, '<<username')
    this.isSubmitted = true

    this.currentUser = {
      isLogin: true,
      username: this.loginForm.value.username,
      password: this.loginForm.value.password
    }
  }

  handleIsSubmittedState() {
    if(this.isSubmitted === true) {
      this.isSubmitted = false
    }
  }

  constructor() { }

  ngOnInit(): void {
  }

}
