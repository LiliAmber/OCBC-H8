import { TestBed } from '@angular/core/testing';
import {HttpClientTestingModule, HttpTestingController} from '@angular/common/http/testing'

import { PostServiceService } from './post-service.service';

describe('PostServiceService', () => {
  let postService: PostServiceService;
  let httpMock: HttpTestingController

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [
        HttpClientTestingModule
      ],
      providers: [
        PostServiceService
      ]
    });
    postService = TestBed.inject(PostServiceService);
    httpMock = TestBed.inject(HttpTestingController)
  });

  it('should be created', () => {
    expect(postService).toBeTruthy();
  });

  it('should fetch posts successfully', () => {

    const postItem = [
      {
        "userId": 1,
        "id": 1,
        "title": "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
        "body": "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
      },
      {
        "userId": 1,
        "id": 2,
        "title": "qui est esse",
        "body": "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla"
      },
    ]

    postService.getPost() 
      .subscribe((posts: any) => {
        expect(posts.length).toBe(2)
      })
    
    let req = httpMock.expectOne('https://jsonplaceholder.typicode.com/posts')

    expect(req.request.method).toBe('GET')

    req.flush(postItem)
    httpMock.verify()
  })
});
function subscribe(arg0: (posts: any) => void) {
  throw new Error('Function not implemented.');
}

