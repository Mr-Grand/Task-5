namespace Task_5;

public class Book
{
    public string Name { get; private set; }
    public string Author { get; private set; }
    public int Year { get; private set; }
    public int UniqueCode { get; private set; }
    
    public Book(string name, string author, int year, int uniqueCode)
    {
        Name = name;
        Author = author;
        Year = year;
        UniqueCode = uniqueCode;
    }
}