using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson1
{
    public class Database
    {
        private string _name = "Database";

        public string Name
        {
            get { return _name; }
        }

        public static Data operator - (Database database, Data data)
        {
            Data result = database - data;
            return result;
        }

    }
}
