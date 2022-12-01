namespace StackUsingLinkedListMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack Program in Data Structures");
            Console.WriteLine("Please select as per the below given options :\n" +
                "Press 1: Creating custom stack using LinkedList.\n" +
                "Press 2: Using Peek and Pop in stack.\n" +
                "Press 3: Using Enque in Queue.\n" +
                "Press 4: Using Deque in Queue.\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    LinkedListStack stackObject=new LinkedListStack();
                    stackObject.Push(70);
                    stackObject.Push(30);
                    stackObject.Push(56);
                    stackObject.Display();
                    break;
                case 2: //UC2 stack. Add 56 30 70 .  (peek -display top most element) (pop -removing top-most element)
                    LinkedListStack stackObject1 = new LinkedListStack();
                    stackObject1.Push(70);
                    stackObject1.Push(30);
                    stackObject1.Push(56);
                    stackObject1.Display(); //IsEmpty() internally calling Pop() and Pop() internally calling Peek().
                    Console.WriteLine("Is list is empty? "+ stackObject1.isEmpty());    
                    stackObject1.Display();
                    break;
                case 3: //UC3 Enque. Add sequence 56 30 70 and displaying .
                    LinkedListQueue queueObj = new LinkedListQueue();
                    queueObj.Enque(56);
                    queueObj.Enque(30);
                    queueObj.Enque(70);
                    queueObj.Display();
                    break;
                case 4: //UC4 Deque. 
                    LinkedListQueue queueObj1 = new LinkedListQueue();
                    queueObj1.Enque(56);
                    queueObj1.Enque(30);
                    queueObj1.Enque(70);
                    queueObj1.Display();
                    queueObj1.Deque();
                    queueObj1.Display();
                    queueObj1.Deque();
                    queueObj1.Display();
                    queueObj1.Deque();
                    queueObj1.Display();
                    break;
                default:
                    break;
            }
        }
    }
}