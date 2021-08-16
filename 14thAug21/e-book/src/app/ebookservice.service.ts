import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EbookserviceService {

  books:any;
  id:number=0;

  constructor() 
  {
      this.books = [{
          isbn : 9783161484100,
          bookName: "The Hunger Games",
          description : "In the ruins of a place once known as North America, a shining Capitol surrounded by twelve outlying districts.",
          author:"Suzanne Collins",
          price:800
      },
      {
        isbn : 9783161484108,
        bookName: "Brave New World",
        description : "Brave New World is a dystopian novel by English author Aldous Huxley, written in 1931 and published in 1932.",
        author:"Aldous Huxley",
        price:600
      },
      {
        isbn : 9783161484105,
        bookName: "The Time Machine",
        description : "So it begins 800,000 years beyond his own era and the story that launched H.G. Wells’s successful career.",
        author:"H.G.Wells",
        price:900
      },
      {
        isbn : 9783161484104,
        bookName: "Battle Royale",
        description : "Koushun Takami's notorious high-octane thriller is based on an irresistible premise.",
        author:"Koushun Takami",
        price:1000
      }]
   }

   OnBookList()
   {
     return this.books;
   }

   OnBookCreated(isbn:any,name: string, desc: string,author:string,price:any)
  {
     this.books.push({
       type:'book',
       isbn:isbn,
       bookName: name,
       description:desc,
       author:author,
       price:price
     });
     localStorage.setItem("my_books", JSON.stringify(this.books)); 
  }

  OnUpdateOf(id:number,url:any,description:string,price:any)
  {
  
    this.books[id].description=description;
    this.books[id].price=price;
    this.books[id].url=url;
  }

  OnUpdateId(id:number)
  {
    this.id=id

  }

  OnGetId()
  {
    return this.id;
  }


}
