using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson1
{
    public class Developer
    {
        private string _name = "Developer";

        public string Name
        {
            get { return _name; }
        }

        public static Human operator -(Developer developer, Bit bit)
        {
            Human result = developer - bit;
            return result;
        }

    }
}
