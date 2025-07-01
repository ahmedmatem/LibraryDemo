namespace LibraryDemo
{
    using System;
    using System.Text.Json;
    using static Constants; 

    public class Data
    {
        public List<Book> Books { get; private set; }
        public List<Book> BorrowedBooks { get; private set; }

        private StreamReader reader;
        private StreamWriter writer;

        public Data()
        {
            LoadBooks();
            SetAllBorrowedBooks();
        }

        private void LoadBooks()
        {
            using (reader)
            {
                string jsonData = reader.ReadToEnd();
                Books = JsonSerializer.Deserialize<List<Book>>(jsonData)!;
            }
            Books ??= new List<Book>();
        }

        public void Save()
        {
          
            StreamWriter writer = new StreamWriter(dataPath);
            using (writer)
            {
                string jsonData = JsonSerializer.Serialize(Books);
                writer.WriteLine(jsonData);
            }
        }

        private List<Book> SetAllBorrowedBooks()
        {
            List<Book> allBorrowedBooks = new List<Book>();
            foreach (var book in Books)
            {
                if (book.IsAvailable)
                {
                    allBorrowedBooks.Add(book);
                }
            }

            return allBorrowedBooks;
        }
    }
}
