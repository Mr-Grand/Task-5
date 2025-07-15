namespace Task_5;

public class BookShelter
{
    private List<Book> _books = new();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public void ShowAllBooks()
    {
        Show(_books);
    }

    private List<Book> FindBook(Predicate<Book> condition)
    {
        return _books.FindAll(condition);
    }

    public void ShowBook(Predicate<Book> condition, string criteria)
    {
        List<Book> books = FindBook(condition);
        if (FindBook(condition).Count != 0)
        {
            Show(books);
        }
        else
        {
            Console.WriteLine($"Ничего не найдено по условию - {criteria}");
        }
    }

    public void Show(List<Book> list)
    {
        Console.WriteLine($"\n** " + new string('-', 25) + " **");
        foreach (Book book in list)
            Console.WriteLine($"Название - {book.Name},\tАвтор -  {book.Author},\t" +
                              $"Год -  {book.Year},\tКод - {book.UniqueCode}");
        Console.WriteLine($"\n** " + new string('-', 25) + " **");
    }

    public void DeleteBook(Predicate<Book> condition, string criteria)
    {
        if (FindBook(condition).Count != 0)
            foreach (Book book in FindBook(condition))
                _books.Remove(book);
        else Console.WriteLine($"Ничего не найдено по условию - {criteria}");
    }
}