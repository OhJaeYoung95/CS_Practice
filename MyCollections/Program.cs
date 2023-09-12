namespace MyCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StackExample();
            QueueExample();
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
            Console.WriteLine($"맨 위 요소: {topElement}");

            // 스택에서 요소 제거 (Pop)
            int removedElement1 = myStack.Pop();
            Console.WriteLine($"제거된 요소: {removedElement1}");

            int removedElement2 = myStack.Pop();
            Console.WriteLine($"제거된 요소: {removedElement2}");


            //int removedElement3 = myStack.Pop();
            //Console.WriteLine($"제거된 요소: {removedElement3}");

            // 스택의 현재 요소 출력
            Console.WriteLine("현재 스택의 요소:");
            foreach (int item in myStack)
            {
                Console.WriteLine(item);
            }
        }
        public static void QueueExample()
        {

        }
    }
}