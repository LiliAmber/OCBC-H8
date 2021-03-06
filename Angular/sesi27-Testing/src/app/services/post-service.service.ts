import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http'

export interface Post {
  userId: number
  id: number
  title: string
  body: string
}

@Injectable({
  providedIn: 'root'
})

export class PostServiceService {
  endpoint: string = 'https://jsonplaceholder.typicode.com/posts'

  constructor(private httpClient: HttpClient) { }

  getPost(): Observable<Post[]> {
    return this.httpClient.get<Post[]>(`${this.endpoint}`)
  }
}
