import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListEmpComponent } from './list-emp/list-emp.component';
import { AddEmpComponent } from './add-emp/add-emp.component';

@NgModule({
  declarations: [
    AppComponent,
    ListEmpComponent,
    AddEmpComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
