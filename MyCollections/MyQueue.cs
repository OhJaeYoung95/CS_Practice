using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyQueue<T> : IEnumerable<T>
{
    private T[] _items;
    private int _firstIndex = 0;
    private int _lastIndex = 0;

    public MyQueue()
    {
        // 초기화 로직
        _items = new T[4];
        _firstIndex = 0;
        _lastIndex = 0;
    }

    public int Count
    {
        get
        {
            // 구현
            return _items.Length;
        }
    }

    public void Enqueue(T item)
    {
        // 구현
        if(_lastIndex > _items.Length / 2)
        {
            Array.Resize(ref _items, _items.Length * 2);
        }
        _items[_lastIndex++] = item;
    }

    public T Dequeue()
    {
        // 구현
        T dequeueItem = Peek();
        _firstIndex++;
        return dequeueItem;
    }

    public T Peek()
    {
        // 구현
        return _items[_firstIndex];
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = _firstIndex; i < _lastIndex; ++i)
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
        sb.Append("Queue Elements : ");
        for(int i = _firstIndex; i < _lastIndex; ++i)
        {
            sb.Append($"{_items[i]} ");
        }
        return sb.ToString();
    }
}
