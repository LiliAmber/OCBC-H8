import { Injectable } from '@angular/core';
import { User } from '../Models/User';
import { Observable, throwError } from 'rxjs';
import {catchError} from 'rxjs/operators'
import {HttpClient, HttpErrorResponse, HttpHeaders} from '@angular/common/http'
import { Router } from '@angular/router';
import {map} from 'rxjs/operators'

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  endpoint: string = 'http://localhost:3000'

  headers = new HttpHeaders().set('Content-Type', 'application/json')

  currentUser: {
    name: string,
    id: number,
    email: string
  } = {
    name: '',
    id: 0,
    email: ''
  }

  constructor(private http: HttpClient, private router: Router) { }

  signup(user: User): Observable<any> {
    let api = `${this.endpoint}/register`
    return this.http
      .post(api, user)
      .pipe(catchError(this.handleError))
  }

  signIn(user: User) {
    let api = `${this.endpoint}/login`
    // return this.http
    //   .post(api, user)
    //   .pipe(catchError(this.handleError))

    return this.http
    .post(api, user)
    .subscribe((res: any) => {
      localStorage.setItem('access_token', res.token)
    })
  }

  getUserProfile(id: any): Observable<any> {
    let api = `${this.endpoint}/user-profile/${id}`
    return this.http.get(api, {headers: this.headers})
    .pipe(
      map((res: any) => {
        return res || {}
      }),
      catchError(this.handleError)
    )
  }

  handleError(err: HttpErrorResponse) {
    if(err.error instanceof ErrorEvent) {
      return throwError(err.error.message)
    } else {
      return throwError(`Server-side error code: ${err.status}\n Msg:${err.message}`)
    }
  }
}
