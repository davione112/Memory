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
    public partial class AddUnit : Form
    {
        public AddUnit()
        {
            InitializeComponent();
        }

        private void UnitButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Unit unit = new Unit();
                unit.UnitName = UnitNameValue.Text;
                unit.ChapterID = Int32.Parse(GlobalConfig.Connection.GetChapterID(comboBoxUnit2.SelectedItem.ToString()));
                try
                {
                    GlobalConfig.Connection.CreateUnit(unit);
                }
                catch (Exception)
                {
                    MessageBox.Show("Duplicate value. Please try it again!");
                }
                UnitNameValue.ResetText();
            }
            else
            {
                MessageBox.Show("Invalid value. Please try it again!");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            if (UnitNameValue.TextLength <= 3 || UnitNameValue.TextLength >= 100)
            {
                output = false;
            }
            return output;
        }

        private void AddUnit_Load(object sender, EventArgs e)
        {
            List<String> subjectNames = GlobalConfig.Connection.GetSubjectName();
            comboBoxUnit1.DataSource = subjectNames;

            //List<String> chapterNames = GlobalConfig.Connection.GetChapterbySubject(comboBoxUnit1.SelectedItem.ToString());
            //comboBoxUnit2.DataSource = chapterNames;
        }

        private void comboBoxUnit1_SelectedValueChanged(object sender, EventArgs e)
        {
            // clear current box.
            comboBoxUnit2.SelectedIndex = -1;

            // load data
            List<String> chapterNames = GlobalConfig.Connection.GetChapterbySubject(comboBoxUnit1.SelectedItem.ToString());
            comboBoxUnit2.DataSource = chapterNames;
        }
    }
}
