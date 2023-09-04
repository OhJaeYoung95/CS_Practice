using System;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace RectArea
{
    class MainApp
    {
        public static void Main()
        {
            //Console.WriteLine("사각형의 너비를 입력하세요.");
            //string width = Console.ReadLine();

            //Console.WriteLine("사각형의 높이를 입력하세요.");
            //string height = Console.ReadLine();

            //// 이곳에 사각형의 넓이를 계산하고
            //// 출력하는 루틴을 추가하세요.

            //int value = int.Parse(width) * int.Parse(height);
            //Console.WriteLine();

            // 1. 입력 받은 문자열을 뒤집어서 출력
            //Console.WriteLine("1. 입력 받은 문자열을 뒤집어서 출력.");
            //string input1 = Console.ReadLine();
            //char[] charArray = input1.ToCharArray();
            //Array.Reverse(charArray);
            //string reverse = new string(charArray);
            //Console.WriteLine(reverse);

            //// 2. 입력 받은 문자열의 단어의 수를 출력
            //Console.WriteLine("2. 입력 받은 문자열의 단어의 수를 출력");
            //string input2 = Console.ReadLine();
            //string[] inputArray = input2.Split(" ");
            //Console.WriteLine(inputArray.Length);

            //3.입력 받은 문자열에서 알파벳, 특수문자, 숫자 갯수를 출력하라
            Console.WriteLine("3. 입력 받은 문자열에서 알파벳, 특수문자, 숫자 갯수를 출력하라");
            int alphabetCount = 0;
            int symbolCount = 0;
            int digitCount = 0;
            string input3 = Console.ReadLine();
            foreach (var value in input3)
            {
                if (char.IsAscii(value) && !char.IsPunctuation(value))
                {
                    alphabetCount++;
                }
                else if ((char.IsPunctuation(value) && char.IsAscii(value)) || char.IsSymbol(value))
                {
                    symbolCount++;
                }
                else if (char.IsDigit(value))
                {
                    digitCount++;
                }
            }

            Console.WriteLine($"알파벳 : {alphabetCount}, 특수문자 : {symbolCount}, 숫자 : {digitCount}");


            // 4. 입력 받은 문자열에서 가장 많은 문자를 찾아라.
            //Console.WriteLine("4. 입력 받은 문자열에서 가장 많은 문자를 찾아라.");
            //string input = Console.ReadLine();
            //int count = 0;
            //char mostChar = '\0';

            //foreach (char c in input)
            //{
            //    int splitCount = input.Split(c).Length - 1;
            //    if (splitCount > count)
            //    {
            //        count = splitCount;
            //        mostChar = c;
            //    }
            //}

            //Console.WriteLine($"가장 많은 문자: {mostChar}, 횟수 : {count}");


            // 5. 입력 받은 문자열의 대소문자를 바꿔서 출력해라.
            //Console.WriteLine("5. 입력 받은 문자열의 대소문자를 바꿔서 출력해라.");
            //string input = Console.ReadLine();
            //StringBuilder newStr = new StringBuilder();

            //foreach(var c in input)
            //{
            //    if (char.IsLower(c))
            //    {
            //        newStr.Append(char.ToUpper(c));
            //    }
            //    else if (char.IsUpper(c))
            //    {
            //        newStr.Append(char.ToLower(c));
            //    }
            //    else
            //    {
            //        newStr.Append(c);
            //    }
            //}

            //Console.WriteLine(newStr);


            // 6.문자열 2개를 입력 받아서 첫번째 문자열에 두번째 문자열이 몇 번 등장하는지 출력해라.
            //Console.WriteLine("문자열1 입력: ");
            // String words1 = Console.ReadLine();

            // Console.WriteLine("문자열2 입력: ");
            // String words2 = Console.ReadLine();

            // int count = Regex.Matches(words1, words2).Count;

            // Console.Write("문자열1에 포함된 문자열2 개수: {0}", count);



            // 6.문자열 2개를 입력 받아서 첫번째 문자열에 두번째 문자열이 몇 번 등장하는지 출력해라.
            Console.WriteLine("첫번째 문자열을 입력");
            string input = Console.ReadLine();

            Console.WriteLine("두번째 문자열을 입력");
            string target = Console.ReadLine();

            int count = 0;
            int index = input.IndexOf(target);
            /// aaadcvbtr
            // dc
            while (index != -1)
            {
                count++;
                index = input.IndexOf(target, index + target.Length);
            }

            Console.WriteLine($"첫번째 문자열에 두번째 문자일이 {count}번 등장");
        }
    }
}