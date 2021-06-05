using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMemory
{
    public class Unit
    {
        public string UnitName { get; set; }
        public List<Concept> ListConcepts { get; set; } = new List<Concept>();
    }
}
