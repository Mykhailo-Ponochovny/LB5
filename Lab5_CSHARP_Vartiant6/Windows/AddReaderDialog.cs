using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab5_CSHARP_Vartiant6.Class;

namespace Lab5_CSHARP_Vartiant6.Windows
{
    public partial class AddReaderDialog : Form
    {
        public bool addReader = false;
        
        private List<Reader> _readers;

        internal AddReaderDialog(List<Reader> readers)
        {
            _readers = readers;
            InitializeComponent();
        }

        private void AddReaderDialog_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxReaderSurname.Text == string.Empty || textBoxReaderName.Text == string.Empty)
                MessageBox.Show("Недостатньо інформації!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var readerNumber = Convert.ToInt32(Math.Round(numericUpDownReaderNumber.Value, 0));
                var findReaderNumber = _readers.Find(r => r.GetSetReaderNumber.Equals(readerNumber));
                if (findReaderNumber != null)
                    MessageBox.Show("Читач з таким номером вже записаний!", "Помилка!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                {
                    var newReader = new Reader(textBoxReaderSurname.Text, textBoxReaderName.Text, readerNumber,
                        new List<int>());
                    _readers.Add(newReader);
                    addReader = true;
                    this.Close();
                }
            }
        }
    }
}