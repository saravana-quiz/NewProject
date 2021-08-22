import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { InfoService } from '../info.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-personal-details',
  templateUrl: './personal-details.component.html',
  styleUrls: ['./personal-details.component.css']
})
export class PersonalDetailsComponent implements OnInit {

  profileForm:FormGroup;

  constructor(private detailObj:InfoService,private _router: Router) { }

  ngOnInit(): void 
  {
    this.profileForm=new FormGroup({

      'firstName':new FormControl(null,Validators.required),
      'lastName':new FormControl(null,Validators.required),
      'phoneNumber':new FormControl(null,Validators.compose([Validators.required,Validators.pattern('[- +()0-9]+')])),
      'emailId':new FormControl(null, Validators.compose([
        Validators.required,
        Validators.pattern('^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$')
      ])),
      'Address':new FormControl(null,Validators.required),
      'Country':new FormControl(null,Validators.required),
      'City':new FormControl(null,Validators.required),
    });
  }

  countryList: Array<any> = [
    { name: 'Germany', cities: ['Select State','Duesseldorf', 'Leinfelden-Echterdingen', 'Eschborn'] },
    { name: 'Spain', cities: ['Select State','Barcelona'] },
    { name: 'USA', cities: ['Select State','Downers Grove'] },
    { name: 'Mexico', cities: ['Select State','Puebla'] },
    { name: 'India', cities: ['Select State','Tamil Nadu','Kerala','Karnataka'] },
  ];

  cities: Array<any>=[];

  changeCountry(count:any) 
  {
    this.cities = this.countryList.find(con => con.name == count.target.value).cities;
    //console.log(this.cities);
  }

  onSubmit()
  {
    let fName=this.profileForm.controls.firstName.value;
    let lName=this.profileForm.controls.lastName.value;
    let pNumber=this.profileForm.controls.phoneNumber.value;
    let emailId=this.profileForm.controls.emailId.value;
    let Address=this.profileForm.controls.Address.value;
    let Country=this.profileForm.controls.Country.value;
    let City=this.profileForm.controls.City.value;
    
    this.detailObj.onPersonalDetail(fName,lName,pNumber,emailId,Address,Country,City);
    this._router.navigate(['/professional-details']);

  }

}
