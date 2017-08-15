using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson1
{
    public class Data
    {
        private string _name = "Data";

        public string Name
        {
            get { return _name; }
        }

        public static Database operator + (Data data1, Data data2)
        {
            return new Database();
        }

        public static Bit operator -(Data data, Bit bit)
        {
            return new Bit();
        }
    }
}
