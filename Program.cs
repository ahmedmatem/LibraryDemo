namespace LibraryDemo
{
    public class Program
    {
        private static Data data = new Data();

        static void Main(string[] args)
        {
            DisplayMenu();

            string choice = string.Empty;
            while ((choice = Console.ReadLine()!.ToLower()) != "x")
            {
                switch (choice)
                {
                    case "1":
                        // Add a new book
                        Book newBook = DisplayAddNewBook();
                        data.Books.Add(newBook);
                        data.Save();
                        BackToMenu();
                        break;
                    case "2":
                        DisplayBorrowABook(data.Books);
                        data.Save();
                        BackToMenu();
                        break;
                    case "3":
                        DisplayReturnBook(data.BorrowedBooks);
                        data.Save();
                        BackToMenu();
                        break;
                    case "4":
                        DisplayAllBooks(data.Books);
                        break;
                    case "5":
                        DisplayBorrowedBooks(data.BorrowedBooks);
                        break;
                    default:
                        break;
                }

                
            }

            // End 
            Environment.Exit(0);
        }

        private static void DisplayReturnBook(List<Book> borrowedBooks)
        {
            throw new NotImplementedException();
        }

        private static void DisplayAllBooks(List<Book> books)
        {
            Console.Clear();
            Console.WriteLine("Всички книги");
            Console.WriteLine("============");
            Console.WriteLine();
            foreach (Book book in books)
            {
                Console.WriteLine($"▶ {book}");
            }
        }

        private static void DisplayBorrowedBooks(List<Book> allBorrowedBooks)
        {
            throw new NotImplementedException();
        }

        private static void DisplayBorrowABook(List<Book> books)
        {
            Console.Clear();

            Console.WriteLine($"Списък на всички незаети книги");
            Console.WriteLine("==============================");
            Console.WriteLine();
            List<Book> allAvailabelBooks = books.Where(b => b.IsAvailable).ToList();
            int i = 1;
            foreach (var book in allAvailabelBooks)
            {
                Console.WriteLine($"{i++:d3}. {book}");
            }
            Console.WriteLine();
            Console.Write("Въведи номер на избрана книга: ");
            int selectedBookIndex = int.Parse(Console.ReadLine());
            //TODO: validate book selected index
            Console.Write("Въведи лично име: ");
            string borrowerName = Console.ReadLine();
            books[selectedBookIndex - 1].IsAvailable = false;
            books[selectedBookIndex - 1].Borrower = borrowerName;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Заехте успешно книга");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void BackToMenu()
        {
            Console.WriteLine();
            Console.Write("Enter обратно към меню");
            Console.ReadLine();
            Console.Clear();
            DisplayMenu();
        }
        private static Book DisplayAddNewBook()
        {
            Console.Clear();
            Console.WriteLine("Добавяне на нова книга");
            Console.WriteLine("======================");
            Console.WriteLine();
            Console.Write("Въведи заглавие: ");
            string title = Console.ReadLine();
            Console.Write("Въведи автор: ");
            string author = Console.ReadLine();
            Console.Write("Въведи година: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Въведи цена: ");
            decimal price = decimal.Parse(Console.ReadLine());
            return new Book(title, author,year,price);
          
        }

        private static void DisplayMenu()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            Console.WriteLine("=========================");
            Console.WriteLine("★       М Е Н Ю        ★");
            Console.WriteLine("=========================");
            Console.WriteLine();
            Console.WriteLine("1. ▶ Добавяне на нова книга");
            Console.WriteLine("2. ▶ Заемане на книга");
            Console.WriteLine("3. ▶ Връщане на книга");
            Console.WriteLine("4. ▶ Справка за всички налични книги");
            Console.WriteLine("5. ▶ Справка за заетите книги");
            Console.WriteLine();
            Console.WriteLine("x. ❌ Изход");
            Console.WriteLine("=========================");
            Console.Write("Твоят избор: ");
        }
    }
}
