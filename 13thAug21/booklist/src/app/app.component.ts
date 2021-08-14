import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title(title: any) {
    throw new Error('Method not implemented.');
  }

  id:number=0;
  bookDesc:string='';
  

  ngOnInit(): void 
  {
    //this.books.push(JSON.parse(localStorage.getItem('my_books') || '{}'));
    //this.books.push(JSON.parse(localStorage.getItem('my_books')));
    console.log("bidcn");
  }
  
  tableHead : string;
  books : any

  constructor()
  {
      this.tableHead = "Book List Table"

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
  };
  


  OnBookCreated(bookData: {isbn:number,name: string, desc: string,author:string,price:number})
  {
     this.books.push({
       type:'book',
       isbn:bookData.isbn,
       bookName: bookData.name,
       description: bookData.desc,
       author:bookData.author,
       price:bookData.price
     });
     localStorage.setItem("my_books", JSON.stringify(this.books)); 
  }

  OnGetId(i:number)
  {
    this.bookDesc=this.books[i].description
    this.id=i;

  }

  OnUpdateOf(id:number,url:any,description:string,price:any)
  {
  
    this.books[id].description=description;
    this.books[id].price=price;
    this.books[id].url=url;

    //this.price='';
    

  }

  url:any='';
  msg='';

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

