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
            return _count;
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

    public void CopyTo(T[] array)
    {
        for (int i = 0; i < _items.Length; i++)
        {
            array[i] = _items[i];
        }
    }
    public void CopyTo(T[] array, int arrayIndex)
    {
        for (int i = arrayIndex; i < arrayIndex+_items.Length; i++)
        {
            array[i] = _items[i - arrayIndex];
        }
    }
    public void CopyTo(int index, T[] array, int arrayIndex, int count)
    {
        for(int i = index; i < index + count; ++i)
        {
            array[arrayIndex + (i - index)] = _items[i];
        }
    }
    public bool Remove(T item)
    {
        if(item == null) 
            return false;
        int index = IndexOf(item);
        if (index == -1)
            return false;

        RemoveAt(index);
        return true;
    }

    public int IndexOf(T item)
    {
        //for(int i = 0; i < _count; ++i)
        //{
        //    if (Equals(item, _items[i]))
        //        return i;
        //}
        //return -1;
        return IndexOf(item, 0, _count);
    }

    public int IndexOf(T item, int index)
    {
        return IndexOf(item, index, _count - index);
    }

    public int IndexOf(T item, int index, int count)
    {
        for (int i = index; i < index + count; ++i)
        {
            if (i > _count)
                return -1;

            if (Equals(item, _items[i]))
                return i;
        }

        return -1;
    }
    public void Insert(int index, T item)
    {
        if(index + _count > _items.Length / 2)
        {
            Array.Resize(ref _items, _items.Length * 2);
        }

        for (int i = _count; i >= index; --i)
        {
            _items[i] = _items[i - 1];
        }
        _count++;
        _items[index] = item;
    }
    public void RemoveAt(int index)
    {
        for(int i = index; i < _count - 1; ++i)
        {
            _items[i] = _items[i + 1];
        }
        _count--;
    }

    public int RemoveAll(Predicate<T> match)
    {
        int findCount = 0;
        for (int i = 0; i < _count; i++)
        {
            if (match(_items[i]))
            {
                Remove(_items[i]);
                findCount++;
            }
        }
  
        return findCount;
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
        sb.Append("List Elements : ----------------\n");
        for (int i = 0; i < _count; ++i)
        {
            sb.Append($"\"{_items[i]}\"\n");
        }
        sb.Append("--------------------------------\n");

        return sb.ToString();
    }

    // 나머지 메서드들도 구현
}
