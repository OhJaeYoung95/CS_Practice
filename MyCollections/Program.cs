namespace MyCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StackExample();
            //QueueExample();
            ListExample();
        }

        public static void StackExample()
        {
            MyStack<int> myStack = new MyStack<int>();
            Console.WriteLine($"스택의 크기 : {myStack.Count()}");

            // 스택에 요소 추가 (Push)
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);
            myStack.Push(7);
            myStack.Push(8);
            myStack.Push(9);
            myStack.Push(10);

            Console.WriteLine($"스택의 크기 : {myStack.Count()}");

            int topElement = myStack.Peek();
            Console.WriteLine($"Peek : {topElement}");

            // 스택에서 요소 제거 (Pop)
            int removedElement1 = myStack.Pop();
            Console.WriteLine($"Pop : {removedElement1}");

            int removedElement2 = myStack.Pop();
            Console.WriteLine($"Pop : {removedElement2}");


            //int removedElement3 = myStack.Pop();
            //Console.WriteLine($"제거된 요소: {removedElement3}");

            // 스택의 현재 요소 출력
            Console.WriteLine(myStack);
            //Console.WriteLine("현재 스택의 요소:");
            //foreach (int item in myStack)
            //{
            //    Console.WriteLine(item);
            //}
        }
        public static void QueueExample()
        {
            MyQueue<int> myQueue = new MyQueue<int>();
            Console.WriteLine($"큐의 크기 : {myQueue.Count()}");

            // 스택에 요소 추가 (Push)
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);
            myQueue.Enqueue(7);
            myQueue.Enqueue(8);
            myQueue.Enqueue(9);
            myQueue.Enqueue(10);

            int topElement = myQueue.Peek();
            Console.WriteLine($"Peek : {topElement}");

            int removedElement1 = myQueue.Dequeue();
            Console.WriteLine($"Dequeue : {removedElement1}");

            int removedElement2 = myQueue.Dequeue();
            Console.WriteLine($"Dequeue : {removedElement2}");

            Console.WriteLine(myQueue);

            Console.WriteLine($"큐의 크기 : {myQueue.Count()}");

        }
        public static void ListExample()
        {
            MyList<string> myList = new MyList<string>();
            Console.WriteLine($"리스트의 크기 : {myList.Count()}");

            myList.Add("ABC");
            myList.Add("DEF");
            Console.WriteLine(myList.Contains("DEF"));

            //foreach(string item in myList) 
            //    Console.WriteLine(item);

            Console.WriteLine(myList);
        }
    }
}