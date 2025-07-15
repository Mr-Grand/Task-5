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
                        bookShelter.ShowAllBooks();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Введите название книги");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите автора");
                        string author = Console.ReadLine();
                        Console.WriteLine("Введите год");
                        int year = int.Parse(Console.ReadLine());
                        int code = random.Next(8, 10000);
                        Book newBook = new(name, author, year, code);
                        bookShelter.AddBook(newBook);
                        Console.WriteLine("Книга добавлена! Нажмите любую клавишу, чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
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
                                Console.Clear();
                                Console.Write("Введите имя: ");
                                string inputString = Console.ReadLine();
                                bookShelter.DeleteBook(b => b.Name == inputString, "имя");
                                Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case ConsoleKey.D2:
                                Console.Clear();
                                Console.Write("Введите автора: ");
                                inputString = Console.ReadLine();
                                bookShelter.DeleteBook(b => b.Author == inputString, "автор");
                                Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case ConsoleKey.D3:
                                Console.Clear();
                                Console.Write("Введите год: ");
                                int inputInt = Convert.ToInt32(Console.ReadLine());
                                bookShelter.DeleteBook(b => b.Year == inputInt, "год");
                                Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case ConsoleKey.D4:
                                Console.Clear();
                                Console.Write("Введите код: ");
                                inputInt = Convert.ToInt32(Console.ReadLine());
                                bookShelter.DeleteBook(b => b.UniqueCode == inputInt, "код");
                                Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
                                Console.ReadKey();
                                Console.Clear();
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
                                Console.Clear();
                                Console.Write("Введите имя: ");
                                string inputString = Console.ReadLine();
                                bookShelter.ShowBook(b => b.Name == inputString, "имя");
                                Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case ConsoleKey.D2:
                                Console.Clear();
                                Console.Write("Введите автора: ");
                                inputString = Console.ReadLine();
                                bookShelter.ShowBook(b => b.Author == inputString, "автор");
                                Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case ConsoleKey.D3:
                                Console.Clear();
                                Console.Write("Введите год: ");
                                int inputInt = Convert.ToInt32(Console.ReadLine());
                                bookShelter.ShowBook(b => b.Year == inputInt, "год");
                                Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case ConsoleKey.D4:
                                Console.Clear();
                                Console.Write("Введите код: ");
                                inputInt = Convert.ToInt32(Console.ReadLine());
                                bookShelter.ShowBook(b => b.UniqueCode == inputInt, "код");
                                Console.WriteLine("Нажмите любую кнопку, чтобы вернуться в главное меню");
                                Console.ReadKey();
                                Console.Clear();
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
}