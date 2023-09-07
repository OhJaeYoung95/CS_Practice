namespace _0906
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Find
            int[] intsFind = { 1, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(MyArray.Find(intsFind, IsEven));

            // FindAll
            int[] intsFindAll = { 1, 3, 5, 7, 9 };
            int[] findAllList = MyArray.FindAll(intsFindAll, IsEven);
            //foreach(int i in findAllList)
            //    Console.WriteLine(i);

            // FindIndex
            int[] intsIndex1 = { 1, 3, 5, 7, 9, 2 };
            //Console.WriteLine(MyArray.FindIndex(intsIndex1, IsEven));

            int[] intsIndex2 = { 1, 2, 3, 5, 7, 9, 2 };
            // Console.WriteLine(MyArray.FindIndex(intsIndex2, 1,IsEven));

            int[] intsIndex3 = { 1, 2, 3, 5, 7, 9, 2 };
            //Console.WriteLine(MyArray.FindIndex(intsIndex3, 1, 1,IsEven));

            // FindLast
            int[] findLast = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(MyArray.FindLast(findLast, IsEven));

            // FindLastIndex
            int[] findLastIndex1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(MyArray.FindLastIndex(findLastIndex1, IsEven));

            int[] findLastIndex2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(MyArray.FindLastIndex(findLastIndex2, 1, IsEven));

            int[] findLastIndex3 = { 1, 2, 3, 5, 5, 5, 6, 7, 8 };
            //Console.WriteLine(MyArray.FindLastIndex(findLastIndex3, 3, 4,IsEven));

            int[] forEach = { 1, 2, 4, 8 };
            //MyArray.ForEach(forEach, Square);

            int[] trueForAll1 = { 2, 4, 6, 8 };
            int[] trueForAll2 = { 2, 4, 6, 8, 9 };
            //Console.WriteLine(MyArray.TrueForAll(trueForAll1, IsEven));
            //Console.WriteLine(MyArray.TrueForAll(trueForAll2, IsEven));

            // Sort

            IntDescendingOrder intComparer = new IntDescendingOrder();

            int[] intsSort1 = { 5, 2, 9, 1, 5, 6 };
            //MyArray.Sort(intsSort1, intComparer);
            //foreach (int i in intsSort1) Console.WriteLine(i);

            int[] intsSort2 = { 5, 3, 4, 1, 8 };
            MyArray.Sort(intsSort2, delegate (int obj1, int obj2) { return obj1.CompareTo(obj2); });
            foreach (int i in intsSort2) Console.WriteLine(i);


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