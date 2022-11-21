import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Posts } from 'src/app/models/Posts';
import { PostService } from 'src/app/services/post.service';

@Component({
  selector: 'app-posts',
  templateUrl: './posts.component.html',
  styleUrls: ['./posts.component.css']
})
export class PostsComponent implements OnInit {

  posts:Posts[]=[]

  constructor(private postService:PostService) { }

  ngOnInit(): void {
    console.log("postsComponent:ngOnInit")
  //  this.todoService.getTodos().subscribe(todos=>console.log(todos))

    this.postService.getPosts().subscribe(posts=>{
      this.posts=posts
    })
  }

  addPosts(post:NgForm):void{
    console.log(post.value)
    this.postService.addPosts(post.value).subscribe(post=>{
      console.log(post)
      this.posts.push(post)
    }
      )
 
  }

}

