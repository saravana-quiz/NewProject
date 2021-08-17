import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'reactiveform';

  profileList:any=[];

  onAdd(data:any)
  {
    this.profileList.push({
      type:'profile',
      firstName:data.firstName,
      lastName:data.lastName,
      phone:data.phoneNumber,
      email:data.emailId,
      Address:data.Address,
      Country:data.Country,
      City:data.City
    })

    console.log(this.profileList.Address)

  }
}
