import { Injectable } from '@angular/core';
import { Corona } from '../models/corona';

@Injectable({
  providedIn: 'root'
})
export class CoronaService {

  coronaList:Corona[]=[]

  constructor() { }

  addCorona(corona:Corona):Corona[]{
    this.coronaList.push(corona)
    return this.coronaList
  }

  getCoronaList():Corona[]{
    return this.coronaList;
  }
}