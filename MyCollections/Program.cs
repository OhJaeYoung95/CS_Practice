using System.Text;

namespace MyCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StackExample();
            //QueueExample();
            //ListExample();
            LinkedListExample();
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
            #region Contains & ReToString Example
            //MyList<string> myList = new MyList<string>();
            //Console.WriteLine($"리스트의 크기 : {myList.Count()}");

            //myList.Add("ABC");
            //myList.Add("DEF");
            //Console.WriteLine(myList.Contains("DEF"));

            //foreach(string item in myList) 
            //    Console.WriteLine(item);

            //Console.WriteLine(myList);
            #endregion
            #region CopyTo Example
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
            #endregion
            #region Insert & Remove & ReMoveAt Example
            //MyList<Part> parts = new MyList<Part>();

            //// Add parts to the list.
            //parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            //parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
            //parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            //parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
            //parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
            //parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

            //foreach (Part aPart in parts)
            //{
            //    Console.WriteLine(aPart);
            //}
            //Console.WriteLine("\nContains(\"1734\"): {0}", parts.Contains(new Part { PartId = 1734, PartName = "" }));

            //// Insert a new item at position 2.
            //Console.WriteLine("\nInsert(2, \"1834\")");
            //parts.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 });

            ////Console.WriteLine();
            //foreach (Part aPart in parts)
            //{
            //    Console.WriteLine(aPart);
            //}

            //Console.WriteLine("\nParts[3]: {0}", parts[3]);

            //Console.WriteLine("\nRemove(\"1534\")");

            //// This will remove part 1534 even though the PartName is different,
            //// because the Equals method only checks PartId for equality.
            //parts.Remove(new Part() { PartId = 1534, PartName = "cogs" });

            //Console.WriteLine();
            //foreach (Part aPart in parts)
            //{
            //    Console.WriteLine(aPart);
            //}
            //Console.WriteLine("\nRemoveAt(3)");
            //// This will remove the part at index 3.
            //parts.RemoveAt(3);

            //Console.WriteLine();
            //foreach (Part aPart in parts)
            //{
            //    Console.WriteLine(aPart);
            //}
            #endregion
            #region IndexOf Example
            //MyList<string> dinosaurs = new MyList<string>();

            //dinosaurs.Add("Tyrannosaurus");
            //dinosaurs.Add("Amargasaurus");
            //dinosaurs.Add("Mamenchisaurus");
            //dinosaurs.Add("Brachiosaurus");
            //dinosaurs.Add("Deinonychus");
            //dinosaurs.Add("Tyrannosaurus");
            //dinosaurs.Add("Compsognathus");

            //Console.WriteLine(dinosaurs);

            //Console.WriteLine("\nIndexOf(\"Tyrannosaurus\"): {0}",
            //    dinosaurs.IndexOf("Tyrannosaurus"));

            //Console.WriteLine("\nIndexOf(\"Tyrannosaurus\", 3): {0}",
            //    dinosaurs.IndexOf("Tyrannosaurus", 3));

            //Console.WriteLine("\nIndexOf(\"Tyrannosaurus\", 2, 2): {0}",
            //    dinosaurs.IndexOf("Tyrannosaurus", 2, 2));
            #endregion
            #region RemoveAll Example
            //MyList<string> dinosaurs = new MyList<string>();

            //dinosaurs.Add("Compsognathus");
            //dinosaurs.Add("Amargasaurus");
            //dinosaurs.Add("Oviraptor");
            //dinosaurs.Add("Velociraptor");
            //dinosaurs.Add("Deinonychus");
            //dinosaurs.Add("Dilophosaurus");
            //dinosaurs.Add("Gallimimus");
            //dinosaurs.Add("Triceratops");

            //Console.WriteLine(dinosaurs);
            //Console.WriteLine($"{dinosaurs.RemoveAll(s => s.ToLower().EndsWith("saurus"))} elements removed by RemoveAll(EndsWithSaurus).\n");
            //Console.WriteLine(dinosaurs);
            #endregion
        }
        public static void LinkedListExample()
        {
            // Create the link list.
            string[] words =
                { "the", "fox", "jumps", "over", "the", "dog" };
            //LinkedList<string> sentence = new LinkedList<string>(words);
            MyLinkedList<string> sentence = new MyLinkedList<string>(words);
            Display(sentence, "The linked list values:");
            Console.WriteLine($"sentence.Contains(\"jumps\") = {sentence.Contains("jumps")}");

            // Add the word 'today' to the beginning of the linked list.
            sentence.AddFirst("today");
            Display(sentence, "Test 1: Add 'today' to beginning of the list:");

            // Move the first node to be the last node.
            MyLinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(mark1.Value);
            Display(sentence, "Test 2: Move first node to be last node:");

            // Change the last node to 'yesterday'.
            sentence.RemoveLast();
            sentence.AddLast("yesterday");
            Display(sentence, "Test 3: Change the last node to 'yesterday':");

            // Move the last node to be the first node.
            mark1 = sentence.Last;
            sentence.RemoveLast();
            sentence.AddFirst(mark1.Value);
            Display(sentence, "Test 4: Move last node to be first node:");

            MyLinkedListNode<string> current = sentence.Find("fox");
            Console.WriteLine($"Find The Value(\"fox\") Of the Node / Node: {current.Value} \n");

            Console.WriteLine(sentence);
        }
        private static void Display(MyLinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    public class Part : IEquatable<Part>
    {
        public string PartName { get; set; }

        public int PartId { get; set; }

        public override string ToString()
        {
            return $"ID: {PartId} Name: {PartName}";
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