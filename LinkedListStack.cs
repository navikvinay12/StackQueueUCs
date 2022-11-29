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
        public int Peek()      //Displaying the topmost element in the stack.
        {
            if(top==null)
            {
                Console.WriteLine("List is Empty");
                return 0;
            }
            else
            {
                Console.WriteLine("Top most element is : " + top.data);
                return top.data;
            }
        }
        public void Pop()       //removing the topmost element from the stack .
        {
            if (top == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Console.WriteLine("Removed top most element : " + Peek());
                top = top.next;
            }
        }
        public bool isEmpty()
        {
            if(top==null)
            {
                Console.WriteLine("Stack is Empty");
                return true;
            }
            else
            {
                while(top!=null)
                {
                    Pop();
                }
                return true;
            }
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
