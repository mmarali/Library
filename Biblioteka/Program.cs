using System.Drawing;

namespace Biblioteka;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Welcome to Library.");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("How can I help you?");
        Thread.Sleep(3000);
        Console.Clear();
        
        
        Console.ForegroundColor = ConsoleColor.White;
        int choice;
        Library Library = new Library();
        
        do
        {
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Display all books in the library");
            Console.WriteLine("3. Search for books by title or author");
            Console.WriteLine("4. Delete book by title");
            Console.WriteLine("5. Exit");
            choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Book addBooks = new Book();
                    Console.WriteLine("Enter the title of the book:");
                    addBooks.title = Console.ReadLine();
                    Console.WriteLine("Enter the author of the book:");
                    addBooks.author = Console.ReadLine();
                    Console.WriteLine("Enter the data release of the book:");
                    addBooks.dataRelease = Console.ReadLine();
                    Library.books.Add(addBooks);
                    break;
                case 2:
                    Library.displayBooks();
                    break;
                    
                
            }
        } while (choice!=5);
        
        
        
        





    }
}