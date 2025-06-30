namespace LibraryDemo
{
    using System.Text.Json;
    using static Constants; 

    public class Data
    {
        public List<Book> Books { get; private set; }

        private StreamReader reader;
        private StreamWriter writer;

        public Data()
        {
            LoadBooks();
        }
        public void AddBook(Book newBook)
        {
            Books.Add(newBook);
            Save();
        }

        private void LoadBooks()
        {
            // TODO: Implement LoadBooks to get books from a file
            throw new NotImplementedException();
        }

        private void Save()
        {
          
            StreamWriter writer = new StreamWriter(dataPath);
            using (writer)
            {
                string jsonData = JsonSerializer.Serialize(Books);
                writer.WriteLine(jsonData);
            }
        }
    }
}
