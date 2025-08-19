namespace Task_5;

public class BookByCode : IBookSearchCondition
{
    private int _uniqueCode;

    public BookByCode(int uniqueCode)
    {
        _uniqueCode = uniqueCode;
    }

    public Predicate<Book> Condition => b => b.UniqueCode == _uniqueCode;
    public string ConditionDescription => $"код - {_uniqueCode}";
}