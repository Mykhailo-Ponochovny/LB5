using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab5_CSHARP_Vartiant6.Class;

namespace Lab5_CSHARP_Vartiant6.Windows
{
    public partial class AddBookDialog : Form
    {
        public bool isAdd = false;
        
        private List<Book> _books;

        internal AddBookDialog(List<Book> books)
        {
            _books = books;
            InitializeComponent();
        }

        private void AddBookDialog_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxBookName.Text == string.Empty || textBoxAuthor.Text == string.Empty
                                                     || numericUpDownCountPages.Value == 0)
                MessageBox.Show("Недостатньо інформації!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var bookNumber = Convert.ToInt32(Math.Round(numericUpDownBookNumber.Value, 0));
                
                var checkBookNumberRepeat = _books.Find(x => x.GetSetBookNumber.Equals(bookNumber));
                if (checkBookNumberRepeat != null)
                    MessageBox.Show("Книга з цим номером вже записана!", "Помилка!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                {
                    var bookCountPages = Convert.ToInt32(Math.Round(numericUpDownCountPages.Value, 0));
                    var newBook = new Book(textBoxBookName.Text, textBoxAuthor.Text, bookCountPages, bookNumber, false);
                    _books.Add(newBook);
                    isAdd = true;
                    this.Close();
                }
            }
        }
    }
}