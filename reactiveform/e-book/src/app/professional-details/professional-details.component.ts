import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators, FormBuilder } from '@angular/forms';
import { InfoService } from '../info.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-professional-details',
  templateUrl: './professional-details.component.html',
  styleUrls: ['./professional-details.component.css']
})
export class ProfessionalDetailsComponent implements OnInit {

  ProfessionalForm:FormGroup;
  
  constructor(private fb:FormBuilder,private proObj:InfoService,private _router: Router) { }

  ngOnInit(): void 
  {
    this.ProfessionalForm=this.fb.group({
           
      'qualification':['',Validators.required],
      'phoneNumber':['',Validators.required],
      'pemailId':['',Validators.required],
      'experience':['',Validators.required],

      preCompany:this.fb.array([
        this.addSkillFormGroup()
      ])
    })
  }

  addSkillFormGroup() : FormGroup{
    return this.fb.group({
      cname:['',Validators.required],
      empdesignation : ['',Validators.required]
      
    });
  }

  CompanyList: {qualification:string,phoneNumber:number,pemailId:string,experience:number, cname:string[], designation:string[]}[] = [];

  qualification:string;
  phoneNumber:number;
  pemailId:string;
  experience:number;
  

  onPushCompanyList()
  {
    //console.log(this.ProfessionalForm.get('phoneNumber').value);
    this.qualification=this.ProfessionalForm.get('qualification').value
    this.phoneNumber=this.ProfessionalForm.get('phoneNumber').value
    this.pemailId=this.ProfessionalForm.get('pemailId').value
    this.experience=this.ProfessionalForm.get('experience').value
    this.CompanyList.push({qualification:this.qualification,phoneNumber:this.phoneNumber,pemailId:this.pemailId,experience:this.experience,cname:this.companyName,designation:this.designationList})
  }

  companyName:string[]=[];
  designationList:string[]=[];
  i:number=0;

  addSkillButtonClick()
  {
  
    this.companyName.push(this.ProfessionalForm.get('preCompany').value[this.i].cname);
    this.designationList.push(this.ProfessionalForm.get('preCompany').value[this.i].empdesignation);
    //console.log(this.ProfessionalForm.get('preCompany').value[this.i].empdesignation)
    this.i++;
    (<FormArray>this.ProfessionalForm.get('preCompany')).push(this.addSkillFormGroup());
  }
  
  onSubmit()
  {
    this.companyName.push(this.ProfessionalForm.get('preCompany').value[this.i].cname);
    this.designationList.push(this.ProfessionalForm.get('preCompany').value[this.i].empdesignation);
    this.onPushCompanyList();
    this.proObj.onpreCompanyInfo(this.CompanyList);
    this._router.navigate(['/attachments']);
  }
}

