namespace Task_5;

public class BookByYear : IBookSearchCondition
{
    private readonly int _year;

    public BookByYear(int year)
    {
        _year = year;
    }

    public Predicate<Book> Condition => b => b.Year == _year;
    public string ConditionDescription => $"Год - {_year}";
}