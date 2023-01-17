using System;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linked List Program \n - - - - - - - - - - - - - - - - -");
            LinkedList linkedlist = new LinkedList();
            Node node1 = new Node(70);
            Node node2 = new Node(30);
            Node node3 = new Node(56);

            //linkedlist.AppendNode(node1);
            //linkedlist.AppendNode(node2);
            //linkedlist.AppendNode(node3);



            linkedlist.AddNode(node1);
            //linkedlist.AddNode(node2);
            linkedlist.AddNode(node3);
            linkedlist.InsertNode(node2, node3);

            //linkedlist.DeleteNodeAtFirst();
            linkedlist.DeleteNodeAtLast();
            linkedlist.Display();
        }
    }
}