using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedListMethods
{
    public class LinkedListQueue
    {
        Node head = null;
        public void Enque(int data)     //UC3 Enque 56 30 70 . (Enque means adding the element at first place in Queue)
        {
            Node newNode = new Node(data);
            if(head==null)
            {
                head=newNode;
                Console.WriteLine($"{newNode.data} is inserted into Queue.");
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp= temp.next;
                }
                temp.next= newNode;
                Console.WriteLine($"{newNode.data} is inserted into Queue.");
            }
        }
        public void Display()       //Display() .
        {
            Node temp = this.head;
            Console.Write("Displaying Nodes : ");
            if(temp==null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while(temp!=null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
        }
    }
}
