using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class SinglyLinkedList
    {
        private Node head;
        private Node current;
        private int count;

        public void AddLast(string value)
        {
            if (head == null)
            {
                Node newNode = new Node();
                newNode.Data = value;
                //current.Next = newNode;
                head = newNode;
                current = head;
                count++;
            }
            else
            {
                Node newNode = new Node();
                newNode.Data = value;
                current.Next = newNode;
                current = newNode;
                count++;
            }
        }

        public bool Contains(string value)
        {
            return Find(value);
        }

        private bool Find(string value)
        {
            //Node previousNode = null;
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Data == value)
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }

        public void Delete(string value)
        {
            Node previousNode = null;
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Data == value)
                {
                    if (previousNode == null)
                    {
                        head = currentNode.Next;
                    }
                    else
                    {
                        previousNode.Next = currentNode.Next;
                    }
                    count--;
                    return;
                }
                else
                {
                    previousNode = currentNode;
                }
                currentNode = currentNode.Next;
            }
        }

        public void DisplayNodes()
        {
            Node curr = head;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(curr.Data);
                curr = curr.Next;
            }
        }

        public int Count()
        {
            return count;
        }

        public SinglyLinkedList()
        {
            this.head = null;
            this.count = 0;
        }

        private class Node
        {
            public Node Next { get; set; }
            public string Data { get; set; }

            public Node(string data)
            {
                this.Data = data;
            }

            public Node()
            {
            }
        }
    }
}
