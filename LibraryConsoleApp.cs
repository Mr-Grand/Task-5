namespace Task_5;

public class LibraryConsoleApp
{
    private BookShelter _bookShelter;

    public LibraryConsoleApp(BookShelter bookShelter)
    {
        _bookShelter = bookShelter;
    }

    public void Run()
    {
        bool IfContinue = true;
        do
        {
            Console.Write("\x1B[2J\x1B[3J\x1B[H"); // Удаляем весь вывод консоли
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Здравствуйте! Что вы хотите сделать?" +
                              "\n1) Показать все книги на полке" +
                              "\n2) Добавить книгу" +
                              "\n3) Убрать книгу" +
                              "\n4) Найти книгу" +
                              "\nSpacebar) Закончить работу");
            Console.WriteLine();

            ConsoleKey choice = Console.ReadKey().Key;
            if (choice != ConsoleKey.Spacebar)
                switch (choice)
                {
                    case ConsoleKey.D1:
                        ShowBooksMenu();
                        break;
                    case ConsoleKey.D2:
                        AddBookMenu();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        // Выбор параметра удаления
                        Console.WriteLine("По какому параметру вы хотите найти и удалить книги?" +
                                          "\n1) По названию" +
                                          "\n2) По автору" +
                                          "\n3) По году" +
                                          "\n4) По уникальному коду" +
                                          "\nSpacebar) Вернуться назад");
                        ConsoleKey choiseD3 = Console.ReadKey().Key;
                        switch (choiseD3)
                        {
                            case ConsoleKey.D1:
                                DeleteBookByTitleMenu();
                                break;
                            case ConsoleKey.D2:
                                DeleteBookByAuthorMenu();
                                break;
                            case ConsoleKey.D3:
                                DeleteBookByYearMenu();
                                break;
                            case ConsoleKey.D4:
                                DeleteBookByUniqueCodeMenu();
                                break;
                            case ConsoleKey.Spacebar:
                                Console.Clear();
                                break;
                        }

                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        // Выбор параметра поиска
                        Console.WriteLine("По какому параметру вы хотите найти книги?" +
                                          "\n1) По названию" +
                                          "\n2) По автору" +
                                          "\n3) По году" +
                                          "\n4) По уникальному коду" +
                                          "\nSpacebar) Вернуться назад");
                        ConsoleKey choiseD4 = Console.ReadKey().Key;
                        switch (choiseD4)
                        {
                            case ConsoleKey.D1:
                                FindBookByTitleMenu();
                                break;
                            case ConsoleKey.D2:
                                FindBookByAuthorMenu();
                                break;
                            case ConsoleKey.D3:
                                FindBookByYearMenu();
                                break;
                            case ConsoleKey.D4:
                                FindBookByUniqueCodeMenu();
                                break;
                            case ConsoleKey.Spacebar:
                                Console.Clear();
                                break;
                        }

                        break;
                    case ConsoleKey.Spacebar:
                        IfContinue = false;
                        break;
                    default:
                        break;
                }
            else break;
        } while (IfContinue);
    }

    private void ShowBooksMenu()
    {
        _bookShelter.ShowAllBooks();
        Console.ReadKey();
        Console.Clear();
    }

    private void AddBookMenu()
    {
        Random random = new Random();
        Console.Clear();
        Console.WriteLine("Введите название книги");
        string name = Console.ReadLine();
        Console.WriteLine("Введите автора");
        string author = Console.ReadLine();
        Console.WriteLine("Введите год");
        int year = int.Parse(Console.ReadLine());
        int code = random.Next(8, 10000);
        Book newBook = new(name, author, year, code);
        _bookShelter.AddBook(newBook);
        Console.WriteLine("Книга добавлена! Нажмите любую клавишу, чтобы продолжить");
        Console.ReadKey();
        Console.Clear();
    }

    private void DeleteBookByTitleMenu()
    {
        Console.Clear();
        Console.Write("Введите имя: ");
        string inputString = Console.ReadLine();
        IBookSearchCondition condition = new BookByTitle(inputString);
        _bookShelter.DeleteBook(condition);
        Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
        Console.ReadKey();
        Console.Clear();
    }

    private void DeleteBookByAuthorMenu()
    {
        Console.Clear();
        Console.Write("Введите автора: ");
        string inputString = Console.ReadLine();
        IBookSearchCondition condition = new BookByAuthor(inputString);
        _bookShelter.DeleteBook(condition);
        Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
        Console.ReadKey();
        Console.Clear();
    }

    private void DeleteBookByYearMenu()
    {
        Console.Clear();
        Console.Write("Введите год: ");
        int inputInt = Convert.ToInt32(Console.ReadLine());
        IBookSearchCondition condition = new BookByYear(inputInt);
        _bookShelter.DeleteBook(condition);
        Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
        Console.ReadKey();
        Console.Clear();
    }

    private void DeleteBookByUniqueCodeMenu()
    {
        Console.Clear();
        Console.Write("Введите код: ");
        int inputInt = Convert.ToInt32(Console.ReadLine());
        IBookSearchCondition condition = new BookByCode(inputInt);
        _bookShelter.DeleteBook(condition);
        Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
        Console.ReadKey();
        Console.Clear();
    }

    private void FindBookByTitleMenu()
    {
        Console.Clear();
        Console.Write("Введите имя: ");
        string inputString = Console.ReadLine();
        IBookSearchCondition condition = new BookByTitle(inputString);
        _bookShelter.ShowBook(condition);
        Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
        Console.ReadKey();
        Console.Clear();
    }

    private void FindBookByAuthorMenu()
    {
        Console.Clear();
        Console.Write("Введите автора: ");
        string inputString = Console.ReadLine();
        IBookSearchCondition condition = new BookByAuthor(inputString);
        _bookShelter.ShowBook(condition);
        Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
        Console.ReadKey();
        Console.Clear();
    }

    private void FindBookByYearMenu()
    {
        Console.Clear();
        Console.Write("Введите год: ");
        int inputInt = Convert.ToInt32(Console.ReadLine());
        IBookSearchCondition condition = new BookByYear(inputInt);
        _bookShelter.ShowBook(condition);
        Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
        Console.ReadKey();
        Console.Clear();
    }

    private void FindBookByUniqueCodeMenu()
    {
        Console.Clear();
        Console.Write("Введите код: ");
        int inputInt = Convert.ToInt32(Console.ReadLine());
        IBookSearchCondition condition = new BookByCode(inputInt);
        _bookShelter.ShowBook(condition);
        Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
        Console.ReadKey();
        Console.Clear();
    }
    
}