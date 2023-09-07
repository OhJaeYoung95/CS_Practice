namespace _0906
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Find
            int[] intsFind = { 1, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(MyArray.Find(intsFind, delegate (int obj) { return obj > 5; }));

            // FindAll
            int[] intsFindAll = { 1, 3, 5, 7, 9, 12, 2, 6, 10, 8 , 11};
            int[] findAllList = MyArray.FindAll(intsFindAll, delegate (int obj) { return obj > 6 && obj < 12; });
            //foreach(int i in findAllList)
            //    Console.WriteLine(i);

            // FindIndex
            int[] intsIndex1 = { 1, 3, 5, 7, 9, 2 };
            //Console.WriteLine(MyArray.FindIndex(intsIndex1, delegate (int obj) { return obj != 1; }));

            int[] intsIndex2 = { 1, 2, 3, 5, 7, 9, 2 };
            //Console.WriteLine(MyArray.FindIndex(intsIndex2, 3, delegate (int obj) { return obj < 3; }));

            int[] intsIndex3 = { 1, 2, 3, 5, 7, 9, 2 };
            //Console.WriteLine(MyArray.FindIndex(intsIndex3, 1, 1, delegate (int obj) { return obj == 3; }));

            // FindLast
            int[] findLast = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(MyArray.FindLast(findLast, delegate (int obj) { return obj < 10; }));

            // FindLastIndex
            int[] findLastIndex1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(MyArray.FindLastIndex(findLastIndex1, delegate (int obj) { return obj == 4; }));

            int[] findLastIndex2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(MyArray.FindLastIndex(findLastIndex2, 2, delegate (int obj) { return obj % 2 != 0; }));

            int[] findLastIndex3 = { 1, 2, 3, 5, 5, 5, 6, 7, 8 };
            //Console.WriteLine(MyArray.FindLastIndex(findLastIndex3, 3, 4, delegate (int obj) { return obj % 2 == 0; }));

            int[] forEach = { 1, 2, 4, 8 };
            //MyArray.ForEach(forEach, delegate (int obj) {
            //    Console.WriteLine($"{obj} squared = {obj * obj}");
            //});

            int[] trueForAll1 = { 2, 4, 6, 8 };
            int[] trueForAll2 = { 2, 4, 6, 8, 9 };
            //Console.WriteLine(MyArray.TrueForAll(trueForAll1, delegate (int obj) { return obj >= 2; }));
            //Console.WriteLine(MyArray.TrueForAll(trueForAll2, delegate (int obj) { return obj < 6; }));

            // Sort

            IntAscendingOrder ascendingOrder = new IntAscendingOrder();
            IntDescendingOrder descendingOrder = new IntDescendingOrder();

            int[] intsSort1 = { 5, 2, 9, 1, 5, 6 };
            //MyArray.Sort(intsSort1, ascendingOrder);
            //foreach (int i in intsSort1) Console.WriteLine(i);

            int[] intsSort2 = { 5, 3, 4, 1, 8 };
            MyArray.Sort(intsSort2, delegate (int obj1, int obj2) { return obj1.CompareTo(obj2); });
            //foreach (int i in intsSort2) Console.WriteLine(i);

            int[] intSort3 = { 2, 1, 3, 5, 4, 17, 10, 100 };
            MyArray.Sort(intSort3, 3, 4);
            //foreach (int i in intSort3) Console.WriteLine(i);
            
            int[] intSort4 = { 2, 1, 3, 5, 4, 17, 10, 100 };
            MyArray.Sort(intSort4, 3, 4, descendingOrder);
            //foreach (int i in intSort4) Console.WriteLine(i);

        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        static void Square(int val)
        {
            Console.WriteLine($"{val} squared = {val * val}");
        }
    }

    public class IntAscendingOrder: IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }
    }
    public class IntDescendingOrder: IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }
}