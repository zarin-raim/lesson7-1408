using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson1
{
    public class Bit
    {
        private string _name = "Bit";

        public string Name
        {
            get { return _name; }
        }

        public static Data operator + (Bit bit1, Bit bit2)
        {
            Data result = bit1 + bit2;
            return result;
        }

    }
}
