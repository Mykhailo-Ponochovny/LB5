using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Lab5_CSHARP.Class;

namespace Lab5_CSHARP.Windows
{
    public partial class MainWindow : Form
    {
        private List<string> _logs;
        private List<Reader> _readers;
        private List<Book> _books;

        private LogScreen _logScreen;

        private void StartDeserializeLogsJson()
        {
            _logs = Functions.DeserializeJsonLogs();
            _logScreen = new LogScreen(_logs);
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

        private void StartUpdateDataGridViewLogs()
        {
            Functions.UpdateDataGridViewLogs(_logScreen.lnkDataGridView, _logs);
            Functions.SerializeJsonLogs(_logs);
        }

        private void UpdateDataGridViewReaders()
        {
            var updateDataGridViewReaderThreadStart = new ThreadStart(StartUpdateDataGridViewReaders);
            var updateDataGridViewReaderThread = new Thread(updateDataGridViewReaderThreadStart);
            updateDataGridViewReaderThread.Start();
        }

        private void UpdateDataGridViewBooks()
        {
            var updateBooksThreadStart = new ThreadStart(StartUpdateDataGridViewBooks);
            var updateBooksThread = new Thread(updateBooksThreadStart);
            updateBooksThread.Start();
        }

        private void UpdateDataGridViewLogs()
        {
            var updateLogsThreadStart = new ThreadStart(StartUpdateDataGridViewLogs);
            var updateLogsThread = new Thread(updateLogsThreadStart);
            updateLogsThread.Start();
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //start thread read logs
            _logs = new List<string>();
            var readLogsThreadStart = new ThreadStart(StartDeserializeLogsJson);
            var readLogsThread = new Thread(readLogsThreadStart);
            readLogsThread.Start();
            _logScreen = new LogScreen(_logs);
            
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
            if (addBookDialog.isAdd)
            {
                _logs.Add("Користувач додав книгу");
                if (_logScreen.isOpen)
                    UpdateDataGridViewLogs();
            }
            UpdateDataGridViewBooks();
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
                if (removeBookDialog.isRemove)
                {
                    _logs.Add("Користувач видалив книгу");
                    if (_logScreen.isOpen)
                        UpdateDataGridViewLogs();
                }
                UpdateDataGridViewBooks();
            }
        }

        private void giveBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_readers.Count == 0)
                MessageBox.Show("В програмі відсутні записи про читачів!", "Помилка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                var giveBookReaderDialog = new GiveBookReaderDialog(_readers, _books);
                giveBookReaderDialog.ShowDialog();
                if (giveBookReaderDialog.isGive)
                {
                    _logs.Add("Користувач видав книгу читачеві");
                    if (_logScreen.isOpen)
                        UpdateDataGridViewLogs();
                }
                UpdateDataGridViewBooks();
                UpdateDataGridViewReaders();
            }
        }

        private void removeReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_readers.Count == 0)
                MessageBox.Show("В програмі відсутні записи про читачів!", "Помилка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                var removeReaderDialog = new RemoveReaderDialog(_readers, _books);
                removeReaderDialog.ShowDialog();
                if (removeReaderDialog.isRemove)
                {
                    _logs.Add("Користувач видалив читача");
                    if (_logScreen.isOpen)
                        UpdateDataGridViewLogs();
                }
                UpdateDataGridViewBooks();
                UpdateDataGridViewReaders();
            }
        }

        private void backBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_readers.Count == 0)
                MessageBox.Show("В програмі відсутні записи про читачів!", "Помилка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                var backBookDialog = new BackBookDialog(_readers, _books);
                backBookDialog.ShowDialog();
                if (backBookDialog.isBack)
                {
                    _logs.Add($"Користувач повернув книгу");
                    if (_logScreen.isOpen)
                        UpdateDataGridViewLogs();
                }
                UpdateDataGridViewBooks();
                UpdateDataGridViewReaders();
            }
        }

        private void addReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addReaderDialog = new AddReaderDialog(_readers);
            addReaderDialog.ShowDialog();
            if (addReaderDialog.addReader)
            {
                _logs.Add("Користувач додав читача");
                if (_logScreen.isOpen)
                    UpdateDataGridViewLogs();
                UpdateDataGridViewReaders();
            }
        }

        private void checkLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_logScreen.isOpen)
                _logScreen.Show();
        }

        private void removeLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _logs = new List<string>();
            if (_logScreen.isOpen)
                UpdateDataGridViewLogs();
        }
    }
}