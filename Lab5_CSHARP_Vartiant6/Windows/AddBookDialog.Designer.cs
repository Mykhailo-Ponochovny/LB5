using System.ComponentModel;

namespace Lab5_CSHARP_Vartiant6.Windows
{
    partial class AddBookDialog
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.numericUpDownCountPages = new System.Windows.Forms.NumericUpDown();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownBookNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(153, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Автор";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(225, 97);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(217, 29);
            this.textBoxAuthor.TabIndex = 14;
            // 
            // numericUpDownCountPages
            // 
            this.numericUpDownCountPages.Location = new System.Drawing.Point(225, 132);
            this.numericUpDownCountPages.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericUpDownCountPages.Name = "numericUpDownCountPages";
            this.numericUpDownCountPages.Size = new System.Drawing.Size(217, 29);
            this.numericUpDownCountPages.TabIndex = 15;
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(225, 62);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(217, 29);
            this.textBoxBookName.TabIndex = 13;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(276, 203);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(101, 40);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(149, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Номер";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(78, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "К-сть сторінок";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(153, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Назва";
            // 
            // numericUpDownBookNumber
            // 
            this.numericUpDownBookNumber.Location = new System.Drawing.Point(225, 169);
            this.numericUpDownBookNumber.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.numericUpDownBookNumber.Minimum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericUpDownBookNumber.Name = "numericUpDownBookNumber";
            this.numericUpDownBookNumber.Size = new System.Drawing.Size(217, 29);
            this.numericUpDownBookNumber.TabIndex = 18;
            this.numericUpDownBookNumber.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // AddBookDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 311);
            this.Controls.Add(this.numericUpDownBookNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.numericUpDownCountPages);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(590, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(590, 350);
            this.Name = "AddBookDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Додати книгу";
            this.Load += new System.EventHandler(this.AddBookDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown numericUpDownBookNumber;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.NumericUpDown numericUpDownCountPages;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}