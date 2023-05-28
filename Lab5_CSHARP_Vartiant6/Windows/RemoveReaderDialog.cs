using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Lab5_CSHARP_Vartiant6.Class;

namespace Lab5_CSHARP_Vartiant6.Windows
{
    public partial class RemoveReaderDialog : Form
    {
        public bool isRemove = false;
        
        private List<Reader> _readers;
        private List<Book> _books;

        internal RemoveReaderDialog(List<Reader> readers, List<Book> books)
        {
            _readers = readers;
            _books = books;
            InitializeComponent();
        }

        private void RemoveReaderDialog_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            foreach (var reader in _readers)
                comboBoxReaders.Items.Add(reader.GetSetReaderSurname + " " + reader.GetSetReaderName + " " +
                                          reader.GetSetReaderNumber);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxReaders.Text == string.Empty)
                MessageBox.Show("Оберіть читача зі списку!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var mb = MessageBox.Show("Ви дійсно бажаєте видалити цього читача?", "Питання?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mb == DialogResult.Yes)
                {
                    var getReaderBookNumbers = _readers[comboBoxReaders.SelectedIndex].GetSetBookNumbers;
                    if (getReaderBookNumbers.Count > 0)
                    {
                        foreach (var findIndexBookNumber in getReaderBookNumbers.Select(bookNumber => _books.FindIndex(b => b.GetSetBookNumber.Equals(bookNumber))).Where(findIndexBookNumber => findIndexBookNumber != null))
                            _books[findIndexBookNumber].GetSetBookPublished = false;
                    }
                    _readers.RemoveAt(comboBoxReaders.SelectedIndex);
                    isRemove = true;
                    this.Close();
                }
            }
        }
    }
}