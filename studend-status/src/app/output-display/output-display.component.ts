import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-output-display',
  templateUrl: './output-display.component.html',
  styleUrls: ['./output-display.component.css']
})
export class OutputDisplayComponent implements OnInit {

  @Input() StudentList:string[]=[];

  constructor() { }

  ngOnInit(): void {
  }

  
  OnUpdated(name: any)
  {
    this.StudentList.push(name)

  } 
 

}
