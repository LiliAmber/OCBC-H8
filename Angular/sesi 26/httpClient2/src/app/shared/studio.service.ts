import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class StudioService {
  
  endpoint: string = 'http://localhost:3000'

  constructor(private http: HttpClient) { }

  get token() {
    return localStorage.getItem('access_token')
  }

  getStudios() {
    let api = `${this.endpoint}/studios`
    return this.http
      .get(api)
      .pipe(catchError(this.handleError))
  }

  handleError(err: HttpErrorResponse) {
    if(err.error instanceof ErrorEvent) {
      return throwError(err.error.message)
    } else {
      return throwError(`Server-side error code: ${err.status}\n Msg:${err.message}`)
    }
  }
}
