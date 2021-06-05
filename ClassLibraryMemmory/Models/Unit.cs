using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMemory.Models
{
    public class Unit
    {
        public int ID { get; set; }
        public string UnitName { get; set; }
        public int ChapterID { get; set; }
        public List<Concept> ListConcepts { get; set; } = new List<Concept>();
    }
}
