﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMemory
{
    public class Subject
    {
        public string SubjectName { get; set;}
        public List<Chapter> ListChapters { get; set; } = new List<Chapter>();
    }
}
