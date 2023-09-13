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
            //MyList<string> myList = new MyList<string>();
            //Console.WriteLine($"리스트의 크기 : {myList.Count()}");

            //myList.Add("ABC");
            //myList.Add("DEF");
            //Console.WriteLine(myList.Contains("DEF"));

            //foreach(string item in myList) 
            //    Console.WriteLine(item);

            //Console.WriteLine(myList);

            // MyList<string> dinosaurs = new MyList<string>();

            // dinosaurs.Add("Tyrannosaurus");
            // dinosaurs.Add("Amargasaurus");
            // dinosaurs.Add("Mamenchisaurus");
            // dinosaurs.Add("Brachiosaurus");
            // dinosaurs.Add("Compsognathus");

            // string[] array = new string[15];

            // dinosaurs.CopyTo(array);
            // dinosaurs.CopyTo(array, 6);
            // dinosaurs.CopyTo(2, array, 12, 3);

            //// Console.WriteLine(array);
            // foreach (string dinosaur in array)
            // {
            //     Console.WriteLine(dinosaur);
            // }

            // Create a list of parts.
            List<Part> parts = new List<Part>();

            // Add parts to the list.
            parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
            parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
            parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            Console.WriteLine("\nContains(\"1734\"): {0}", parts.Contains(new Part { PartId = 1734, PartName = "" }));

            // Insert a new item at position 2.
            Console.WriteLine("\nInsert(2, \"1834\")");
            parts.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 });

            //Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            Console.WriteLine("\nParts[3]: {0}", parts[3]);

            Console.WriteLine("\nRemove(\"1534\")");

            // This will remove part 1534 even though the PartName is different,
            // because the Equals method only checks PartId for equality.
            parts.Remove(new Part() { PartId = 1534, PartName = "cogs" });

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }
            Console.WriteLine("\nRemoveAt(3)");
            // This will remove the part at index 3.
            parts.RemoveAt(3);

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }
        }
    }

    public class Part : IEquatable<Part>
    {
        public string PartName { get; set; }

        public int PartId { get; set; }

        public override string ToString()
        {
            return "ID: " + PartId + "   Name: " + PartName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return PartId;
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.PartId.Equals(other.PartId));
        }
        // Should also override == and != operators.
    }
}