import { Component, EventEmitter, OnInit } from '@angular/core';
import { EbookserviceService } from '../ebookservice.service';
@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css']
})
export class AddBookComponent implements OnInit {
  
  isbn='';
  bookName='';
  bookDesc='';
  authorName='';
  price='';

  constructor(private serviceObj:EbookserviceService) { }

  ngOnInit(): void {
  }

  onAddBook()
  {
    this.serviceObj.OnBookCreated(this.isbn,this.bookName,this.bookDesc,this.authorName,this.price);
    
    this.isbn='';
    this.bookName='';
    this.bookDesc='';
    this.authorName='';
    this.price='';
  }
  


}
