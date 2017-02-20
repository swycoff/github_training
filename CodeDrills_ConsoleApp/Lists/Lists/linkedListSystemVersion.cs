using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class linkedListSystemVersion
    {
        public void linkedListBasics()
        {
            LinkedListNode<int> one = new LinkedListNode<int>(1);
            LinkedListNode<int> two = new LinkedListNode<int>(2);
            LinkedListNode<int> three = new LinkedListNode<int>(3);
            LinkedListNode<int> four = new LinkedListNode<int>(4);

            //Declare a linked list
            LinkedList<int> newLinkedList1 = new LinkedList<int>();
            newLinkedList1.AddFirst(one);
            newLinkedList1.AddLast(three);
            newLinkedList1.AddBefore(three, two);
            newLinkedList1.AddAfter(three, four);
            

            //Working with the nodes and their pointers
            //This is an new node assigned a default 0 value for now.
            LinkedListNode<int> nodeCopy = new LinkedListNode<int>(0);
            //This is trying to use the linked list to find the value of the node named one and the node after 
            //that, that its pointing to. It should be 2.
            int valueLookingForInList = one.Next.Value;
            nodeCopy = newLinkedList1.Find(valueLookingForInList);


            foreach (int node in newLinkedList1)
            {
                //Outputs 1,2,3,4
                Console.WriteLine(node.ToString());
            }
            //Outputs the 2 we saved above
            Console.WriteLine(nodeCopy.Value.ToString());
            Console.ReadLine();
            
        }
    }
}
