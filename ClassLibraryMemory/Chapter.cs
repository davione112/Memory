using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMemory
{
    public class Chapter
    {
        public int ID { get; set; }
        public string ChapterName { get; set; }
        public List<Unit> ListUnits { get; set; } = new List<Unit>();
    }
}
