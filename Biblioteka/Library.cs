namespace Biblioteka;

public class Library
{
    public List<Book> books = new List<Book>();

    public void displayBooks()
    {
        foreach(var elements in books)
        {
            Console.WriteLine(elements.title + " - " + elements.author + elements.dataRelease);
        }
    }
}