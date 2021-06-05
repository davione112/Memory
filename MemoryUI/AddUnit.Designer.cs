
namespace MemoryUI
{
    partial class AddUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUnit));
            this.UnitLabel = new System.Windows.Forms.Label();
            this.UnitNameValue = new System.Windows.Forms.TextBox();
            this.UnitButton = new System.Windows.Forms.Button();
            this.UnitLabel2 = new System.Windows.Forms.Label();
            this.UnitLabel1 = new System.Windows.Forms.Label();
            this.comboBoxUnit1 = new System.Windows.Forms.ComboBox();
            this.comboBoxUnit2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UnitLabel
            // 
            this.UnitLabel.AutoSize = true;
            this.UnitLabel.Location = new System.Drawing.Point(290, 369);
            this.UnitLabel.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.UnitLabel.Name = "UnitLabel";
            this.UnitLabel.Size = new System.Drawing.Size(160, 37);
            this.UnitLabel.TabIndex = 1;
            this.UnitLabel.Text = "Unit Name";
            this.UnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitNameValue
            // 
            this.UnitNameValue.Location = new System.Drawing.Point(97, 409);
            this.UnitNameValue.Name = "UnitNameValue";
            this.UnitNameValue.Size = new System.Drawing.Size(557, 45);
            this.UnitNameValue.TabIndex = 2;
            // 
            // UnitButton
            // 
            this.UnitButton.Location = new System.Drawing.Point(278, 460);
            this.UnitButton.Name = "UnitButton";
            this.UnitButton.Size = new System.Drawing.Size(193, 49);
            this.UnitButton.TabIndex = 3;
            this.UnitButton.Text = "Add Unit";
            this.UnitButton.UseVisualStyleBackColor = true;
            this.UnitButton.Click += new System.EventHandler(this.UnitButton_Click);
            // 
            // UnitLabel2
            // 
            this.UnitLabel2.AutoSize = true;
            this.UnitLabel2.Location = new System.Drawing.Point(271, 197);
            this.UnitLabel2.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.UnitLabel2.Name = "UnitLabel2";
            this.UnitLabel2.Size = new System.Drawing.Size(206, 37);
            this.UnitLabel2.TabIndex = 4;
            this.UnitLabel2.Text = "Chapter Name";
            this.UnitLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitLabel1
            // 
            this.UnitLabel1.AutoSize = true;
            this.UnitLabel1.Location = new System.Drawing.Point(277, 59);
            this.UnitLabel1.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.UnitLabel1.Name = "UnitLabel1";
            this.UnitLabel1.Size = new System.Drawing.Size(200, 37);
            this.UnitLabel1.TabIndex = 5;
            this.UnitLabel1.Text = "Subject Name";
            this.UnitLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxUnit1
            // 
            this.comboBoxUnit1.FormattingEnabled = true;
            this.comboBoxUnit1.Location = new System.Drawing.Point(97, 99);
            this.comboBoxUnit1.Name = "comboBoxUnit1";
            this.comboBoxUnit1.Size = new System.Drawing.Size(557, 45);
            this.comboBoxUnit1.TabIndex = 6;
            this.comboBoxUnit1.SelectedValueChanged += new System.EventHandler(this.comboBoxUnit1_SelectedValueChanged);
            // 
            // comboBoxUnit2
            // 
            this.comboBoxUnit2.FormattingEnabled = true;
            this.comboBoxUnit2.Location = new System.Drawing.Point(97, 237);
            this.comboBoxUnit2.Name = "comboBoxUnit2";
            this.comboBoxUnit2.Size = new System.Drawing.Size(557, 45);
            this.comboBoxUnit2.TabIndex = 7;
            // 
            // AddUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.comboBoxUnit2);
            this.Controls.Add(this.comboBoxUnit1);
            this.Controls.Add(this.UnitLabel1);
            this.Controls.Add(this.UnitLabel2);
            this.Controls.Add(this.UnitButton);
            this.Controls.Add(this.UnitNameValue);
            this.Controls.Add(this.UnitLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "AddUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding New Unit";
            this.Load += new System.EventHandler(this.AddUnit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UnitLabel;
        private System.Windows.Forms.TextBox UnitNameValue;
        private System.Windows.Forms.Button UnitButton;
        private System.Windows.Forms.Label UnitLabel2;
        private System.Windows.Forms.Label UnitLabel1;
        private System.Windows.Forms.ComboBox comboBoxUnit1;
        private System.Windows.Forms.ComboBox comboBoxUnit2;
    }
}