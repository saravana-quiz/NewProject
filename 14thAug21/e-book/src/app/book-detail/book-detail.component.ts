import { Component, OnInit } from '@angular/core';
import { EbookserviceService } from '../ebookservice.service';

@Component({
  selector: 'app-book-detail',
  templateUrl: './book-detail.component.html',
  styleUrls: ['./book-detail.component.css']
})
export class BookDetailComponent implements OnInit {

  id:number=0;
  bookDesc:string='';
  bookList:any=[];

  constructor(private ebooks:EbookserviceService) { }

  ngOnInit(): void 
  {
    this.id=this.ebooks.OnGetId();
    this.bookList=this.ebooks.OnBookList();
  }

  url:any='';
  msg='';

  OnUpdateOf(id:any,url:any,description:any,price:any)
  {
    this.ebooks.OnUpdateOf(id,url,description,price);

  }



 

  selectFile(event: any) 
  { 
		if(!event.target.files[0] || event.target.files[0].length == 0) {
			this.msg = 'You must select an image';
			return;
		}
		
		var mimeType = event.target.files[0].type;
		
		if (mimeType.match(/image\/*/) == null) {
			this.msg = "Only images are supported";
			return;
		}
		
		var reader = new FileReader();
		reader.readAsDataURL(event.target.files[0]);
		
		reader.onload = (_event) => {
			this.msg = "";
			this.url = reader.result; 
		}
	}

}
