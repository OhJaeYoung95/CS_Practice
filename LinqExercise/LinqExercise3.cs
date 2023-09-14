using System;
using System.Linq;
using System.Collections.Generic;
 
//class LinqExercise3
//{
//    static void Main(string[] args)
//    {
//        // code from DevCurry.com
//        var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

//        Console.Write("\nLINQ : Find the number and its square of an array which is more than 20 : ");
//        Console.Write("\n------------------------------------------------------------------------\n");

//        //var sqNo = from value in arr1
//        //           where value * value >= 20
//        //           select new
//        //           {
//        //               Number = value,
//        //               SqrNo = value * value
//        //           };

//        var sqNo = arr1.Where(value => value * value > 20).Select(n => $"Number = {n}, SqrNo ={n * n}");

//        foreach (var a in sqNo)
//            Console.WriteLine(a);

//        Console.ReadLine();
//    }
//    //OUTPUT: 
//    /*
//    { Number = 9, SqrNo = 81 }
//    { Number = 8, SqrNo = 64 }
//    { Number = 6, SqrNo = 36 }
//    { Number = 5, SqrNo = 25 }
//    */
//}
