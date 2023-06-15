using System.ComponentModel;

namespace Lab5_CSHARP.Windows
{
    partial class AddReaderDialog
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReaderSurname = new System.Windows.Forms.TextBox();
            this.textBoxReaderName = new System.Windows.Forms.TextBox();
            this.numericUpDownReaderNumber = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReaderNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(94, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прізвище:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(146, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(52, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер читача:";
            // 
            // textBoxReaderSurname
            // 
            this.textBoxReaderSurname.Location = new System.Drawing.Point(200, 62);
            this.textBoxReaderSurname.Name = "textBoxReaderSurname";
            this.textBoxReaderSurname.Size = new System.Drawing.Size(248, 29);
            this.textBoxReaderSurname.TabIndex = 3;
            // 
            // textBoxReaderName
            // 
            this.textBoxReaderName.Location = new System.Drawing.Point(200, 97);
            this.textBoxReaderName.Name = "textBoxReaderName";
            this.textBoxReaderName.Size = new System.Drawing.Size(248, 29);
            this.textBoxReaderName.TabIndex = 4;
            // 
            // numericUpDownReaderNumber
            // 
            this.numericUpDownReaderNumber.Location = new System.Drawing.Point(200, 132);
            this.numericUpDownReaderNumber.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.numericUpDownReaderNumber.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericUpDownReaderNumber.Name = "numericUpDownReaderNumber";
            this.numericUpDownReaderNumber.Size = new System.Drawing.Size(248, 29);
            this.numericUpDownReaderNumber.TabIndex = 5;
            this.numericUpDownReaderNumber.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(236, 167);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(159, 34);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Додати";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AddReaderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 251);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownReaderNumber);
            this.Controls.Add(this.textBoxReaderName);
            this.Controls.Add(this.textBoxReaderSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(590, 290);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(590, 290);
            this.Name = "AddReaderDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Додати читача";
            this.Load += new System.EventHandler(this.AddReaderDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReaderNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReaderSurname;
        private System.Windows.Forms.TextBox textBoxReaderName;
        private System.Windows.Forms.NumericUpDown numericUpDownReaderNumber;
        private System.Windows.Forms.Button buttonSave;

        #endregion
    }
}