namespace Task_5;

public class BookByAuthor : IBookSearchCondition
{
    private readonly string _author;

    public BookByAuthor(string author)
    {
        _author = author;
    }

    public Predicate<Book> Condition => b => b.Author == _author;
    public string ConditionDescription => $"Год - {_author}";
}