import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-professional-details',
  templateUrl: './professional-details.component.html',
  styleUrls: ['./professional-details.component.css']
})
export class ProfessionalDetailsComponent implements OnInit {

  ProfessionalForm:FormGroup;

  constructor() { }

  ngOnInit(): void 
  {
    this.ProfessionalForm=new FormGroup({
      'empdesignation':new FormControl(null,Validators.required),
      'appdate':new FormControl(null,Validators.required),
      'qualification':new FormControl(null,Validators.required),
      'phoneNumber':new FormControl(null,Validators.required),
      'pemailId':new FormControl(null,Validators.required)

    })
  }

}
