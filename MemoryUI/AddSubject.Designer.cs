
namespace MemoryUI
{
    partial class AddSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubject));
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.SubjectNameValue = new System.Windows.Forms.TextBox();
            this.SubjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(192, 42);
            this.SubjectLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(200, 37);
            this.SubjectLabel.TabIndex = 0;
            this.SubjectLabel.Text = "Subject Name";
            this.SubjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubjectNameValue
            // 
            this.SubjectNameValue.Location = new System.Drawing.Point(13, 82);
            this.SubjectNameValue.Name = "SubjectNameValue";
            this.SubjectNameValue.Size = new System.Drawing.Size(557, 45);
            this.SubjectNameValue.TabIndex = 1;
            // 
            // SubjectButton
            // 
            this.SubjectButton.Location = new System.Drawing.Point(183, 163);
            this.SubjectButton.Name = "SubjectButton";
            this.SubjectButton.Size = new System.Drawing.Size(193, 49);
            this.SubjectButton.TabIndex = 2;
            this.SubjectButton.Text = "Add Subject";
            this.SubjectButton.UseVisualStyleBackColor = true;
            this.SubjectButton.Click += new System.EventHandler(this.SubjectButton_Click);
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.SubjectButton);
            this.Controls.Add(this.SubjectNameValue);
            this.Controls.Add(this.SubjectLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "AddSubject";
            this.Text = "Adding New Subject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.TextBox SubjectNameValue;
        private System.Windows.Forms.Button SubjectButton;
    }
}