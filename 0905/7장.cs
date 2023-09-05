// 1. 클래스와 객체, 인스턴스는 서로 어떤 점이 다른가요?
// 클래스는 객체와 인스턴스의 틀이다. 클래스에서 속성과 메서드를 정의할 수 있고, 인스턴스와 객체는 이러한 클래스를 기반으로 실제 메모리에 생성되는 것이다. 인스턴스와 객체는 동의어이며, 해당 클래스의 속성과 메서드를 이용할 수 있다.

// 2. 다음 코드에서 오류를 찾고, 오류의 원인을 설명하세요.
// 새로운 인스턴스를 할당할때 참조되는 변수의 데이터 형과 일치해야 한다.
// A c = new B();
// B d = new A(); 
// 두 구문이 오류이다.

// 3. this 키워드와 base 키워드에 대해 설명하세요.
// this 키워드는 셀프 레퍼런스(자신의 인스턴스)를 의미하며, base 키워드는 자기 자신의 부모 인스턴스를 의미한다.

// 4. 구조체에 대한 다음 설명 중 틀린 것을 모두 찾으세요.
// 3 참조 형식이다. / 값 형식이다

// 5. 다음 코드를 컴파일 및 실행이 가능하도록 수정하세요.
// 프로퍼티로 변경해준다.

// 6. 다형성은 무엇이며, 오버라이딩과 무슨 관계가 있는지 설명하세요.
// 다형성은 하나의 타입이 여러한 성질을 가진것을 의미하며,
// 하나의 객체에 여러 가지 타입을 대입할 수 있다는 것
// 오버라이딩은 상속관계에서 함수를 재정의 하는것을 의미한다.

// 7. 다음 코드에서 switch 식을 제거하고 switch 문으로 동일한 기능을 작성하세요.

class Practice
{
    //public static void Main()
    //{

    //}

    private static double GetDiscountRate(object client)
    {
        switch(client)
        {
            case Tuple<string, int> n when n.Item1 == "학생" && n.Item2 < 18:
                client = 0.2;
                break;
            case Tuple<string, int> n when n.Item1 == "학생":
                client = 0.1;
                break;
            case Tuple<string, int> n when n.Item1 == "일반" && n.Item2 < 18:
                client = 0.1;
                break;
            case Tuple<string, int> n when n.Item1 == "일반":
                client = 0.05;
                break;
        }

        return (double)client;
    }
}