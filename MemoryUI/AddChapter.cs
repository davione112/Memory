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
    public partial class AddChapter : Form
    {
        public AddChapter()
        {
            InitializeComponent();
        }
        
        private void ChapterButton_Click(object sender,EventArgs e)
        {
            if(ValidateForm())
            {
                Chapter chapter = new Chapter();
                chapter.ChapterName = ChapterNameValue.Text;
                string str_ID =  GlobalConfig.Connection.GetSubjectID(comboBoxSubject.SelectedItem.ToString());
                chapter.SubjectID = Int32.Parse(str_ID);
                try
                {
                    GlobalConfig.Connection.CreateChapter(chapter);
                }
                catch (Exception)
                {
                    MessageBox.Show("Duplicate value. Please try it again!");
                }
                ChapterNameValue.ResetText();
            }
            else
            {
                MessageBox.Show("Invalid value. Please try it again!");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            if(ChapterNameValue.TextLength <= 3 || ChapterNameValue.TextLength>=100)
            {
                output = false;
            }
            return output;
        }
        private void AddChapter_Load(object sender, EventArgs e)
        {
            List<String> ListSubjectsName = GlobalConfig.Connection.GetSubjectName();
            comboBoxSubject.DataSource = ListSubjectsName;
        }
    }
}
