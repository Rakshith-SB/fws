import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Posts } from '../models/Posts';
import { Observable } from 'rxjs';
const httpOptions = {
  headers: new HttpHeaders({'Content-Type': 'application/json'})
}
@Injectable({
  providedIn: 'root'
})
export class PostService {

  url:string="http://jsonplaceholder.typicode.com/posts"

  constructor(private httpClient:HttpClient) { }

  getPosts(){
    console.log("postService:getPosts")
    return this.httpClient.get<Posts[]>(this.url)
  }

  addPosts(data:Posts):Observable<Posts>{
    console.log("TodoService:addPosts")
    return this.httpClient.post<Posts>(this.url,data,httpOptions)
  }
}
