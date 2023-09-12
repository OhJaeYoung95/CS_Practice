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
            int[] intsFindAll = { 1, 3, 5, 7, 9, 12, 2, 6, 10, 8, 11 };
            int[] findAllList = MyArray.FindAll(intsFindAll, (int obj) => obj > 6 && obj < 12);
            //int[] findAllList = MyArray.FindAll(intsFindAll, delegate (int obj) { return obj > 6 && obj < 12; });
            //MyArray.ForEach(findAllList, (int obj) => Console.WriteLine(obj));
            //MyArray.ForEach(findAllList, delegate (int obj) { Console.WriteLine(obj); });

            // FindIndex
            int[] intsIndex1 = { 1, 3, 5, 7, 9, 2 };
            //Console.WriteLine(MyArray.FindIndex(intsIndex1, (int obj) => obj != 1 ));
            //Console.WriteLine(MyArray.FindIndex(intsIndex1, delegate (int obj) { return obj != 1; }));

            int[] intsIndex2 = { 1, 2, 3, 5, 7, 9, 2 };
            //Console.WriteLine(MyArray.FindIndex(intsIndex2, 3, (int obj) => obj < 3));
            //Console.WriteLine(MyArray.FindIndex(intsIndex2, 3, delegate (int obj) { return obj < 3; }));

            int[] intsIndex3 = { 1, 2, 3, 5, 7, 9, 2 };
            //Console.WriteLine(MyArray.FindIndex(intsIndex3, 1, 1, (int obj) => obj == 3 ));
            //Console.WriteLine(MyArray.FindIndex(intsIndex3, 1, 1, delegate (int obj) { return obj == 3; }));

            // FindLast
            int[] findLast = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(MyArray.FindLast(findLast, (int obj) => obj < 10));
            //Console.WriteLine(MyArray.FindLast(findLast, delegate (int obj) { return obj < 10; }));

            // FindLastIndex
            int[] findLastIndex1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(MyArray.FindLastIndex(findLastIndex1, (int obj) => obj == 4));
            //Console.WriteLine(MyArray.FindLastIndex(findLastIndex1, delegate (int obj) { return obj == 4; }));

            int[] findLastIndex2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(MyArray.FindLastIndex(findLastIndex2, 2, (int obj) => obj % 2 != 0));
            //Console.WriteLine(MyArray.FindLastIndex(findLastIndex2, 2, delegate (int obj) { return obj % 2 != 0; }));

            int[] findLastIndex3 = { 1, 2, 3, 5, 5, 5, 6, 7, 8 };
            //Console.WriteLine(MyArray.FindLastIndex(findLastIndex3, 3, 4, (int obj) => obj % 2 == 0));
            //Console.WriteLine(MyArray.FindLastIndex(findLastIndex3, 3, 4, delegate (int obj) { return obj % 2 == 0; }));

            int[] forEach = { 1, 2, 4, 8 };
            //MyArray.ForEach(forEach, (int obj) => Console.WriteLine($"{obj} squared = {obj * obj}"));
            //MyArray.ForEach(forEach, delegate (int obj)
            //{
            //    Console.WriteLine($"{obj} squared = {obj * obj}");
            //});

            int[] trueForAll1 = { 2, 4, 6, 8 };
            int[] trueForAll2 = { 2, 4, 6, 8, 9 };
            //Console.WriteLine(MyArray.TrueForAll(trueForAll1, (int obj) =>  obj >= 2));
            //Console.WriteLine(MyArray.TrueForAll(trueForAll2, (int obj) => obj < 6));
            //Console.WriteLine(MyArray.TrueForAll(trueForAll1, delegate (int obj) { return obj >= 2; }));
            //Console.WriteLine(MyArray.TrueForAll(trueForAll2, delegate (int obj) { return obj < 6; }));

            // Sort

            IntAscendingOrder ascendingOrderInt = new IntAscendingOrder();
            IntDescendingOrder descendingOrderInt = new IntDescendingOrder();
            StrAscendingOrder ascendingOrderStr = new StrAscendingOrder();
            StrDescendingOrder descendingOrderStr = new StrDescendingOrder();

            int[] intsSort1 = { 5, 2, 9, 1, 5, 6 };
            string[] strsSotr1 = { "Hi", "ABC", "DEF" };
            MyArray.Sort(strsSotr1, ascendingOrderStr);

            //MyArray.ForEach(strsSotr1, (string str) => Console.WriteLine(str));
            //MyArray.ForEach(strsSotr1, delegate (string str) { Console.WriteLine(str); });

            //MyArray.Sort(intsSort1, ascendingOrderInt);
            //foreach (int i in intsSort1) Console.WriteLine(i);

            int[] intsSort2 = { 5, 3, 4, 1, 8 };
            //MyArray.Sort(intsSort2, (int obj1, int obj2) => obj1.CompareTo(obj2));
            MyArray.Sort(intsSort2, (int obj1, int obj2) => obj1.CompareTo(obj2));
            foreach (int i in intsSort2) Console.WriteLine(i);

            int[] intSort3 = { 2, 1, 3, 5, 4, 17, 10, 100 };
            MyArray.Sort(intSort3, 3, 4);
            //foreach (int i in intSort3) Console.WriteLine(i);
            
            int[] intSort4 = { 2, 1, 3, 5, 4, 17, 10, 100 };
            MyArray.Sort(intSort4, 3, 4, descendingOrderInt);
            //foreach (int i in intSort4) Console.WriteLine(i);

            string[] dinosaurs = {
            "Seismosaurus",
            "Chasmosaurus",
            "Coelophysis",
            "Mamenchisaurus",
            "Caudipteryx",
            "Cetiosaurus"  };

            int[] dinosaurSizes = { 40, 5, 3, 22, 1, 18 };

            MyArray.Sort(dinosaurs, dinosaurSizes, 0, 4, descendingOrderStr);
            //for(int i = 0; i < dinosaurSizes.Length; ++i)
            //{
            //    Console.WriteLine($"{dinosaurs[i]}: up to {dinosaurSizes[i]} meters long.");
            //}
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
    public class StrAscendingOrder: IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.CompareTo(y);
        }
    }
    public class StrDescendingOrder: IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return y.CompareTo(x);
        }
    }
}