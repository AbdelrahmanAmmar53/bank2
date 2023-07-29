using bank;
 
book book = new FictionBook();
book.author= "dan brown" ;
book.Number= 333;
Console.WriteLine(book.author);
Console.WriteLine(book.Number);
book book1 = new nonFictionBook();
book1.author="khaled tawfic";
book1.title="supernatural";
Console.WriteLine(book1.author);
Console.WriteLine(book1.title);
