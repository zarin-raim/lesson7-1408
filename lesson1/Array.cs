using System;
using System.Collections.Generic;
using System.Text;

namespace lesson1
{
    public class Array
    {
        private object[] array;
        private int size;

        public int GetSize()
        {
            return size;
        }

#region Constructors
        public Array()
        {
            size = 0;
            array = new object[size];
        }

        public Array(int size)
        {
            array = new object[size];
            this.size = size;
        }
#endregion
#region Methods
        public void Add(object data, int position)
        {
            object[] temp = new object[size + 1];

            if (position == 0)
            {
                temp[0] = data;
                array.CopyTo(temp, 1);
            }
            else if (position == size)
            {
                array.CopyTo(temp, 0);
                temp[position] = data;
            }
            else if (position < size)
            {
                for (int i = 0; i < position; i++)
                {
                    temp[i] = array[i];
                }
                temp[position] = data;
                for (int i = position + 1; i < temp.Length; i++)
                {
                    temp[i] = array[i - 1];
                }
            }
            else if (position > size)
            {
                temp = new object[position];
                array.CopyTo(temp, 0);
                temp[position - 1] = data;
            }
            this.size++;
            array = temp;
        }
        public void Rewrite(object data, int position)
        {
            array[position] = data;
        }
        public void RemoveByPosition(int position)
        {
            object[] temp = new object[size + 1];

            if (position == 0)
            {
                array.CopyTo(temp, 1);
            }
            else if (position == size)
            {
                array.CopyTo(temp, 0);
            }
            else if (position < size)
            {
                for (int i = 0; i < position; i++)
                {
                    temp[i] = array[i];
                }
                for (int i = position + 1; i < temp.Length; i++)
                {
                    temp[i] = array[i - 1];
                }
            }
            else if (position > size)
            {
                temp = new object[position];
                array.CopyTo(temp, 0);
            }
            size--;
            array = temp;
        }
        public void Remove(object data)
        {
            int position = 0;
            for (int i = 0; i < array.Length; i++)
            {
                object temp = array[i];
                if (temp.Equals(65))
                    position = i;
            }
            RemoveByPosition(position);
        }
        public object GetObject(int position)
        {
            try
            {
                if (position < size)
                    return array[position];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
#endregion
       
    }
}
