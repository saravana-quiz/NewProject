import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PersonalDetailsComponent } from './personal-details/personal-details.component';
import { ProfessionalDetailsComponent } from './professional-details/professional-details.component';
import { AttachmentsComponent } from './attachments/attachments.component';

const appRouting:Routes=[
  {path:'personal-details',component:PersonalDetailsComponent},
  {path:'professional-details',component:ProfessionalDetailsComponent},
  {path:'attachments',component:AttachmentsComponent}

]

@NgModule({
  declarations: [
    AppComponent,
    PersonalDetailsComponent,
    ProfessionalDetailsComponent,
    AttachmentsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(appRouting)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
