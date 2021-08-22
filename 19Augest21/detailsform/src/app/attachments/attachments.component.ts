import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-attachments',
  templateUrl: './attachments.component.html',
  styleUrls: ['./attachments.component.css']
})
export class AttachmentsComponent implements OnInit {

  AttachmentForm:FormGroup;

  constructor() { }

  ngOnInit(): void 
  {
    this.AttachmentForm=new FormGroup({
      'resume':new FormControl(null,Validators.required)
    })
  }

}
