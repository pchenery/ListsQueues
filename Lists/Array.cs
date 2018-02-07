using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class Array
    {
        private string[] myList = new string [100];
        private int count;

        public void AddLast(string value)
        {
            myList[count] = value;
            count++;            
        }

        public void Delete (string value)
        {
            for (int i = 0; i < count; i++)
            {
                if (myList[i] == value)
                {
                    myList[i] = "";
                    MoveUp(i);
                    count--;
                }
            }
        }

        public bool Contains(string value)
        {
            for (int i = 0; i < count; i++)
            {
                if (myList[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public void MoveUp(int index)
        {
            for (int i = index; i < count; i++)
            {
                myList[i] = myList[i + 1];
            }
        }

        public void DisplayData()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }

        public int Count()
        {
            return count;
        }









    }
}
