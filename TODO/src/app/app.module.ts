import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TodosComponent } from './components/todos/todos.component';
import { HttpClientModule } from '@angular/common/http';
import { PostsComponent } from './components/posts/posts.component';
import { ParentComponent } from './components/parent/parent.component';
import { ChildComponent } from './components/child/child.component';
import { CompaniesComponent } from './components/companies/companies.component';
import { CompanyComponent } from './components/company/company.component';
import { ExponentialstrengthPipe } from './pipes/exponentialstrength.pipe';
import { PipesdemoComponent } from './components/pipesdemo/pipesdemo.component';
import { ReactiveFormComponent } from './components/reactive-form/reactive-form.component';
import {ReactiveFormsModule} from '@angular/forms'

@NgModule({
  declarations: [
    AppComponent,
    TodosComponent,
    PostsComponent,
    ParentComponent,
    ChildComponent,
    CompaniesComponent,
    CompanyComponent,
    ExponentialstrengthPipe,
    PipesdemoComponent,
    ReactiveFormComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
