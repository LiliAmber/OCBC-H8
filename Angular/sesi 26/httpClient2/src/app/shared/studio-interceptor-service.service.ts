import { Injectable } from '@angular/core';
import { StudioService } from './studio.service';
import { HttpHandler, HttpRequest, HttpInterceptor } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class StudioInterceptorServiceService implements HttpInterceptor {

  constructor(private studioService: StudioService) { }

  intercept(req: HttpRequest<any>, next: HttpHandler) {
    const authToken = this.studioService.getToken()

    req = req.clone({
      setHeaders: {
        Authorization: 'Bearer ' + authToken
      }
    })

    return next.handle(req)
  }
}
