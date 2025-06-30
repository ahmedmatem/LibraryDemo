namespace LibraryDemo
{
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
            // TODO: Implement Save to file
            throw new NotImplementedException();
        }
    }
}
