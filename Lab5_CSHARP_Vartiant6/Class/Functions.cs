using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Lab5_CSHARP_Vartiant6.Class
{
    public class Functions
    {
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
    }
}