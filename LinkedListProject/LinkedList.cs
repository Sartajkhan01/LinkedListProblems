using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{

    public class LinkedList
    {
        public Node Head;
        public Node Tail;

        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {
            if (Head == null & Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
        public void AppendNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }
        public bool Search(int value)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        public void InsertNode(Node newNode, Node previousNOde)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.data == previousNOde.data)
                {
                    if (temp == Tail)
                    {
                        Tail = newNode;
                    }
                    newNode.next = temp.next;
                    temp.next = newNode;
                    break;
                }
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("node not found");
            }
        }
        public void DeleteNodeAtFirst()
        {
            if (this.Head == null)
            {
                Console.WriteLine("List is empty, nothing to be deleted ");
            }
            Node temp = this.Head;
            this.Head = Head.next;
            Console.WriteLine("{0} removed from the list ", temp.data);
        }
        public void Display()
        {
            Node temp = Head;
            if (temp == null)
            {
                Console.WriteLine("The Linked List is empty ");
            }
            else
            {
                Console.WriteLine("The Linked List : ");
                while (temp != null)
                {
                    Console.Write(temp.data);
                    if (temp.next != null)
                    {
                        Console.Write(" -> ");
                    }
                    temp = temp.next;
                }
            }
        }
    }
}
