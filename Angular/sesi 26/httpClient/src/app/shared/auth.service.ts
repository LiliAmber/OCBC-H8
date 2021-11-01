import { Injectable } from '@angular/core';
import { User } from '../Model/User';
import { Observable, throwError } from 'rxjs';
import {catchError} from 'rxjs/operators'
import {HttpClient, HttpErrorResponse} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  endpoint: string = 'http://localhost:4000/api'

  constructor(private http: HttpClient) { }

  signup(user: User): Observable<any> {
    let api = `${this.endpoint}/register-user`
    return this.http
            .post(api, user)
            .pipe(catchError(this.handleError))
  }

  handleError(error: HttpErrorResponse) {
    let msg = ''
    if(error.error instanceof ErrorEvent) {
      msg = error.error.message
    } else {
      msg =`Error code: ${error.status}\n Message: ${error.message}`
    }
    return throwError(msg)
  }
}
