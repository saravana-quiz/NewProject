import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class InfoService {

  fName: string;
  lName: string;
  pNumber: number;
  houseAddress: string;
  emailId:string;
  countryName: string;
  stateName: string;

  constructor() { }

  EmployeeDetails: 
  {
    firstName:string, 
    lastName:string, 
    phoneNumber:number, 
    address:string, 
    country:string,
    state:string,
    previousEmploymentDetails: {qualification:string,phoneNumber:number,pemailId:string,experience:number, cname:string[], designation:string[]}[],
    resume: object
  }[] = [];

  onPersonalDetail(fName: string,lName: string,pNumber: number,emailId:string, hAddress: string, country:string,state:string)
  {
    this.fName=fName;
    this.lName=lName;
    this.pNumber=pNumber;
    this.emailId=emailId;
    this.houseAddress=hAddress;
    this.countryName=country;
    this.stateName=state;
  }

  preCompanyInfo: {qualification:string,phoneNumber:number,pemailId:string,experience:number, cname:string[], designation:string[]}[] ;

  onpreCompanyInfo(obj: {qualification:string,phoneNumber:number,pemailId:string,experience:number, cname:string[], designation:string[]}[] )
  {
    this.preCompanyInfo=obj;
  }

  imgFile: object;

  onimgFile(file: object)
  {
    this.imgFile=file;
    this.onUploadDetails()

  }

  onUploadDetails()
  {
    this.EmployeeDetails.push(
      {
      firstName:this.fName,lastName:this.lName,phoneNumber:this.pNumber,address:this.houseAddress,country:this.countryName,state:this.stateName, previousEmploymentDetails:this.preCompanyInfo,resume:this.imgFile
    })
    console.log("Employee Details:",this.EmployeeDetails);
  }
}
