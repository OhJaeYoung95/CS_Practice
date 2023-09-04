namespace _0904
{
    internal class MyArrayMain
    {
        static void Main(string[] args)
        {
            //int[] arr = {1, 2, 3, 4, 5};
            //MyArray.Reverse(arr, 1, 3);

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] fillArr = { 1, 2, 3, 4, 5 };
            //MyArray.Fill(fillArr, 10, 1, 2);

            //foreach (int i in fillArr)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] sourceArray = {1, 2, 3, 4, 5};
            //int[] destinationArray = {6, 7, 8, 9, 10};
            //MyArray.Copy(sourceArray, destinationArray, 3);

            //foreach(int i in destinationArray)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] resizeArray = { 1, 2, 3 };
            //MyArray.Resize(ref resizeArray, 10);

            //foreach (int i in resizeArray) 
            //{
            //    Console.WriteLine(i);
            //}

            //int[] clearArray = { 1, 2, 3, 4, 5 };
            //MyArray.Clear(clearArray);

            //foreach(int i in clearArray)
            //{
            //    Console.WriteLine(i);
            //}            


            //int[] partClearArray = { 1, 2, 3, 4, 5 };
            //MyArray.Clear(partClearArray, 2, 2);

            //foreach (int i in partClearArray)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] sortArray = { 2, 3, 1, 7, 5 , 6 };
            //MyArray.Sort(sortArray);

            //foreach(int i in sortArray)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] indexOfArray = { 2, 5, 1, 7, 5, 6 , 5};
            //int findIndex = MyArray.IndexOf(indexOfArray, 10);
            //Console.WriteLine(findIndex);

            int[] binarySearchArray = { 1, 3, 5, 8, 10, 12, 100 };
            int findIndex = MyArray.BinarySearch(binarySearchArray, 10);
            Console.WriteLine(findIndex);


        }
    }
}