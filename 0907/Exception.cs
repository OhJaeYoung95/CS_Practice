using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExceptionMain
{
    public static void Main() 
    {
        int[] arr = new int[10];

        for (int i = 0; i < 10; ++i)
            arr[i] = i;

        try
        {
            for (int i = 0; i < 11; ++i)
                Console.WriteLine(arr[i]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message); 
        }
    }
}