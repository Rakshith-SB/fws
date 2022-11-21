import { Component, OnInit } from '@angular/core';
import { Corona } from 'src/app/models/corona';
import { CoronaService } from 'src/app/services/corona.service';

@Component({
  selector: 'app-corona',
  templateUrl: './corona.component.html',
  styleUrls: ['./corona.component.css']
})
export class CoronaComponent implements OnInit {

  corona:Corona={
    code:0,
    name:'',
    active:0,
    recovered:0,
    death:0,
    total:0
  }  

  coronaList:Corona[]=[]
  constructor(private coronaService:CoronaService) { }

  ngOnInit(): void {
  }

  addCorona():void{
    console.log('addcorona')
    console.log(this.corona)
    //this.coronaList.push(this.corona)
    this.coronaList=this.coronaService.addCorona(this.corona)
    this.reset()
  }

  reset():void{
    this.corona={
      code:0,
      name:'',
      active:0,
      recovered:0,
      death:0,
      total:0
    }
  }

}
