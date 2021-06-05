using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryUI
{
    public partial class MemmoryViewer : Form
    {
        private ClsTreeListView clsTreeListView = new ClsTreeListView();
        public MemmoryViewer()
        {
            InitializeComponent();
        }

        private void MemmoryViewer_Load(object sender, EventArgs e)
        {
            clsTreeListView.CreateTreeView(this.treeView);
        }
    }
}
