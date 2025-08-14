namespace Task_5;

internal class Program
{
    private static void Main(string[] args)
    {
        BookShelter bookShelter = new();
        Random random = new();

        Book book1 = new("World", "God", 0, 1);
        Book book2 = new("War and War", "People", 10, 1);
        Book book3 = new("Famous world food", "Noname cook", 2022, 3);
        Book book4 = new("Famous world food", "Noname cook", 2020, 4);
        Book book5 = new("World and War", "Lev Tolstoy", 1867, 5);
        Book book6 = new("World and War 2", "Lev Tolstoy", 1867, 6);
        Book book7 = new("World and War 3", "Lev Tolstoy", 1869, 7);

        // Создаем начальную библиотеку
        bookShelter.AddBook(book1);
        bookShelter.AddBook(book2);
        bookShelter.AddBook(book3);
        bookShelter.AddBook(book4);
        bookShelter.AddBook(book5);
        bookShelter.AddBook(book6);
        bookShelter.AddBook(book7);

        LibraryConsoleApp libraryConsoleApp = new(bookShelter);
        
        libraryConsoleApp.Run();
        
        
        
    }
}