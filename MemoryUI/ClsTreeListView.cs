using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryMemory.DataAccess;
using ClassLibraryMemory;
using ClassLibraryMemory.Models;

namespace MemoryUI
{
    class ClsTreeListView
    {
        public void CreateTreeView(TreeView treeView)
        {
            // Highest Node.
            //TreeNode ListSubjects = new TreeNode("My Memmory", 0, 0);
            //treeView.Nodes.Add(ListSubjects);

            // Subject Nodes
            TreeNodeCollection nodeCollection1;
            
            // Get subjectName.
            List<String> ListSubjectsName = GlobalConfig.Connection.GetSubjectName();
            // Get chapterName.
            List<String> ListChaptersName = GlobalConfig.Connection.GetChapterName();
            // Get unitName.
            List<String> ListUnitsName = GlobalConfig.Connection.GetUnitName();

            foreach (String i in ListSubjectsName)
            {
                TreeNode tn = new TreeNode(i, 0, 0);
                treeView.Nodes.Add(tn);
                TreeNodeCollection nodeCollection2 = tn.Nodes;
                foreach(String j in ListChaptersName){
                    TreeNode tn_chapter = new TreeNode(j, 0, 0);
                    nodeCollection2.Add(tn_chapter);
                }
            }
        }
    }
}
