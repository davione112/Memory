using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMemory.Models
{
    public class Concept
    {
        public int ID { get; set; }
        public string ConceptName { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
        public string Content { get; set; }
    }
}
