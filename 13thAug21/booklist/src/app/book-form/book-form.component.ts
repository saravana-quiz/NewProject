import { Component, OnInit,  EventEmitter, Output } from '@angular/core';


@Component({
  selector: 'app-book-form',
  templateUrl: './book-form.component.html',
  styleUrls: ['./book-form.component.css']
})
export class BookFormComponent implements OnInit {

  isbn='';
  bookName='';
  bookDesc='';
  authorName='';
  price='';

  @Output() bookCreated=new EventEmitter<{isbn:any,name:string,desc:string,author:string,price:any}>();

  constructor() { }

  ngOnInit(): void {
  }

  onAddBook()
  {
    this.bookCreated.emit({isbn:this.isbn,name:this.bookName,desc:this.bookDesc,author:this.authorName,price:this.price});
    
    this.isbn='';
    this.bookName='';
    this.bookDesc='';
    this.authorName='';
    this.price='';
  }
  


}