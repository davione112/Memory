using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryMemory;
using ClassLibraryMemory.Models;
using ClassLibraryMemory.DataAccess;

namespace MemoryUI
{
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }
        private void SubjectButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                Subject subject = new Subject();
                subject.SubjectName = SubjectNameValue.Text;
                try
                {
                    GlobalConfig.Connection.CreateSubject(subject);
                }
                catch (Exception)
                {
                    MessageBox.Show("Duplicate value. Please try it again!");
                }
                SubjectNameValue.ResetText();
            }
            else
            {
                MessageBox.Show("Invalid value. Please try it again!");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            if (SubjectNameValue.TextLength <= 3 || SubjectNameValue.TextLength >= 100)
            {
                output = false;
            }
            return output;
        }
    }
}
