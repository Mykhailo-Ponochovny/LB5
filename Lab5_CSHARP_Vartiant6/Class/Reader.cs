using System.Collections.Generic;

namespace Lab5_CSHARP_Vartiant6.Class
{
    public class Reader
    {
        private string ReaderSurname { get; set; }
        private string ReaderName { get; set; }
        private int ReaderNumber { get; set; }
        private List<int> BooksNumbers { get; set; }

        public Reader()
        {
            ReaderSurname = string.Empty;
            ReaderName = string.Empty;
            ReaderNumber = 0;
            BooksNumbers = new List<int>();
        }

        public Reader(string readerSurname, string readerName, int readerNumber, List<int> booksNumbers)
        {
            this.ReaderSurname = readerSurname;
            this.ReaderName = readerName;
            this.ReaderNumber = readerNumber;
            this.BooksNumbers = booksNumbers;
        }

        public string GetSetReaderSurname
        {
            get => ReaderSurname;
            set => ReaderSurname = value;
        }

        public string GetSetReaderName
        {
            get => ReaderName;
            set => ReaderName = value;
        }

        public int GetSetReaderNumber
        {
            get => ReaderNumber;
            set => ReaderNumber = value;
        }

        public int AddBookNumbers
        {
            set => BooksNumbers.Add(value);
        }

        public List<int> GetSetBookNumbers
        {
            get => BooksNumbers;
            set => BooksNumbers = value;
        }

        public int RemoveBookNumber
        {
            set => BooksNumbers.RemoveAt(value);
        }
    }
}