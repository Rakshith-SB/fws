import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Todos } from 'src/app/models/Todos';
import { TodoService } from 'src/app/services/todo.service';

@Component({
  selector: 'app-todos',
  templateUrl: './todos.component.html',
  styleUrls: ['./todos.component.css']
})
export class TodosComponent implements OnInit {

  todos:Todos[]=[]

  constructor(private todoService:TodoService) { }

  ngOnInit(): void {
    console.log("TodosComponent:ngOnInit")
  //  this.todoService.getTodos().subscribe(todos=>console.log(todos))

    this.todoService.getTodos().subscribe(todos=>{
      this.todos=todos
    })
  }

  addTodo(todo:NgForm):void{
    console.log(todo.value)
    this.todoService.addTodo(todo.value).subscribe(todo=>{
      console.log(todo)
      this.todos.push(todo)
    }
      )
 
  }

}
