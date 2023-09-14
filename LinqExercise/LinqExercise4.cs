using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };


            //IEnumerable<string> LFruits = from fruit in fruits
            //                              where fruit.First() == 'L'
            //                              select fruit;
            IEnumerable<string> LFruits = fruits.Where(n => n.First() == 'L').Select(n => n);

            foreach (string fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }

            // Lemon
            // Lime
            // Loganberry


            // Which of the following numbers are multiples of 4 or 6
            List<int> mixedNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };


            List<int> fourSixMultiples = (from mixedNumber in mixedNumbers
                                          where mixedNumber % 4 == 0 || mixedNumber % 6 == 0
                                          select mixedNumber).ToList();
            foreach (int number in fourSixMultiples)
            {
                Console.WriteLine(number);
            }


            //8
            //24
            //32
            //30
            //12
            //54
            //48
            //4
            //96



            //내림차순 정렬 출력

            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> descending = (from name in names
                                       orderby name descending
                                       select name).ToList();


            foreach (string item in descending)
            {
                Console.WriteLine(item);
            }



            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            Console.WriteLine($"{(purchases.Sum()):N0}"); //20,750

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            Console.WriteLine($"{prices.Max():N0}"); //9,443

            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };


            List<int> nonSquares = (from value in wheresSquaredo
                                    where Math.Sqrt(value) * Math.Sqrt(value) != value
                                    select value).ToList();
            foreach (var item in nonSquares)
            {
                Console.WriteLine(item.ToString());
            }


            //66
            //12
            //8
            //27
            //82
            //34
            //7
            //50
            //19
            //46
        }
    }
}