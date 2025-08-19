namespace Task_5;

public class BookByTitle : IBookSearchCondition
{
    private string _title;

    public BookByTitle(string title)
    {
        _title = title;
    }
    
    public Predicate<Book> Condition => b => b.Title == _title;
    public string ConditionDescription => $"название - {_title}";
}