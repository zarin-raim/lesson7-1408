using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Bit bit = new Bit();
            Bit bit1 = new Bit();


            Console.WriteLine((bit + bit1).Name);
            Console.WriteLine(((bit + bit1) + (bit + bit1)).Name);

            Console.WriteLine((bit + bit).Name);
            Console.WriteLine(((bit + bit) + (bit + bit)).Name);


            Console.ReadLine();

            //Menu menu = new Menu();
            //char key = ' ';
            //while (true)
            //{
            
            //}
        }
    }
}
