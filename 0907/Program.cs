delegate int MyDelegate(int a, int b);
delegate void MyDelegate2(int a);

class MainApp
{
    //static void Main()
    //{
    //    // 문제 1
    //    //MyDelegate Callback;

    //    //Callback = delegate (int a, int b) { return a + b; };
    //    //Console.WriteLine(Callback(3, 4));
    //    //Callback = delegate (int a, int b) { return a - b; };
    //    //Console.WriteLine(Callback(7, 5));

    //    // 문제 2
    //    Market market = new Market();
    //    market.CustomerEvent += new MyDelegate2(delegate (int a)
    //    { Console.WriteLine($"축하합니다! {a}번째 고객 이벤트에 당첨되셨습니다."); });

    //    for (int customerNo = 0; customerNo < 100; customerNo += 10)
    //        market.BuySomething(customerNo);


    //}
}

class Market
{
    public event MyDelegate2 CustomerEvent;

    public void BuySomething(int CustomerNo)
    {
        if (CustomerNo == 30)
            CustomerEvent(CustomerNo);
    }
}
