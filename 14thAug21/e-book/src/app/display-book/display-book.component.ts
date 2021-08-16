import { Component, OnInit } from '@angular/core';
import { EbookserviceService } from '../ebookservice.service';

@Component({
  selector: 'app-display-book',
  templateUrl: './display-book.component.html',
  styleUrls: ['./display-book.component.css']
})
export class DisplayBookComponent implements OnInit {
  
  bookList:any=[];

  ngOnInit(): void 
  {
    this.bookList=this.serviceObj.OnBookList();
    //this.books.push(JSON.parse(localStorage.getItem('my_books') || '{}'));
    //this.books.push(JSON.parse(localStorage.getItem('my_books')));
    console.log("bidcn");
  }
  
  constructor(private serviceObj:EbookserviceService)
  {
      
  };

  OnSetId(i:number)
  {
    this.serviceObj.OnUpdateId(i);

  }



  

 

 
  
  
}

