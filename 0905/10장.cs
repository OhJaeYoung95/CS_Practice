using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0905
{
    class MainApp10
    {
        public static void Main()
        {
            Matrix first = new Matrix(3, 2, 1, 4);
            Matrix second = new Matrix(9, 2, 1, 7);

            Matrix result = first * second;
            Console.WriteLine(result);

            // 5. 다음과 같은 결과를 출력하도록 아래의 코드를 완성하세요.

            Hashtable ht = new Hashtable();
            ht["회사"] = "Microsoft";
            ht["URL"] = "www.microsoft.com";

            Console.WriteLine($"회사 : {ht["회사"]}");
            Console.WriteLine($"URL : {ht["URL"]}");
        }

        // 1. 다음 배열 선언 문장 중 올바르지 않은 것을 고르세요.
        // 1번 int[]에 string 값을 담고 있음

        // 2. 두 행렬의 곱은 다음과 같이 계산합니다.

        class Matrix
        {
            int[,] array;

            public Matrix()
            {
                array = new int[2, 2];
                for ( int i = 0; i < array.GetLength(0); ++i)
                {
                    for ( int j = 0; j < array.GetLength(1); ++j)
                    {
                        array[i, j] = 0;
                    }
                }
            }

            public Matrix(int a, int b, int c, int d)
            {
                array = new int[2, 2];
                array[0, 0] = a;
                array[0, 1] = b;
                array[1, 0] = c;
                array[1, 1] = d;
             }

            public static Matrix operator *(Matrix self, Matrix other)
            {
                Matrix temp = new Matrix();

                temp.array[0, 0] = (self.array[0, 0] * other.array[0, 0]) + (self.array[0, 1] * other.array[1, 0]);
                temp.array[0, 1] = (self.array[0, 0] * other.array[0, 1]) + (self.array[1, 0] * other.array[1, 1]);
                temp.array[1, 0] = (self.array[1, 0] * other.array[0, 0]) + (self.array[1, 1] * other.array[1, 0]);
                temp.array[1, 1] = (self.array[1, 0] * other.array[0, 1]) + (self.array[1, 1] * other.array[1, 1]);
                return temp;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 2; ++i)
                {
                    for (int j = 0; j < 2; ++j)
                    {
                        sb.Append(array[i, j]);
                        sb.Append(" ");
                    }
                    sb.AppendLine();
                }
                return sb.ToString();
            }

        }

        // 3. 다음 코드의 출력 결과는 무엇일까요?
        // 5 4 3 2 1 

        // 4. 다음 코드의 출력 결과는 무엇일까요?
        // 1 2 3 4 5


    }
}
