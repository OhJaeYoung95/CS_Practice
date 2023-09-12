using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class MyArray
{
    public static void Reverse<T>(T[] array)
    {
        //for(int i = 0; i < (array.Length - 1)/ 2; ++i)
        //{
        //    int temp = array[i];
        //    array[i] = array[array.Length - 1 - i];
        //    array[array.Length - 1 - i] = temp;
        //}
        for (int i = 0; i < (array.Length - 1) / 2; ++i)
        {
            T temp = array[i];
            array[i] = array[^(i + 1)];
            array[^(i + 1)] = temp;
        }
    }

    public static void Reverse<T>(T[] array, int index, int length)
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

    public static void Fill<T>(T[] array, T value, int startIndex, int count)
    {
        for (int i = startIndex; i < startIndex + count; i++)
        {
            array[i] = value;
        }
    }

    public static void Copy<T>(T[] sourceArray, T[] destinationArray, int length)
    {
        for (int i = 0; i < length; i++)
        {
            destinationArray[i] = sourceArray[i];
        }
    }

    public static void Resize<T>(ref T[] array, int newSize)
    {
        if (array.Length < newSize)
        {
            T[] tempArray = new T[newSize];

            for (int i = 0; i < array.Length; ++i)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
        }
    }

    public static void Clear<T>(T[] array)
    {
        for (int i = 0; i < array.Length; ++i)
        {
            array[i] = default;
        }
    }


    public static void Clear<T>(T[] array, int index, int length)
    {
        for (int i = index; i < index + length; ++i)
        {
            array[i] = default;
        }

    }


    public static int IndexOf<T> (T[] array, T value) where T : IEquatable<T>
    {
        for (int i = 0; i < array.Length - 1; ++i)
            if (array[i].Equals(value)) return i;
        return -1;
    }

    public static int BinarySearch<T>(T[] array, T value) where T : IComparable<T>, IEquatable<T>
    {
        int start = 0;
        int end = array.Length - 1;
        int mid = 0;
        while (start <= end)
        {
            mid = (start + end) / 2;

            if (array[mid].Equals(value))
            {
                return mid;
            }

            if (array[mid].CompareTo(value) < 0)
            {
                start = mid + 1;
            }
            else if (array[mid].CompareTo(value) > 0)
            {
                end = mid - 1;
            }
        }

        return (mid > 0) ? -end : -start;
    }

    public static T Find<T> (T[] array, Predicate<T> match)
    {
        foreach (T item in array)
            if (match(item)) return item;

        return default(T);
    }

    public static T[] FindAll<T> (T[] array, Predicate<T> match)
    {
        List<T> list = new List<T>();
        foreach (T item in array)
            if(match(item)) list.Add(item);

        return list.ToArray();
    }

    public static int FindIndex<T>(T[] array, Predicate<T> match)
    {
        for(int i = 0; i < array.Length; ++i)
            if (match(array[i])) return i;

        return -1;
    }

    public static int FindIndex<T>(T[] array, int startIndex, Predicate<T> match)
    {
        for (int i = startIndex; i < array.Length; ++i)
            if (match(array[i])) return i;

        return -1;
    }

    public static int FindIndex<T>(T[] array, int startIndex, int count, Predicate<T> match)
    {
        for (int i = startIndex; i < startIndex + count; ++i)
            if (match(array[i])) return i;

        return -1;
    }

    public static T? FindLast<T> (T[] array, Predicate<T> match)
    {
        for(int i = array.Length - 1; i >= 0; --i)
            if (match(array[i])) return array[i];

        return default(T?);
    }

    public static int FindLastIndex<T>(T[] array, Predicate<T> match)
    {
        for (int i = array.Length - 1; i >= 0; --i)
            if (match(array[i])) return i;
        return -1;
    }

    public static int FindLastIndex<T>(T[] array, int startIndex, Predicate<T> match)
    {
        for (int i = array.Length - 1 - startIndex; i >= 0; --i)
            if (match(array[i])) return i;
        return -1;
    }

    public static int FindLastIndex<T>(T[] array, int startIndex, int count, Predicate<T> match)
    {
        for (int i = array.Length - 1 - startIndex; i >= array.Length - 1 - count - startIndex; --i)
            if (match(array[i])) return i;

        return -1;
    }

    public static void ForEach<T>(T[] array, Action<T> action)
    {
        foreach(T item in array) action(item);
    }

    public static bool TrueForAll<T>(T[] array, Predicate<T> match)
    {
        foreach (T item in array) if (!match(item)) return false;
        return true;
    }

    #region Sort
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        for (int i = 0; i < array.Length - 1; ++i)
        {
            for (int j = 0; j < array.Length - 1 - i; ++j)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
    public static void Sort<T>(T[] array, System.Collections.Generic.IComparer<T>? comparer)
    {
        for(int i = 0; i < array.Length - 1; i++)
        {
            for(int j = 0; j < array.Length - 1 - i; ++j)
            {
                if (comparer?.Compare(array[j], array[j + 1]) > 0)
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public static void Sort<T>(T[] array, Comparison<T> comparison)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; ++j)
            {
                if (comparison(array[j], array[j + 1]) > 0)
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public static void Sort<T> (T[] array, int index, int length) where T : IComparable<T>
    {
        T[] temp = new T[length];
        for (int i = index; i < index + length; i++)
        {
            temp[i - index] = array[i];
        }
        Sort(temp);
        for (int i = index; i < index + length; i++)
        {
            array[i] = temp[i - index];
        }
    }

    public static void Sort<T>(T[] array, int index, int length, System.Collections.Generic.IComparer<T>? comparer)
    {
        T[] temp = new T[length];
        for (int i = index; i < index + length; i++)
        {
            temp[i - index] = array[i];
        }
        Sort(temp, comparer);
        for (int i = index; i < index + length; i++)
        {
            array[i] = temp[i - index];
        }
    }

    public static void Sort<TKey, TValue>(TKey[] keys, TValue[]? items, System.Collections.Generic.IComparer<TKey>? comparer)
    {
        for (int i = 0; i < keys.Length - 1; ++i)
        {
            for (int j = 0; j < keys.Length - i - 1; ++j)
            {
                int compareResult = comparer != null
                    ? comparer.Compare(keys[j], keys[j + 1])
                    : Comparer.Default.Compare(keys[j], keys[j + 1]);

                if (compareResult > 0)
                {
                    TKey tempKey = keys[j];
                    keys[j] = keys[j + 1];
                    keys[j + 1] = tempKey;

                    if (items != null)
                    {
                        TValue tempItem = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = tempItem;
                    }
                }
            }
        }

    }


    public static void Sort<TKey, TValue>(TKey[] keys, TValue[]? items, int index, int length, System.Collections.Generic.IComparer<TKey>? comparer)
    {
        for (int i = index; i < index + length - 1; ++i)
        {
            for (int j = index; j < index + length - 1; ++j)
            {
                int compareResult = comparer != null
                    ? comparer.Compare(keys[j], keys[j+1])
                    : Comparer.Default.Compare(keys[j], keys[j+1]);

                if (compareResult > 0)
                {
                    TKey tempKey = keys[j];
                    keys[j] = keys[j+1];
                    keys[j+1] = tempKey;

                    if (items != null)
                    {
                        TValue tempItem = items[j];
                        items[j] = items[j+1];
                        items[j+1] = tempItem;
                    }
                }
            }
        }
    }

    #endregion

    //public static int BinarySearch<T>(T[] array, T value)
    //{
    //    return BinarySearchRecursive(array, value, 0, array.Length - 1);
    //}

    //private static int BinarySearchRecursive<T> (T[] array, T value, int startIndex, int endIndex) where T : IEquatable<T>, IComparable<T>
    //{
    //    if (startIndex > endIndex)
    //    {
    //        return -1;
    //    }

    //    int searchIndex = (startIndex + endIndex) / 2;

    //    if (array[searchIndex].Equals(value))
    //    {
    //        return searchIndex;
    //    }
    //    else if (array[searchIndex].CompareTo(value) > 0)
    //    {
    //        return BinarySearchRecursive(array, value, startIndex, searchIndex - 1);
    //    }
    //    else
    //    {
    //        return BinarySearchRecursive(array, value, searchIndex + 1, endIndex);
    //    }
    //}
}