// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Author myAuthor = new Author("Jeff Lucas", 'm', "jslucas@cba.ua.edu");        

Console.WriteLine(myAuthor.ToString());

Book myBook = new Book("12242", "My Book, Your Book", myAuthor);

Console.WriteLine(myBook.ToString());

Console.WriteLine(myBook.GetAuthor().ToString());

myBook yourBook = new myBook("4321", "The Phantom Book", new Author("Jamie", 'f', "jamie@mail.com"));

yourBook.GetAuthor().SetName("jamie@crimson.ua.edu");

Console.WriteLine(yourBook.ToString());