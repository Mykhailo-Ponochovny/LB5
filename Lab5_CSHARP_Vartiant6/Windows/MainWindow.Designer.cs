namespace Lab5_CSHARP_Vartiant6.Windows
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.роботаЗКнигамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giveBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.роботаЗЧитачамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readerBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewReaders = new System.Windows.Forms.DataGridView();
            this.ReaderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadersID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.BookNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCountPages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.файлToolStripMenuItem, this.роботаЗКнигамиToolStripMenuItem, this.роботаЗЧитачамиToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.checkLogsToolStripMenuItem, this.exitToolStripMenuItem });
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // checkLogsToolStripMenuItem
            // 
            this.checkLogsToolStripMenuItem.Name = "checkLogsToolStripMenuItem";
            this.checkLogsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.checkLogsToolStripMenuItem.Text = "Переглянути логи";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // роботаЗКнигамиToolStripMenuItem
            // 
            this.роботаЗКнигамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.addBookToolStripMenuItem, this.giveBookToolStripMenuItem, this.removeBookToolStripMenuItem });
            this.роботаЗКнигамиToolStripMenuItem.Name = "роботаЗКнигамиToolStripMenuItem";
            this.роботаЗКнигамиToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.роботаЗКнигамиToolStripMenuItem.Text = "Робота з книгами";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addBookToolStripMenuItem.Text = "Додати книгу";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // giveBookToolStripMenuItem
            // 
            this.giveBookToolStripMenuItem.Name = "giveBookToolStripMenuItem";
            this.giveBookToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.giveBookToolStripMenuItem.Text = "Видати книгу";
            // 
            // removeBookToolStripMenuItem
            // 
            this.removeBookToolStripMenuItem.Name = "removeBookToolStripMenuItem";
            this.removeBookToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.removeBookToolStripMenuItem.Text = "Видалити книгу";
            this.removeBookToolStripMenuItem.Click += new System.EventHandler(this.removeBookToolStripMenuItem_Click);
            // 
            // роботаЗЧитачамиToolStripMenuItem
            // 
            this.роботаЗЧитачамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.addReaderToolStripMenuItem, this.removeReaderToolStripMenuItem, this.backBookToolStripMenuItem, this.readerBookToolStripMenuItem });
            this.роботаЗЧитачамиToolStripMenuItem.Name = "роботаЗЧитачамиToolStripMenuItem";
            this.роботаЗЧитачамиToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.роботаЗЧитачамиToolStripMenuItem.Text = "Робота з читачами";
            // 
            // addReaderToolStripMenuItem
            // 
            this.addReaderToolStripMenuItem.Name = "addReaderToolStripMenuItem";
            this.addReaderToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addReaderToolStripMenuItem.Text = "Додати читача";
            // 
            // removeReaderToolStripMenuItem
            // 
            this.removeReaderToolStripMenuItem.Name = "removeReaderToolStripMenuItem";
            this.removeReaderToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.removeReaderToolStripMenuItem.Text = "Видалити читача";
            // 
            // backBookToolStripMenuItem
            // 
            this.backBookToolStripMenuItem.Name = "backBookToolStripMenuItem";
            this.backBookToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.backBookToolStripMenuItem.Text = "Повернути книгу";
            // 
            // readerBookToolStripMenuItem
            // 
            this.readerBookToolStripMenuItem.Name = "readerBookToolStripMenuItem";
            this.readerBookToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.readerBookToolStripMenuItem.Text = "Книги читача";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 622F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1260, 622);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewReaders);
            this.groupBox2.Location = new System.Drawing.Point(633, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 616);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Читачі";
            // 
            // dataGridViewReaders
            // 
            this.dataGridViewReaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.ReaderNumber, this.ReaderFullName, this.ReadersID });
            this.dataGridViewReaders.Location = new System.Drawing.Point(6, 28);
            this.dataGridViewReaders.Name = "dataGridViewReaders";
            this.dataGridViewReaders.Size = new System.Drawing.Size(612, 582);
            this.dataGridViewReaders.TabIndex = 1;
            // 
            // ReaderNumber
            // 
            this.ReaderNumber.HeaderText = "№";
            this.ReaderNumber.MinimumWidth = 70;
            this.ReaderNumber.Name = "ReaderNumber";
            this.ReaderNumber.ReadOnly = true;
            this.ReaderNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ReaderNumber.Width = 70;
            // 
            // ReaderFullName
            // 
            this.ReaderFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReaderFullName.HeaderText = "Прізвище ім\'я";
            this.ReaderFullName.MinimumWidth = 100;
            this.ReaderFullName.Name = "ReaderFullName";
            this.ReaderFullName.ReadOnly = true;
            // 
            // ReadersID
            // 
            this.ReadersID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReadersID.HeaderText = "Читатський номер";
            this.ReadersID.MinimumWidth = 100;
            this.ReadersID.Name = "ReadersID";
            this.ReadersID.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewBooks);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 616);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Книги";
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.BookNumber, this.BookName, this.BookAuthor, this.BookCountPages, this.BookId });
            this.dataGridViewBooks.Location = new System.Drawing.Point(6, 28);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(612, 582);
            this.dataGridViewBooks.TabIndex = 0;
            // 
            // BookNumber
            // 
            this.BookNumber.HeaderText = "№";
            this.BookNumber.MinimumWidth = 70;
            this.BookNumber.Name = "BookNumber";
            this.BookNumber.ReadOnly = true;
            this.BookNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BookNumber.Width = 70;
            // 
            // BookName
            // 
            this.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookName.HeaderText = "Назва книги";
            this.BookName.MinimumWidth = 100;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // BookAuthor
            // 
            this.BookAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookAuthor.HeaderText = "Автор";
            this.BookAuthor.MinimumWidth = 100;
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.ReadOnly = true;
            // 
            // BookCountPages
            // 
            this.BookCountPages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookCountPages.HeaderText = "К-сть сторінок";
            this.BookCountPages.MinimumWidth = 100;
            this.BookCountPages.Name = "BookCountPages";
            this.BookCountPages.ReadOnly = true;
            // 
            // BookId
            // 
            this.BookId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookId.HeaderText = "Номер";
            this.BookId.MinimumWidth = 100;
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книги";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadersID;
        private System.Windows.Forms.ToolStripMenuItem readerBookToolStripMenuItem;

        private System.Windows.Forms.DataGridViewTextBoxColumn BookNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCountPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;

        private System.Windows.Forms.DataGridView dataGridViewReaders;

        private System.Windows.Forms.DataGridView dataGridViewBooks;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giveBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem роботаЗЧитачамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeReaderToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem роботаЗКнигамиToolStripMenuItem;

        #endregion
    }
}