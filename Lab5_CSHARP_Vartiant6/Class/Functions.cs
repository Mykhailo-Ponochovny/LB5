using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Lab5_CSHARP_Vartiant6.Class
{
    public class Functions
    {
        //Json for logs
        public static void SerializeJsonLogs(List<string> logs)
        {
            if (!Directory.Exists("data"))
                Directory.CreateDirectory("data");
            var saveLogJson = JsonSerializer.Serialize(logs);
            File.WriteAllText("data/logs.json", saveLogJson);
        }
        
        public static List<string> DeserializeJsonLogs()
        {
            var result = new List<string>();
            if (File.Exists("data/logs.json"))
            {
                var readLogJson = File.ReadAllText("data/logs.json");
                result = JsonSerializer.Deserialize<List<string>>(readLogJson);
            }

            return result;
        }

        //Json for Books
        public static void SerializeJsonBooks(List<Book> books)
        {
            if (!Directory.Exists("data"))
                Directory.CreateDirectory("data");
            var saveBooksJson = JsonSerializer.Serialize(books);
            File.WriteAllText("data/books.json", saveBooksJson);
        }

        public static List<Book> DeserializeJsonBooks()
        {
            var result = new List<Book>();
            if (File.Exists("data/books.json"))
            {
                var readBooksJson = File.ReadAllText("data/books.json");
                result = JsonSerializer.Deserialize<List<Book>>(readBooksJson);
            }

            return result;
        }
        
        //Json for Readers
        public static void SerializeJsonReaders(List<Reader> readers)
        {
            if (!Directory.Exists("data"))
                Directory.CreateDirectory("data");
            var saveReadersJson = JsonSerializer.Serialize(readers);
            File.WriteAllText("data/readers.json", saveReadersJson);
        }

        public static List<Reader> DeserializeJsonReaders()
        {
            var result = new List<Reader>();
            if (File.Exists("data/readers.json"))
            {
                var readReadersJson = File.ReadAllText("data/readers.json");
                result = JsonSerializer.Deserialize<List<Reader>>(readReadersJson);
            }

            return result;
        }

        //update DataGridView on main window
        public static void UpdateDataGridViewBooks(DataGridView dataGridView, List<Book> books)
        {
            dataGridView.Rows.Clear();
            if (books.Count > 0)
            {
                for (var i = 0; i < books.Count; i++)
                    dataGridView.Rows.Add(i + 1, books[i].GetSetBookName, books[i].GetSetBookAuthor,
                        books[i].GetSetBookCountPages, books[i].GetSetBookNumber, !books[i].GetSetBookPublished);
            }
        }

        public static void UpdateDataGridViewReaders(DataGridView dataGridView, List<Reader> readers)
        {
            dataGridView.Rows.Clear();
            if (readers.Count > 0)
            {
                for (var i = 0; i < readers.Count; i++)
                    dataGridView.Rows.Add(i + 1, readers[i].GetSetReaderSurname + " " + readers[i].GetSetReaderName,
                        readers[i].GetSetReaderNumber);
            }
        }
        
        //find BookNumber is readers list
        public static void RemoveBookNumberInReaders(int bookNumber, List<Reader> readers)
        {
            foreach (var reader in readers)
            {
                var getListBookNumbers = reader.GetSetBookNumbers;
                var findNumber = getListBookNumbers.FindIndex(bn => bn.Equals(bookNumber));
                if (findNumber != -1)
                    reader.RemoveBookNumber = findNumber;
            }
        }
        
        //updateDataGridViewLogs
        public static void UpdateDataGridViewLogs(DataGridView dataGridView, List<string> logs)
        {
            dataGridView.Rows.Clear();
            foreach (var log in logs)
                dataGridView.Rows.Add(log);
        }
    }
}