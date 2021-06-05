using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMemory
{
    public interface IDataConnection
    {
        Chapter CreateChapter(Chapter model);
    }
}
