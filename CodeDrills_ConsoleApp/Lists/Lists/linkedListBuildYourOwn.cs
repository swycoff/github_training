using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class linkedListBuildYourOwn
    {
        //Tutorial: https://www.youtube.com/watch?v=lcNL_HLpcEs
        //Lookup: LinkedList<T> from Systems.Collections.Generic

        //You can make this class here or a separate class.
        public class Node
        {
            public int data;
            public Node next;

            //constructor
            public Node(int i)
            {
                data = i;
                next = null;
            }
            public void Print()
            {
                //This will print the node (the first one only)
                Console.Write("|" + data + "|->");
                //If we want all the nodes to print we have to use recursion to call print within print method.
                if (next != null)
                {
                    next.Print();
                }
            }
            public void AddToEnd(int data)
            {
                if (next == null) // we know we are at the end of the list
                {
                    next = new Node(data);
                }
                else
                {
                    //This is recursive as well because its calling AddToEnd from within AddToEnd
                    next.AddToEnd(data);
                    //What this does then is it starts the method over in which its checking to see if next = null above
                    //So essentially it passes this check responsibliity from node to node until it finds the end node.
                }

            }

        }
        public class MyList
        {
            public Node headNode;
            public MyList()
            {
                headNode = null;
            }
            public void AddToEnd(int data)
            {
                //if headnode is null its not yet a valid created node
                if (headNode == null)
                {
                    headNode = new Node(data);
                }
                else
                {
                    headNode.AddToEnd(data);
                }
            }
            public void AddToBeginning(int data)
            {
                if (headNode == null)
                {
                    //this would be the first node in the list
                    headNode = new Node(data);
                }
                else
                {
                    //if its not null we need to create a temp node
                    Node temp = new Node(data);
                    //temp.Next = headNode means that its setting the pointer reference from temp to the first in the list which is headNode.
                    temp.next = headNode;
                    headNode = temp;
                }
            }
            public void Print()
            {
                if (headNode != null)
                {
                    headNode.Print();
                }
            }
        }
        class LinkedLists
        {
            public static void workWithLinkedLists()
            {
                //Instantiates the class and with the constructor adds the first node.
                //Node myNode = new Node(7);
                ////Uses .Next to add the second node
                //myNode.next = new Node(5);
                ////Uses .Next to add the third node
                //myNode.next.next = new Node(11);
                //myNode.next.next.next = new Node(4);
                //Try printing
                //myNode.Print();

                //Replace original code with AddToEndMethod
                //Node myNode = new Node(7);
                //myNode.AddToEnd(5);
                //myNode.AddToEnd(11);
                //myNode.AddToEnd(4);
                //Try printing
                //myNode.Print();

                //Third iteration replacing nodes with the list.
                MyList list = new MyList();
                list.AddToEnd(9);
                list.AddToEnd(5);
                list.AddToEnd(7);
                list.AddToEnd(7);
                list.Print();

            }
        }
    }
}
