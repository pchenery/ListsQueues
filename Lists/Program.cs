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
            Console.WriteLine("Count {0}", Sll.Count());
            Sll.DisplayNodes();
            Console.ReadLine();

            DoublyLinkedList Dll = new DoublyLinkedList();
            Dll.AddLast("bob");
            Dll.AddLast("mary");
            Dll.AddLast("ted");

            Dll.Delete("mary");
            Console.WriteLine("Count {0}", Dll.Count());
            Dll.DisplayNodes();
            Console.ReadLine();

            Array arr = new Array();
            arr.AddLast("bob");
            arr.AddLast("mary");
            arr.AddLast("ted");

            arr.Delete("mary");
            Console.WriteLine("Count {0}", arr.Count());
            arr.DisplayData();
            Console.ReadLine();

        }
    }
}
