using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class MyArray
{
    public static void Reverse(int[] array)
    {
        //for(int i = 0; i < (array.Length - 1)/ 2; ++i)
        //{
        //    int temp = array[i];
        //    array[i] = array[array.Length - 1 - i];
        //    array[array.Length - 1 - i] = temp;
        //}
        for(int i = 0; i < (array.Length - 1) / 2; ++i)
        {            int temp = array[i];
            array[i] = array[^(i + 1)];
            array[^(i + 1)] = temp;
        }
    }

    public static void Reverse(int[] array, int index, int length)
    {
        //for (int i = 0; i < length / 2; ++i)
        //{
        //    int temp = array[i + index];
        //    array[i + index] = array[^( i + 1 + index - length)];
        //    array[^( i + 1 + index - length)] = temp;
        //}

        for (int i = 0; i < length / 2; ++i)
        {
            int temp = array[i + index];
            array[i + index] = array[i + index + length - 1];
            array[i + index + length - 1] = temp;
        }
    }

    public static void Fill(int[] array, int value, int startIndex, int count)
    {
        for (int i = startIndex; i < startIndex + count; i++)
        {
            array[i] = value;
        }
    }

    public static void Copy(int[] sourceArray, int[] destinationArray, int length)
    {
        for (int i = 0; i < length; i++)
        {
            destinationArray[i] = sourceArray[i];
        }
    }

    public static void Resize(ref int[] array, int newSize)
    {
        if(array.Length < newSize)
        {
            int[] tempArray = new int[newSize];
            
            for (int i = 0; i < array.Length; ++i)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
        }
    }

    public static void Clear(int[] array)
    {
        for(int i = 0; i < array.Length; ++i)
        {
            array[i] = 0;
        }
    }

    public static void Clear(int[] array, int index, int length)
    {
        for (int i = index; i < index + length; ++i)
        {
            array[i] = 0;
        }

    }

    public static void Sort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; ++i)
        {
            for (int j = 0; j < array.Length - 1; ++j)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public static int IndexOf(int[] array, int value)
    {
        for(int i =0; i < array.Length - 1; ++i)
            if (array[i] == value) return i;
        return -1;
    }

    public static int BinarySearch(int[] array, int value)
    {
        return BinarySearchRecursive(array, value, 0, array.Length - 1);
    }

    private static int BinarySearchRecursive(int[] array, int value, int startIndex, int endIndex)
    {
        if (startIndex > endIndex)
        {
            return -1;
        }

        int searchIndex = (startIndex + endIndex) / 2;

        if (array[searchIndex] == value)
        {
            return searchIndex;
        }
        else if (array[searchIndex] > value)
        {
            return BinarySearchRecursive(array, value, startIndex, searchIndex - 1);
        }
        else
        {
            return BinarySearchRecursive(array, value, searchIndex + 1, endIndex);
        }
    }
}