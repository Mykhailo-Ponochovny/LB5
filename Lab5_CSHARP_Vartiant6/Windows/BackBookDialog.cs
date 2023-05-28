using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab5_CSHARP_Vartiant6.Class;

namespace Lab5_CSHARP_Vartiant6.Windows
{
    public partial class BackBookDialog : Form
    {
        private List<Reader> _readers;
        private List<Book> _books;

        internal BackBookDialog(List<Reader> readers, List<Book> books)
        {
            _readers = readers;
            _books = books;
            InitializeComponent();
        }

        private void BackBookDialog_Load(object sender, EventArgs e)
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
                if (_readers[comboBoxReaders.SelectedIndex].GetSetBookNumbers.Count == 0)
                    MessageBox.Show("В цього читача відсутні книги!", "Помилка!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                {
                    comboBoxReaders.Enabled = false;
                    buttonChooseReader.Enabled = false;
                    comboBoxBooks.Enabled = true;
                    buttonBack.Enabled = true;

                    var getReaderBooks = _readers[comboBoxReaders.SelectedIndex].GetSetBookNumbers;
                    foreach (var bookNumber in getReaderBooks)
                        comboBoxBooks.Items.Add(bookNumber);
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (comboBoxBooks.Text == string.Empty)
                MessageBox.Show("Оберіть книгу зі списку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var findIndexBook = _books.FindIndex(b =>
                    b.GetSetBookNumber.Equals(_readers[comboBoxReaders.SelectedIndex]
                        .GetSetBookNumbers[comboBoxBooks.SelectedIndex]));
                _books[findIndexBook].GetSetBookPublished = false;
                _readers[comboBoxReaders.SelectedIndex].RemoveBookNumber = comboBoxBooks.SelectedIndex;
                this.Close();
            }
        }
    }
}