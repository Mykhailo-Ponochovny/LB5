using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab5_CSHARP_Vartiant6.Class;

namespace Lab5_CSHARP_Vartiant6.Windows
{
    public partial class RemoveBookDialog : Form
    {
        public bool isRemove = false;
        
        private List<Book> _books;
        private List<Reader> _readers;

        internal RemoveBookDialog(List<Book> books, List<Reader> readers)
        {
            _books = books;
            _readers = readers;
            InitializeComponent();
        }

        private void RemoveBookDialog_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            foreach (var book in _books)
                comboBoxBooks.Items.Add(book.GetSetBookName + " " + book.GetSetBookNumber);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxBooks.Text == string.Empty)
                MessageBox.Show("Оберіть книгу зі списку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var mb = MessageBox.Show("Ви дійсно бажаєте видалити цю книгу?", "Питання?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (mb == DialogResult.Yes)
                {
                    Functions.RemoveBookNumberInReaders(_books[comboBoxBooks.SelectedIndex].GetSetBookNumber, _readers);
                    _books.RemoveAt(comboBoxBooks.SelectedIndex);
                    isRemove = true;
                }
                this.Close();
            }
        }
    }
}