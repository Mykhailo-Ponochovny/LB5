using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Lab5_CSHARP_Vartiant6.Class;

namespace Lab5_CSHARP_Vartiant6.Windows
{
    public partial class MainWindow : Form
    {
        private List<string> _logs;
        private List<Reader> _readers;
        private List<Book> _books;

        private void StartDeserializeLogsJson()
        {
            _logs = Functions.DeserializeJsonLogs();
        }

        private void StartDeserializeReadersJson()
        {
            _readers = Functions.DeserializeJsonReaders();
            Functions.UpdateDataGridViewReaders(dataGridViewReaders, _readers);
        }

        private void StartDeserializeBooksJson()
        {
            _books = Functions.DeserializeJsonBooks();
            Functions.UpdateDataGridViewBooks(dataGridViewBooks, _books);
        }

        private void StartUpdateDataGridViewBooks()
        {
            Functions.UpdateDataGridViewBooks(dataGridViewBooks, _books);
            Functions.SerializeJsonBooks(_books);
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //start thread read logs
            var readLogsThreadStart = new ThreadStart(StartDeserializeLogsJson);
            var readLogsThread = new Thread(readLogsThreadStart);
            readLogsThread.Start();
            
            //start thread read books
            var readBooksThreadStart = new ThreadStart(StartDeserializeBooksJson);
            var readBooksThread = new Thread(readBooksThreadStart);
            readBooksThread.Start();
            
            //start thread read readers
            var readReadersThreadStart = new ThreadStart(StartDeserializeReadersJson);
            var readReadersThread = new Thread(readReadersThreadStart);
            readReadersThread.Start();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addBookDialog = new AddBookDialog(_books);
            addBookDialog.ShowDialog();
            var updateBooksThreadStart = new ThreadStart(StartUpdateDataGridViewBooks);
            var updateBooksThread = new Thread(updateBooksThreadStart);
            updateBooksThread.Start();
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var removeBookDialog = new RemoveBookDialog(_books, _readers);
            removeBookDialog.ShowDialog();
            var updateBooksThreadStart = new ThreadStart(StartUpdateDataGridViewBooks);
            var updateBooksThread = new Thread(updateBooksThreadStart);
            updateBooksThread.Start();
        }
    }
}