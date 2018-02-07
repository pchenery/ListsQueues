using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class DoublyLinkedList
    {
        private Node head;
        private Node current;
        private Node previous;
        private int count;

        public void AddLast(string value)
        {
            if (head == null)
            {
                Node newNode = new Node();
                newNode.Data = value;
                head = newNode;
                current = head;
                previous = head;
                count++;
            }
            else
            {
                Node newNode = new Node();
                newNode.Data = value;
                newNode.Prev = current;
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
                        currentNode.Next.Prev = currentNode.Prev;
                        currentNode.Prev.Next = currentNode.Next;
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

        public DoublyLinkedList()
        {
            this.head = null;
            this.count = 0;
        }

        private class Node
        {
            public Node Next;
            public Node Prev;
            public string Data;

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
