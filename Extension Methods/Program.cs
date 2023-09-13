using System.Text;
int[] numbers = { 1, 2, 3 };
int count = numbers.Count();          // 5;
int min = numbers.Min();              // 6;
public class MainApp
{
    public static void Main()
    {
        // Test Reverse
        string original = "hello";
        string reversed = original.Reverse();
        Console.WriteLine(reversed);    // olleh
        Console.WriteLine();

        // Test DoubleAll
        List<int> originalList = new List<int> { 1, 2, 3 };
        originalList.DoubleAll();
        originalList.ForEach(Console.WriteLine);    // 2, 4, 6
        Console.WriteLine();

        // Test Square
        int originalNum = 4;
        int squared = originalNum.Square();
        Console.WriteLine(squared); // 16
        Console.WriteLine();


    }
}

public static class Extension
{
    public static string Reverse(this string original) => new string(original.ToCharArray().Reverse().ToArray());
    //{
    //    //StringBuilder sb = new StringBuilder();
    //    //for (int i = original.Length - 1; i >= 0; --i) 
    //    //{
    //    //    sb.Append(original[i]);
    //    //}
    //    //return sb.ToString();

    //    return new string(original.ToCharArray().Reverse().ToArray());
    //}

    public static void DoubleAll(this List<int> originalList)
    {
        for (int i = 0; i < originalList.Count; i++)
        {
            originalList[i] *= 2;
        }
    }

    public static int Square(this int original)
    {
        return original * original;
    }
}
