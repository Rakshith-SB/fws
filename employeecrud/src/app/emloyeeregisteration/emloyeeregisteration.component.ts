import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
@Component({
  selector: 'app-emloyeeregisteration',
  templateUrl: './emloyeeregisteration.component.html',
  styleUrls: ['./emloyeeregisteration.component.css']
})
export class EmloyeeregisterationComponent implements OnInit {

  regUsers:any[]=[]
  constructor() { }

  ngOnInit(): void {
  }

  register(data:NgForm):void{
    this.regUsers.push(data.value)
  }
  deleteRow(id:any):void{
    for(let i = 0; i < this.regUsers.length; ++i){
        if (this.regUsers[i].code === id) {
            this.regUsers.splice(i,1);
        }
    }
  }}
