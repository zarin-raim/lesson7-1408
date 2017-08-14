using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson1
{
    public class Human
    {
        private string _name = "Human";

        public string Name
        {
            get { return _name; }
        }

        public static Society operator + (Human human1, Human human2)
        {
            Society result = human1 + human2;
            return result;
        }

        public static Developer operator + (Human human, Bit bit)
        {
            Developer result = human + bit;
            return result;
        }

    }
}
