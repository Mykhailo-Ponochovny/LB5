using System;
using System.Collections.Generic;
using System.Linq;
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
        
        private void StartUpdateDataGridViewReaders()
        {
            Functions.UpdateDataGridViewReaders(dataGridViewReaders, _readers);
            Functions.SerializeJsonReaders(_readers);
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
            if (_books.Count == 0)
                MessageBox.Show("В програмі відсутні записи про книги!", "Помилка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                var removeBookDialog = new RemoveBookDialog(_books, _readers);
                removeBookDialog.ShowDialog();
                var updateBooksThreadStart = new ThreadStart(StartUpdateDataGridViewBooks);
                var updateBooksThread = new Thread(updateBooksThreadStart);
                updateBooksThread.Start();
            }
        }

        private void giveBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_readers.Count == 0)
                MessageBox.Show("В програмі відсутні записи про читачів!", "Помилка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                
            }
        }

        private void removeReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_readers.Count == 0)
                MessageBox.Show("В програмі відсутні записи про читачів!", "Помилка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                
            }
        }

        private void backBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_readers.Count == 0)
                MessageBox.Show("В програмі відсутні записи про читачів!", "Помилка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                
            }
        }

        private void readerBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_readers.Count == 0)
                MessageBox.Show("В програмі відсутні записи про читачів!", "Помилка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                
            }
        }

        private void addReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addReaderDialog = new AddReaderDialog(_readers);
            addReaderDialog.ShowDialog();
            if (_readers.Count > 0)
            {
                var updateDataGridViewReaderThreadStart = new ThreadStart(StartUpdateDataGridViewReaders);
                var updateDataGridViewReaderThread = new Thread(updateDataGridViewReaderThreadStart);
                updateDataGridViewReaderThread.Start();
            }
        }
    }
}