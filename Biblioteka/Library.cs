using System.Net.Security;
using System.Threading.Channels;

namespace Biblioteka;

public class Library
{
    public List<Book> books = new List<Book>();

    public void DisplayBooks()
    {
        foreach(var elements in books)
        {
            Console.WriteLine(elements.title + " - " + elements.author + elements.dataRelease);
        }
    }

    public void SearchBooks(string title)
    {
        foreach (var elements in books)
        {
            if (elements.title == title)
            {
                Console.WriteLine(elements.title + "-" + elements.author+ " " + elements.dataRelease);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }

    public void DeleteBooks(string title)
    {
        foreach (var elements in books)
        {
            books.RemoveAll(book => book.title == title);
        }
    }
}