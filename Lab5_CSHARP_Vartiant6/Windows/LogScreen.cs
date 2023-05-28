using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab5_CSHARP_Vartiant6.Class;

namespace Lab5_CSHARP_Vartiant6.Windows
{
    public partial class LogScreen : Form
    {
        private List<string> _logs;
        public bool isOpen = false;
        public DataGridView lnkDataGridView;

        internal LogScreen(List<string> logs)
        {
            _logs = logs;
            InitializeComponent();
            lnkDataGridView = dataGridView1;
        }

        private void LogScreen_Load(object sender, EventArgs e)
        {
            Functions.UpdateDataGridViewLogs(dataGridView1, _logs);
            isOpen = true;
        }

        private void LogScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            isOpen = false;
            e.Cancel = false;
        }
    }
}