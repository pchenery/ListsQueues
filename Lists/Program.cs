using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList Sll = new SinglyLinkedList();
            Sll.AddLast("bob");
            Sll.AddLast("mary");
            Sll.AddLast("ted");

            Sll.Delete("mary");

            Sll.DisplayNodes();
            Console.ReadLine();
        }
    }
}
