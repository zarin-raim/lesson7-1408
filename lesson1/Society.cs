using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson1
{
    public class Society
    {
        private string _name = "Society";

        public string Name
        {
            get { return _name; }
        }

        public static Human operator - (Society society, Human human)
        {
            return new Human();
        }
    }
}
