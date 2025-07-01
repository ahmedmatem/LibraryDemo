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
                        break;
                    case "2":
                        DisplayBorrowABook(data.Books);
                        data.Save();
                        break;
                    case "3":
                        DisplayReturnBook(data.BorrowedBooks);
                        data.Save();
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
            throw new NotImplementedException();
        }

        private static void DisplayBorrowedBooks(List<Book> allBorrowedBooks)
        {
            throw new NotImplementedException();
        }

        private static void DisplayBorrowABook(List<Book> books)
        {
            throw new NotImplementedException();
        }

        private static Book DisplayAddNewBook()
        {
            throw new NotImplementedException();
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
        }
    }
}
