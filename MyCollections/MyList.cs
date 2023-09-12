using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyList<T> : IList<T>
{
    private T[] _items;

    public MyList()
    {
        // 초기화 로직
    }

    public int Count
    {
        get
        {
            // 구현
            return 0;
        }
    }

    public bool IsReadOnly => false;

    public T this[int index]
    {
        get
        {
            // 구현
            return default(T);
        }
        set
        {
            // 구현
        }
    }

    public void Add(T item)
    {
        // 구현
    }

    public void Clear()
    {
        // 구현
    }

    public bool Contains(T item)
    {
        // 구현
        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {

    }
    public bool Remove(T item)
    {
        return true;
    }
    public IEnumerator<T> GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int IndexOf(T item)
    {
        return 0;
    }
    public void Insert(int index, T item)
    {

    }
    public void RemoveAt(int index)
    {

    }
    // 나머지 메서드들도 구현
}
