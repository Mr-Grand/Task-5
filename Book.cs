namespace Task_5;

public class Book
{
    private string _name;
    private string _author;
    private int _year;
    private int _uniqueCode;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Author
    {
        get => _author;
        set => _author = value;
    }

    public int Year
    {
        get => _year;
        set => _year = value;
    }

    public int UniqueCode
    {
        get => _uniqueCode;
        set => _uniqueCode = value;
    }


    public Book(string name, string author, int year, int uniqueCode)
    {
        _name = name;
        _author = author;
        _year = year;
        _uniqueCode = uniqueCode;
    }
}