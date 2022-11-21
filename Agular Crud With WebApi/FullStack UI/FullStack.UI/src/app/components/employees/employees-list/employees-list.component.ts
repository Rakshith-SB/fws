import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent implements OnInit {

  employees:Employee[]=[
    {
      id:'1',
      name:'afraz',
      email:'afraz@gmail.com',
      phone:1234567890,
      salary:300000,
      department:'IT'
    },
    {
      id:'2',
      name:'asfan',
      email:'asfan@gmail.com',
      phone:1234567891,
      salary:400000,
      department:'HR'
    },
    {
      id:'3',
      name:'abcde',
      email:'abcde@gmail.com',
      phone:1234567812,
      salary:200000,
      department:'Finance'
    }
  ]
 
  constructor() { }
 
  ngOnInit(): void {
  }
 
}
