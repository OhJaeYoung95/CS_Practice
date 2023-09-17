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
    private int _count = 0;

    public MyQueue()
    {
        // 초기화 로직
        _items = new T[4];
        _firstIndex = 0;
        _lastIndex = 0;
    }
    public int ItemsLength
    {
        get { return _items.Length; }
    }
    public int Count
    {
        get
        {
            // 구현
            return _count;
        }
    }

    public void Enqueue(T item)
    {
        // 구현

        if (_lastIndex == _items.Length && _firstIndex != 0)
        {
            Array.Resize(ref _items, _items.Length * 2);
            _lastIndex = 0;
        }
        else if(_lastIndex == _items.Length && _firstIndex == 0)
        {
            Array.Resize(ref _items, _items.Length * 2);
        }
        else if(_lastIndex == _firstIndex && _lastIndex != 0)
        {
            T[] firstArray = new T[_items.Length - _firstIndex + 1];
            T[] lastArray = new T[_lastIndex];
 
            for (int i = 0; i < _items.Length - _firstIndex; i++)
            {
                firstArray[i] = _items[i + _firstIndex];
            }

            for (int i = 0; i < _lastIndex; i++)
            {
                lastArray[i] = _items[i];
            }

            Array.Resize(ref _items, _items.Length * 2);

            for (int i = 0; i < firstArray.Length; i++)
            {
                _items[i] = firstArray[i];
            }

            for (int i = firstArray.Length; i < firstArray.Length + lastArray.Length; i++)
            {
                _items[i] = lastArray[i - firstArray.Length];
            }
            _firstIndex = 0;
            _lastIndex = firstArray.Length + lastArray.Length - 2;
        }

        _items[_lastIndex++] = item;
        _count++;

    }

    public T Dequeue()
    {
        // 구현
        T dequeueItem = Peek();
        _firstIndex++;
        _count--;
        return dequeueItem;
    }

    public T Peek()
    {
        // 구현
        return _items[_firstIndex];
    }

    public IEnumerator<T> GetEnumerator()
    {
        if (_firstIndex < _lastIndex)
        {
            for (int i = 0; i < _lastIndex; ++i)
            {
                yield return _items[i];
            }
        }
        else
        {
            for (int i = _firstIndex; i < _items.Length; ++i)
            {
                yield return _items[i];
            }

            for (int i = 0; i < _lastIndex; ++i)
            {
                yield return _items[i];
            }
        }

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public override string ToString()
    {
        //if (_lastIndex == _items.Length && _firstIndex != 0)
        //else if (_lastIndex == _items.Length && _firstIndex == 0)
        //else if (_lastIndex == _firstIndex && _lastIndex != 0)
        StringBuilder sb = new StringBuilder();
        sb.Append("Queue Elements : ");

        if(_firstIndex < _lastIndex)
        {
            for (int i = _firstIndex - 1; i < _lastIndex; ++i)
            {
                sb.Append($"{_items[i]} ");
            }
        }
        else
        {
            for (int i = _firstIndex ; i < _items.Length - _firstIndex; ++i)
            {
                sb.Append($"{_items[i]} ");
            }

            for(int i = 0; i < _lastIndex; ++i)
            {
                sb.Append($"{_items[i]} ");
            }
        }
        return sb.ToString();
    }
}
