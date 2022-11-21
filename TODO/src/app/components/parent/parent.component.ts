import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent implements OnInit {

  msgToChild:string=''
  msgFromChild:string=''
  constructor() { }

  ngOnInit(): void {
  }

  msgFromParent(msg:string):void{
    this.msgToChild = msg
    console.log("message to child "+msg)
  }



  receiveChildMsg($event:string):void{
    this.msgFromChild=$event;
  }
}
