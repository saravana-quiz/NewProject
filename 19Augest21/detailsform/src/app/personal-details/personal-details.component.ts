import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators,NgForm, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-personal-details',
  templateUrl: './personal-details.component.html',
  styleUrls: ['./personal-details.component.css']
})
export class PersonalDetailsComponent implements OnInit {

  profileForm:FormGroup;


  fName='';
  lName='';
  mobile='';
  mail='';
  homeAdd='';
  countryName='';
  cityName='';

  constructor() { }

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

  onSubmit(form:any)
  {

  }

}
