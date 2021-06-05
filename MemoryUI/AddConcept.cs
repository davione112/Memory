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
using ClassLibraryMemory.DataAccess;
using ClassLibraryMemory.Models;

namespace MemoryUI
{
    public partial class AddConcept : Form
    {
        public AddConcept()
        {
            InitializeComponent();
        }

        private void AddConceptButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Concept concept = new Concept();
                concept.ConceptName = ConceptNameValue.Text;
                concept.Author = AuthorValue.Text;
                concept.Year = YearValue.Text; 
                concept.Content = ContentValue.Text;
                GlobalConfig.Connection.CreateConcept(concept);

                //try
                //{
                //    GlobalConfig.Connection.CreateConcept(concept);
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Duplicate value. Please try it again!");
                //}
                //ConceptNameValue.ResetText();
            }
            else
            {
                MessageBox.Show("Invalid value. Please try it again!");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            if (ConceptNameValue.TextLength <= 3 || ConceptNameValue.TextLength >= 100)
            {
                output = false;
            }
            if(AuthorValue.TextLength <=0 || AuthorValue.TextLength >= 200)
            {
                output = false;
            }
            if(YearValue.TextLength <1 || YearValue.TextLength > 15)
            {
                output = false;
            }
            if (ContentValue.TextLength < 5)
            {
                output = false;
            }
            return output;
        }

        private void AddConcept_Load(object sender, EventArgs e)
        {
            List<String> subjectNames = GlobalConfig.Connection.GetSubjectName();
            comboBoxConcept1.DataSource = subjectNames;
        }

        private void comboBoxConcept1_SelectedValueChanged(object sender, EventArgs e)
        {
            // clear current box.
            comboBoxConcept2.SelectedIndex = -1;

            // load data
            List<String> chapterNames = GlobalConfig.Connection.GetChapterbySubject(comboBoxConcept1.SelectedItem.ToString());
            comboBoxConcept2.DataSource = chapterNames;
        }

        private void comboBoxConcept3_SelectedValueChanged(object sender, EventArgs e)
        {
            // clear current box.
            comboBoxConcept3.SelectedIndex = -1;

            // load data
            List<String> chapterNames = GlobalConfig.Connection.GetChapterbySubject(comboBoxConcept2.SelectedItem.ToString());
            comboBoxConcept3.DataSource = chapterNames;
        }
    }
}
