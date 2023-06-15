using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab5_CSHARP.Class;

namespace Lab5_CSHARP.Windows
{
    public partial class GiveBookReaderDialog : Form
    {
        public bool isGive = false;
        
        private List<Reader> _readers;
        private List<Book> _books;

        internal GiveBookReaderDialog(List<Reader> readers, List<Book> books)
        {
            _readers = readers;
            _books = books;
            InitializeComponent();
        }

        private void GiveBookReaderDialog_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            foreach (var reader in _readers)
                comboBoxReaders.Items.Add(
                    $"{reader.GetSetReaderSurname} {reader.GetSetReaderName} {reader.GetSetReaderNumber}");
        }

        private void buttonChooseReader_Click(object sender, EventArgs e)
        {
            if (comboBoxReaders.Text == string.Empty)
                MessageBox.Show("Оберіть читача зі списку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                comboBoxReaders.Enabled = false;
                buttonChooseReader.Enabled = false;
                comboBoxBooks.Enabled = true;
                buttonGive.Enabled = true;

                foreach (var book in _books)
                    comboBoxBooks.Items.Add(
                        $"{book.GetSetBookName} {book.GetSetBookAuthor} {book.GetSetBookNumber}");
            }
        }

        private void buttonGive_Click(object sender, EventArgs e)
        {
            if (comboBoxBooks.Text == string.Empty)
                MessageBox.Show("Оберіть книгу зі списку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (_books[comboBoxBooks.SelectedIndex].GetSetBookPublished)
                    MessageBox.Show("Ця книга вже видана!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    _readers[comboBoxReaders.SelectedIndex].AddBookNumbers =
                        _books[comboBoxBooks.SelectedIndex].GetSetBookNumber;
                    _books[comboBoxBooks.SelectedIndex].GetSetBookPublished = true;
                    isGive = true;
                    this.Close();
                }
            }
        }
    }
}