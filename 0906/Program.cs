namespace _0906
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Find
            int[] intsFind  = {1, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(MyArray.Find(intsFind, IsEven));

            // FindAll
            int[] intsFindAll = { 1, 3, 5, 7, 9 };
            int[] findAllList = MyArray.FindAll(intsFindAll, IsEven);
            //foreach(int i in findAllList)
            //    Console.WriteLine(i);

            // FindIndex
            int[] intsIndex1 = { 1, 3, 5, 7, 9 , 2};
            //Console.WriteLine(MyArray.FindIndex(intsIndex1, IsEven));

            int[] intsIndex2 = { 1,2, 3, 5, 7, 9 , 2};
           // Console.WriteLine(MyArray.FindIndex(intsIndex2, 1,IsEven));

            int[] intsIndex3 = { 1,2, 3, 5, 7, 9 , 2};
            //Console.WriteLine(MyArray.FindIndex(intsIndex3, 1, 1,IsEven));

            // FindLast
            int[] findLast = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(MyArray.FindLast(findLast, IsEven));

            // FindLastIndex
            int[] findLastIndex1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(MyArray.FindLastIndex(findLastIndex1, IsEven));

            int[] findLastIndex2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(MyArray.FindLastIndex(findLastIndex2, 1, IsEven));


        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}