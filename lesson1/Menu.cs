using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson1
{
    class Menu
    {
        Array array;

        public Menu()
        {
            array = new Array();

            array.Add(new Bit(), array.GetSize());
            array.Add(new Human(), array.GetSize());

            DrawMenu();
        }

        public void DrawMenu()
        {
            Console.WriteLine
            (
                "1 - Доступные элементы\n" +
                "2 - Сложить\n" +
                "3 - Вычесть\n"    
            );
        }       

        public void Handler(char key)
        {
            switch (key)
            {
                case '1':
                    {
                        for(int i = 0; i < array.GetSize(); i++)
                        {
                            //Console.WriteLine(i + " - " + array.GetObject(i).Name);
                        }
                    }
                    break;
                case '0': break;
            }
        }
    }
}
