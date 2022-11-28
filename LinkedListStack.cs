using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedListMethods
{
    public class LinkedListStack
    {
        public Node top;
        public void Push(int data)      //UC1 .
        {
            Node newNode = new Node(data);
            if(top!=null)
            {
                newNode.next=top;   //newNode will start holding the address which was earlier holding by top.
            }
            top = newNode;  //top will start pointing to newNode.
            Console.WriteLine($"New Node {data} is added.");
        }

        public void Display()           //Display()
        {
            Console.WriteLine("Displaying Nodes ");
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("Value in the stack : "+temp.data);
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }
    }
}
