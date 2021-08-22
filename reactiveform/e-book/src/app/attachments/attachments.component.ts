import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { InfoService } from '../info.service';

@Component({
  selector: 'app-attachments',
  templateUrl: './attachments.component.html',
  styleUrls: ['./attachments.component.css']
})
export class AttachmentsComponent implements OnInit {

  AttachmentForm:FormGroup;

  constructor(private attachmentObj: InfoService) { }

  ngOnInit(): void 
  {
    this.AttachmentForm=new FormGroup({
      'resume':new FormControl(null,Validators.required)
    })
  }

  msg:string;
  file:object;

  onSelectFile(event: any) 
  {
		if(!event.target.files[0] || event.target.files[0].length == 0) {
			this.msg = 'You must select an image';
			return;
		}
		
		var fileType = event.target.files[0].type;
		
		if (fileType.match(/pdf\/*/) == null) {
			this.msg = "Only pdf are supported";
			return;
		}
    this.file= event.target.files
		//console.log(this.file)
	}

  onSubmit()
  {
    this.attachmentObj.onimgFile(this.file);
  }

}