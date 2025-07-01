namespace LibraryDemo
{
    public class Book
    {
        private bool isAvailable;
        private decimal price;

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Price must be a positive number.");
                }
                price = value;
            }
        }

        public bool  IsAvailable 
        {
            get
            {
                return isAvailable;
            }
            set
            {
                isAvailable = value;
                if (isAvailable)
                {
                    Borrower = string.Empty;
                }
            }
        }
        public  string  Borrower { get; set; }

        public Book() { }

        public Book( string title, string author, int year, decimal price)
        {
            ISBN = Guid.NewGuid().ToString();
            Title = title;
            Author = author;
            Year = year;
            Price = price;
            IsAvailable = true;
        }
    }

}
