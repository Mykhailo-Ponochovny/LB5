using System.ComponentModel;

namespace Lab5_CSHARP.Windows
{
    partial class BackBookDialog
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
            this.comboBoxReaders = new System.Windows.Forms.ComboBox();
            this.buttonChooseReader = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBooks = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(69, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Читач:";
            // 
            // comboBoxReaders
            // 
            this.comboBoxReaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReaders.FormattingEnabled = true;
            this.comboBoxReaders.Location = new System.Drawing.Point(145, 56);
            this.comboBoxReaders.Name = "comboBoxReaders";
            this.comboBoxReaders.Size = new System.Drawing.Size(382, 32);
            this.comboBoxReaders.TabIndex = 1;
            // 
            // buttonChooseReader
            // 
            this.buttonChooseReader.Location = new System.Drawing.Point(533, 56);
            this.buttonChooseReader.Name = "buttonChooseReader";
            this.buttonChooseReader.Size = new System.Drawing.Size(134, 32);
            this.buttonChooseReader.TabIndex = 2;
            this.buttonChooseReader.Text = "Обрати";
            this.buttonChooseReader.UseVisualStyleBackColor = true;
            this.buttonChooseReader.Click += new System.EventHandler(this.buttonChooseReader_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(69, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Книга:";
            // 
            // comboBoxBooks
            // 
            this.comboBoxBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBooks.Enabled = false;
            this.comboBoxBooks.FormattingEnabled = true;
            this.comboBoxBooks.Location = new System.Drawing.Point(145, 94);
            this.comboBoxBooks.Name = "comboBoxBooks";
            this.comboBoxBooks.Size = new System.Drawing.Size(382, 32);
            this.comboBoxBooks.TabIndex = 4;
            // 
            // buttonBack
            // 
            this.buttonBack.Enabled = false;
            this.buttonBack.Location = new System.Drawing.Point(533, 93);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(134, 32);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Повернути";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // BackBookDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 196);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonChooseReader);
            this.Controls.Add(this.comboBoxReaders);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 235);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(780, 235);
            this.Name = "BackBookDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Повернення книги";
            this.Load += new System.EventHandler(this.BackBookDialog_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBooks;
        private System.Windows.Forms.Button buttonBack;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxReaders;
        private System.Windows.Forms.Button buttonChooseReader;

        #endregion
    }
}