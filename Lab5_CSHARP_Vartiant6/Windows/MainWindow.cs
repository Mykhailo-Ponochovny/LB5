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

        private void StartDeserializeLogsJson()
        {
            _logs = Functions.DeserializeJsonLogs();
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var newThreadStart = new ThreadStart(StartDeserializeLogsJson);
            var newThread = new Thread(newThreadStart);
            newThread.Start();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}