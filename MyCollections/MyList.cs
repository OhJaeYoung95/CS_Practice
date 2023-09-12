using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyList<T> : IList<T>
{
    private T[] _items;
    private int _count;

    public MyList()
    {
        // 초기화 로직
        _items = new T[4];
        _count = 0;
    }

    public int Count
    {
        get
        {
            // 구현
            return _items.Length;
        }
    }

    public bool IsReadOnly => false;

    public T this[int index]
    {
        get
        {
            // 구현
            return _items[index];
        }
        set
        {
            // 구현
            _items[index] = value;
        }
    }

    public void Add(T item)
    {
        // 구현
        if(_count > _items.Length / 2)
        {
            Array.Resize(ref _items, _items.Length * 2);
        }

        _items[_count++] = item;
    }

    public void Clear()
    {
        // 구현

        // 둘다 안댐

        // 방법 1
        _items.ToList().Clear();

        // 방법 2
        for (int i = 0; i < _count; i++)
        {
            _items[i] = default(T);
        }

        _count = 0;
    }

    public bool Contains(T item)
    {
        // 구현
        foreach(T checkItem in _items)
        {
            if(checkItem != null)
                if (checkItem.Equals(item))
                    return true;
        }
        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {

    }
    public bool Remove(T item)
    {
        return true;
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

    public IEnumerator<T> GetEnumerator()
    {
        for(int i = 0; i < _count; ++i)
        {
            yield return _items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("List Elements : ");

        for(int i =0; i<_count; ++i)
        {
            sb.Append($"\"{_items[i]}\" ");
        }

        return sb.ToString();
    }

    // 나머지 메서드들도 구현
}
