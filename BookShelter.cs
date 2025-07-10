namespace Task_5;

public class BookShelter
{
    private List<Book> _booksList = new();

    public void AddBook(Book book)
    {
        _booksList.Add(book);
    }

    public void ShowAllBooks()
    {
        Console.WriteLine($"\n** " + new string('-', 25) + " **");
        foreach (Book book in _booksList)
            Console.WriteLine($"book name: {book.Name},\tauthor: {book.Author},\t" +
                              $"year: {book.Year},\tunique code: {book.UniqueCode}");
        Console.WriteLine($"** " + new string('-', 25) + " **");
    }

    private List<Book> FindBook(Predicate<Book> condition)
    {
        return _booksList.FindAll(condition);
    }

    public void ShowBook(Predicate<Book> condition, string criteria)
    {
        if (FindBook(condition).Count != 0)
        {
            Console.WriteLine($"\n** " + new string('-', 25) + " **");
            foreach (Book book in FindBook(condition))
                Console.WriteLine($"Название - {book.Name},\tАвтор -  {book.Author},\t" +
                                  $"Год -  {book.Year},\tКод - {book.UniqueCode}");
            Console.WriteLine($"\n** " + new string('-', 25) + " **");
        }
        else
        {
            Console.WriteLine($"Ничего не найдено по условию - {criteria}");
        }
    }

    public void DeleteBook(Predicate<Book> condition, string criteria)
    {
        if (FindBook(condition).Count != 0)
            foreach (Book book in FindBook(condition))
                _booksList.Remove(book);
        else Console.WriteLine($"Ничего не найдено по условию - {criteria}");
    }
}