namespace Lab5_CSHARP_Vartiant6.Class
{
    public class Book
    {
        private string BookName { get; set; }
        private string BookAuthor { get; set; }
        private int BookCountPages { get; set; }
        private int BookNumber { get; set; }
        private bool BookPublished { get; set; }

        public Book()
        {
            BookName = string.Empty;
            BookAuthor = string.Empty;
            BookCountPages = 0;
            BookNumber = 0;
            BookPublished = false;
        }

        public Book(string bookName, string bookAuthor, int bookCountPages, int bookNumber, bool bookPublished)
        {
            this.BookName = bookName;
            this.BookAuthor = bookAuthor;
            this.BookCountPages = bookCountPages;
            this.BookNumber = bookNumber;
            this.BookPublished = bookPublished;
        }

        public string GetSetBookName
        {
            get => BookName;
            set => BookName = value;
        }

        public string GetSetBookAuthor
        {
            get => BookAuthor;
            set => BookAuthor = value;
        }

        public int GetSetBookCountPages
        {
            get => BookCountPages;
            set => BookCountPages = value;
        }

        public int GetSetBookNumber
        {
            get => BookNumber;
            set => BookNumber = value;
        }

        public bool GetSetBookPublished
        {
            get => BookPublished;
            set => BookPublished = value;
        }
    }
}