using System.ComponentModel;

namespace Lab5_CSHARP.Windows
{
    partial class GiveBookReaderDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBooks = new System.Windows.Forms.ComboBox();
            this.buttonChooseReader = new System.Windows.Forms.Button();
            this.buttonGive = new System.Windows.Forms.Button();
            this.comboBoxReaders = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(52, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Читач:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(52, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Книга:";
            // 
            // comboBoxBooks
            // 
            this.comboBoxBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBooks.Enabled = false;
            this.comboBoxBooks.FormattingEnabled = true;
            this.comboBoxBooks.Location = new System.Drawing.Point(126, 95);
            this.comboBoxBooks.Name = "comboBoxBooks";
            this.comboBoxBooks.Size = new System.Drawing.Size(356, 32);
            this.comboBoxBooks.TabIndex = 4;
            // 
            // buttonChooseReader
            // 
            this.buttonChooseReader.Location = new System.Drawing.Point(488, 57);
            this.buttonChooseReader.Name = "buttonChooseReader";
            this.buttonChooseReader.Size = new System.Drawing.Size(166, 32);
            this.buttonChooseReader.TabIndex = 3;
            this.buttonChooseReader.Text = "Обрати";
            this.buttonChooseReader.UseVisualStyleBackColor = true;
            this.buttonChooseReader.Click += new System.EventHandler(this.buttonChooseReader_Click);
            // 
            // buttonGive
            // 
            this.buttonGive.Enabled = false;
            this.buttonGive.Location = new System.Drawing.Point(488, 95);
            this.buttonGive.Name = "buttonGive";
            this.buttonGive.Size = new System.Drawing.Size(166, 32);
            this.buttonGive.TabIndex = 5;
            this.buttonGive.Text = "Видати";
            this.buttonGive.UseVisualStyleBackColor = true;
            this.buttonGive.Click += new System.EventHandler(this.buttonGive_Click);
            // 
            // comboBoxReaders
            // 
            this.comboBoxReaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReaders.FormattingEnabled = true;
            this.comboBoxReaders.Location = new System.Drawing.Point(126, 58);
            this.comboBoxReaders.Name = "comboBoxReaders";
            this.comboBoxReaders.Size = new System.Drawing.Size(356, 32);
            this.comboBoxReaders.TabIndex = 3;
            // 
            // GiveBookReaderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 181);
            this.Controls.Add(this.comboBoxReaders);
            this.Controls.Add(this.buttonGive);
            this.Controls.Add(this.buttonChooseReader);
            this.Controls.Add(this.comboBoxBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(735, 220);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(735, 220);
            this.Name = "GiveBookReaderDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Видати книгу";
            this.Load += new System.EventHandler(this.GiveBookReaderDialog_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox comboBoxBooks;

        private System.Windows.Forms.Button buttonChooseReader;
        private System.Windows.Forms.Button buttonGive;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxReaders;

        #endregion
    }
}