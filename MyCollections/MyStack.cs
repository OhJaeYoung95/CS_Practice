using System;
using System.Collections;

public class MyStack<T> : IEnumerable<T>
{
    private T[] _items;
    int _count = 0;

    public MyStack()
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

    public void Push(T item)
    {
        // 구현
        if(_count > _items.Length / 2)
        {
            Array.Resize(ref _items, _items.Length * 2);
        }
        _items[_count++] = item;
    }

    public T Pop()
    {
        // 구현
        T popItem = Peek();
        _count--;
        return popItem;
    }

    public T Peek()
    {
        // 구현
        T peakItem = _items[_count - 1];
        return peakItem;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = _count - 1; i >= 0; i--)
        {
            yield return _items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
