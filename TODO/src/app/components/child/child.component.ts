import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit {

  @Input() msgToChild:string=''
  //@Output() msgToParent:string=''

  @Output() childEvent = new EventEmitter<string>();

  constructor() { }

  ngOnInit(): void {
  }

  postMsgToParent(msg:string):void{
    //this.msgToParent = msg
    this.childEvent.emit(msg)
  }

}
