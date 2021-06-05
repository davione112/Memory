using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMemory
{
    public class SQLConnector : IDataConnection
    {
        public Chapter CreateChapter(Chapter model)
        {
            model.ID = 1;
            return model;
        }
    }
}
