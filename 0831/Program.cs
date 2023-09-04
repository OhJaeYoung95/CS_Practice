using System;

public class Test
{
    public static uint MergeARGB(uint a, uint r, uint g, uint b)
    {
        uint merge = b;
        merge = merge | g << 8 * 1;
        merge = merge | r << 8 * 2;
        merge = merge | a << 8 * 3;
        return merge;
    }

    public static void ExtractARGB(uint argb, out uint a, out uint r, out uint g, out uint b)
    {
        //a = argb >> 8 * 3;
        //uint rColor = argb << 8 * 1;
        //r = rColor >> 8 * 3;
        //uint gColor = argb << 8 * 2;
        //g = gColor >> 8 * 3;
        //uint bColor = argb << 8 * 3;
        //b = bColor >> 8 * 3;

        //a = (argb >> 8 * 3) & 0xff;
        //r = (argb >> 8 * 2) & 0xff;
        //g = (argb >> 8 * 1) & 0xff;
        //b = (argb >> 8 * 0) & 0xff;

        a = argb & 0xff000000;
        a >>= 8 * 3;
        r = argb & 0x00ff0000;
        r >>= 8 * 2;
        g = argb & 0x0000ff00;
        g >>= 8 * 1;
        b = argb & 0x000000ff;
    }

    public static void Main()
    {
        //// RGBA
        uint colorA = MergeARGB(255, 192, 150, 100);
        ExtractARGB(colorA, out uint a, out uint r, out uint g, out uint b);
        Console.WriteLine(a); // 255
        Console.WriteLine(r); // 192
        Console.WriteLine(g); // 255
        Console.WriteLine(b); // 192

        // 1. i++와 ++i 차이점은 무엇인가요?
        // 전위 증가 / 후위 증가

        // 2. 2번
        // i 가 10일경우
        // i = i+1; / 11
        // i++; / 10
        // ++i; / 11
        // i += 1; / 11

        // 3. 다음 코드에서 a와 b는 각각 얼마일까요?
        // int a =  8 >> 1; / 4
        // int b = a >> 2; / 1

        // 4. 다음 코드에서 a는 얼마일까요?
        // int a = 0xF0 | 0X0F;
        // int a = 255

        // 5. 다음 코드에서 b는 어떤 값을 가질까요?
        // int a  = 10;
        // string b = a == 0 ? "가나다" : "ABC";   / ABC
    }


}