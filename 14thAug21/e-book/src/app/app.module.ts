import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddBookComponent } from './add-book/add-book.component';
import { DisplayBookComponent } from './display-book/display-book.component';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { BookDetailComponent } from './book-detail/book-detail.component';

const appRouting:Routes=[
  {path:'add-book',component:AddBookComponent},
  {path:'display-book',component:DisplayBookComponent},
  {path:'book-detail',component:BookDetailComponent}

]

@NgModule({
  declarations: [
    AppComponent,
    AddBookComponent,
    DisplayBookComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RouterModule.forRoot(appRouting)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
