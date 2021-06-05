
namespace MemoryUI
{
    partial class AddChapter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChapter));
            this.ChapterLabel = new System.Windows.Forms.Label();
            this.ChapterNameValue = new System.Windows.Forms.TextBox();
            this.ChapterButton = new System.Windows.Forms.Button();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.SubjectSelectedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChapterLabel
            // 
            this.ChapterLabel.AutoSize = true;
            this.ChapterLabel.Location = new System.Drawing.Point(277, 151);
            this.ChapterLabel.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.ChapterLabel.Name = "ChapterLabel";
            this.ChapterLabel.Size = new System.Drawing.Size(206, 37);
            this.ChapterLabel.TabIndex = 2;
            this.ChapterLabel.Text = "Chapter Name";
            this.ChapterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChapterNameValue
            // 
            this.ChapterNameValue.Location = new System.Drawing.Point(132, 205);
            this.ChapterNameValue.Name = "ChapterNameValue";
            this.ChapterNameValue.Size = new System.Drawing.Size(557, 45);
            this.ChapterNameValue.TabIndex = 3;
            // 
            // ChapterButton
            // 
            this.ChapterButton.Location = new System.Drawing.Point(281, 271);
            this.ChapterButton.Name = "ChapterButton";
            this.ChapterButton.Size = new System.Drawing.Size(202, 49);
            this.ChapterButton.TabIndex = 4;
            this.ChapterButton.Text = "Add Chapter";
            this.ChapterButton.UseVisualStyleBackColor = true;
            this.ChapterButton.Click += new System.EventHandler(this.ChapterButton_Click);
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(132, 80);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(557, 45);
            this.comboBoxSubject.TabIndex = 5;
            // 
            // SubjectSelectedLabel
            // 
            this.SubjectSelectedLabel.AutoSize = true;
            this.SubjectSelectedLabel.Location = new System.Drawing.Point(277, 18);
            this.SubjectSelectedLabel.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.SubjectSelectedLabel.Name = "SubjectSelectedLabel";
            this.SubjectSelectedLabel.Size = new System.Drawing.Size(224, 37);
            this.SubjectSelectedLabel.TabIndex = 6;
            this.SubjectSelectedLabel.Text = "Subject selected";
            this.SubjectSelectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddChapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.SubjectSelectedLabel);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.ChapterButton);
            this.Controls.Add(this.ChapterNameValue);
            this.Controls.Add(this.ChapterLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "AddChapter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding New Chapter";
            this.Load += new System.EventHandler(this.AddChapter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChapterLabel;
        private System.Windows.Forms.TextBox ChapterNameValue;
        private System.Windows.Forms.Button ChapterButton;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label SubjectSelectedLabel;
    }
}