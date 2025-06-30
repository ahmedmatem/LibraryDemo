namespace LibraryDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();

            string choice = string.Empty;
            while((choice = Console.ReadLine()!.ToLower()) != "x")
            {
                switch (choice) 
                {
                    case
                }
            }
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
