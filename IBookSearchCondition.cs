namespace Task_5;

public interface IBookSearchCondition
{
    Predicate<Book> Condition { get; }
    string ConditionDescription { get; }
}