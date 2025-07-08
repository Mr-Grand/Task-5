namespace Task_5;

class Program
{
    static void Main(string[] args)
    {
        BookShelter bookShelter = new();
        Random random = new();
        
        Book book1 = new("World", "God", 0,1);
        Book book2 = new("War and War", "People", 10,1);
        Book book3 = new("Famous world food", "Noname cook", 2022,3);
        Book book4 = new("Famous world food", "Noname cook", 2020,4);
        Book book5 = new("World and War", "Lev Tolstoy", 1867,5);
        Book book6 = new("World and War 2", "Lev Tolstoy", 1867,6);
        Book book7 = new("World and War 3", "Lev Tolstoy", 1869,7);
        
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

            var choice = Console.ReadKey().Key;
            if (choice != ConsoleKey.Spacebar)
            {
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
                        var choiseD3 = Console.ReadKey().Key;
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
                        var choiseD4 = Console.ReadKey().Key;
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
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.Spacebar:
                        IfContinue = false;
                        break;
                    default:
                        break;
                }
            }
            else break;



        }while(IfContinue);
        
        
    }

    class Book
    {
        private string _name;
        private string _author;
        private int _year;
        private int _uniqueCode;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public int UniqueCode
        {
            get { return _uniqueCode; }
            set { _uniqueCode = value; }
        }
        

        public Book(string name, string author, int year, int uniqueCode)
        {
            _name = name;
            _author = author;
            _year = year;
            _uniqueCode = uniqueCode;
        }
        
    }

    class BookShelter
    {
        private List<Book> _booksList = new();
        
        public void AddBook(Book book)
        {
            _booksList.Add(book);
        }

        public void ShowAllBooks()
        {
            Console.WriteLine($"\n** " + new string('-',25) + " **");
            foreach (Book book in _booksList)
            {
                Console.WriteLine($"book name: {book.Name},\tauthor: {book.Author},\t" +
                                  $"year: {book.Year},\tunique code: {book.UniqueCode}");
            }
            Console.WriteLine($"** " + new string('-',25) + " **");
        }

        private List<Book> FindBook(Predicate<Book> condition)
        {
            return _booksList.FindAll(condition);
        }

        public void ShowBook(Predicate<Book> condition, string criteria)
        {
            if (FindBook(condition).Count != 0)
            {
                Console.WriteLine($"\n** " + new string('-', 25) + " **");
                foreach( Book book in FindBook(condition))
                    Console.WriteLine($"Название - {book.Name},\tАвтор -  {book.Author},\t" +
                                      $"Год -  {book.Year},\tКод - {book.UniqueCode}");
                Console.WriteLine($"\n** " + new string('-', 25) + " **");
            }
            else Console.WriteLine($"Ничего не найдено по условию - {criteria}");
        }

        public void DeleteBook(Predicate<Book> condition, string criteria)
        {
            if (FindBook(condition).Count != 0)
            {
                foreach(Book book in FindBook(condition))
                    _booksList.Remove(book);
            }
            else Console.WriteLine($"Ничего не найдено по условию - {criteria}");
        }
        
        /*
        private List<Book> FindBookByName(string bookName)
        {
            return _booksList.FindAll(b => b.Name == bookName);
        }
        
        private List<Book> FindBookByAuthor(string bookAuthor)
        {
            return _booksList.FindAll(b => b.Author == bookAuthor);
            
        }
        
        private List<Book> FindBookByYear(int bookYear)
        {
            return _booksList.FindAll(b => b.Year == bookYear);
        }
        
        private List<Book> FindBookByCode(int bookCode)
        {
            return _booksList.FindAll(b => b.UniqueCode == bookCode);
        }

        public void ShowBookByName(string bookName)
        {
            if (FindBookByName(bookName).Count != 0)
            {
                foreach (Book book in FindBookByName(bookName))
                {
                    Console.WriteLine($"book name: {book.Name}, author: {book.Author}," +
                                      $" year: {book.Year},  unique code: {book.UniqueCode}");
                }
            }
            else 
                Console.WriteLine($"Ничего не найдено!");
        }
        
        public void ShowBookByAuthor(string bookAuthor)
        {
            if (FindBookByAuthor(bookAuthor).Count != 0)
            {
                foreach (Book book in FindBookByAuthor(bookAuthor))
                {
                    Console.WriteLine($"book name: {book.Name}, author: {book.Author}," +
                                      $" year: {book.Year},  unique code: {book.UniqueCode}");
                }
            }
            else 
                Console.WriteLine($"Ничего не найдено!");
        }
        
        public void ShowBookByYear(int bookYear)
        {
            if (FindBookByYear(bookYear).Count != 0)
            {
                foreach (Book book in FindBookByYear(bookYear))
                {
                    Console.WriteLine($"book name: {book.Name}, author: {book.Author}," +
                                      $" year: {book.Year},  unique code: {book.UniqueCode}");
                }
            }
            else 
                Console.WriteLine($"Ничего не найдено!");
        }
        
        public void ShowBookByCode(int bookCode)
        {
            if (FindBookByCode(bookCode).Count != 0)
            {
                foreach (Book book in FindBookByCode(bookCode))
                {
                    Console.WriteLine($"book name: {book.Name}, author: {book.Author}," +
                                      $" year: {book.Year},  unique code: {book.UniqueCode}");
                }
            }
            else 
                Console.WriteLine($"Ничего не найдено!");
        }
        
        public void DeleteBookByName(string bookName)
        {
            if (FindBookByName(bookName).Count != 0)
            {
                foreach (Book book in FindBookByName(bookName))
                {
                    Console.WriteLine($"book name: {book.Name}, author: {book.Author}," +
                                      $" year: {book.Year},  unique code: {book.UniqueCode}");
                }
            }
            else 
                Console.WriteLine($"Ничего не найдено!");
        }
        
        public void DeleteBookByAuthor(string bookAuthor)
        {
            if (FindBookByAuthor(bookAuthor).Count != 0)
            {
                foreach (Book book in FindBookByAuthor(bookAuthor))
                {
                    Console.WriteLine($"book name: {book.Name}, author: {book.Author}," +
                                      $" year: {book.Year},  unique code: {book.UniqueCode}");
                }
            }
            else 
                Console.WriteLine($"Ничего не найдено!");
        }
        
        public void DeleteBookByYear(int bookYear)
        {
            if (FindBookByYear(bookYear).Count != 0)
            {
                foreach (Book book in FindBookByYear(bookYear))
                {
                    Console.WriteLine($"book name: {book.Name}, author: {book.Author}," +
                                      $" year: {book.Year},  unique code: {book.UniqueCode}");
                }
            }
            else 
                Console.WriteLine($"Ничего не найдено!");
        }
        
        public void DeleteBookByCode(int bookCode)
        {
            if (FindBookByCode(bookCode).Count != 0)
            {
                foreach (Book book in FindBookByCode(bookCode))
                {
                    Console.WriteLine($"book name: {book.Name}, author: {book.Author}," +
                                      $" year: {book.Year},  unique code: {book.UniqueCode}");
                }
            }
            else 
                Console.WriteLine($"Ничего не найдено!");
        */
        //}
        
    }
}