using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class MyArray
{
    public static void Reverse<T> (T[] array) where T : struct
    {
        //for(int i = 0; i < (array.Length - 1)/ 2; ++i)
        //{
        //    int temp = array[i];
        //    array[i] = array[array.Length - 1 - i];
        //    array[array.Length - 1 - i] = temp;
        //}
        for (int i = 0; i < (array.Length - 1) / 2; ++i)
        {
            int temp = array[i];
            array[i] = array[^(i + 1)];
            array[^(i + 1)] = temp;
        }
    }

    public static void Reverse<T> (T[] array, T index, int length) where T : struct
    {
        //for (int i = 0; i < length / 2; ++i)
        //{
        //    int temp = array[i + index];
        //    array[i + index] = array[^( i + 1 + index - length)];
        //    array[^( i + 1 + index - length)] = temp;
        //}

        for (int i = 0; i < length / 2; ++i)
        {
            T temp = array[i + index];
            array[i + index] = array[i + index + length - 1];
            array[i + index + length - 1] = temp;
        }
    }

    public static void Fill<T> (T[] array, T value, T startIndex, T count) where T : struct
    {
        for (int i = startIndex; i < startIndex + count; i++)
        {
            array[i] = value;
        }
    }

    public static void Copy<T> (T[] sourceArray, T[] destinationArray, T length) where T : struct
    {
        for (int i = 0; i < length; i++)
        {
            destinationArray[i] = sourceArray[i];
        }
    }

    public static void Resize<T> (ref T[] array, T newSize) where T :struct
    {
        if (array.Length < newSize)
        {
            int[] tempArray = new int[newSize];

            for (int i = 0; i < array.Length; ++i)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
        }
    }

    public static void Clear<T> (T[] array)
    {
        for (int i = 0; i < array.Length; ++i)
        {
            array[i] = default;
        }
    }


    public static void Clear<T> (T[] array, int index, int length)
    {
        for (int i = index; i < index + length; ++i)
        {
            array[i] = default;
        }

    }

    public static void Sort<T> (T[] array) where T : struct
    {
        for (int i = 0; i < array.Length; ++i)
        {
            for (int j = 0; j < array.Length; ++j)
            {
                if (array[j] > array[j + 1])
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public static T IndexOf<T> (T[] array, T value) where T : struct
    {
        for (int i = 0; i < array.Length - 1; ++i)
            if (array[i] == value) return i;
        return -1;
    }

    public static T BinarySearch<T> (T[] array, T value) where T : struct
    {
        return BinarySearchRecursive(array, value, 0, array.Length - 1);
    }

    private static T BinarySearchRecursive(T[] array, T value, int startIndex, int endIndex) where  T : struct
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