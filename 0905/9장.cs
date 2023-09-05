using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0905
{


    class NameCard
    {
        private int age;
        private string name;

        public int Age { get { return age; } set {  age = value; } }
        public string Name { get { return name; } set { name = value; } }
    }

    class Complex
    {
        private int real;
        private int imaginary;

        public int Real { get { return real; } set { real = value; } }
        public int Imaginary { get { return imaginary; } set { imaginary = value; } }
    }

    //class MainApp
    //{
    //    public static void Main()
    //    {
    //        // 1. 다음 코드에서 NameCard 클래스의 GetAge(), SetAge(),
    //        // GetName(), SetName() 메소드들을 프로퍼티로 변경해 작성해보자.

    //        //NameCard MyCard = new NameCard();
    //        //MyCard.Age = 24;
    //        //MyCard.Name = "상현";

    //        //Console.WriteLine($"나이 : {MyCard.Age}");
    //        //Console.WriteLine($"이름 : {MyCard.Name}");


    //        // 2. 다음 프로그램을 완성해서 다음과 같은 결과를 출력하도록 하세요. 단, 무명 형식을 이용해야 합니다.

    //        var nameCard = new { Name = "박상현", Age = 17 };
    //        Console.WriteLine($"이름 : {nameCard.Name}, 나이 : {nameCard.Age}");

    //        var complex = new { Real = 3, Imaginary = -12 };
    //        Console.WriteLine($"Real : {complex.Real}, Imaginary : {complex.Imaginary}");
    //    }
    //}



}
