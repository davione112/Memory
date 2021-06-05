using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMemory
{
    public static class GlobalConfig
    {
        // When save to and pull from database and file text and more.
        //public static List<IDataConnection> Connections { get; private set; }

        //When save to and pull from database
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnection(bool database)
        {
            if (database)
            {
                // Create SQL connection.
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }
        }
    }
}
