using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MyLinkedList<T> : IEnumerable<T>
{
    public MyLinkedListNode<T> First { get; private set; }
    public MyLinkedListNode<T> Last { get; private set; }

    private MyLinkedListNode<T>[] _nodes;

    public MyLinkedList(T[] values)
    {
        _nodes = new MyLinkedListNode<T>[values.Length];

        for(int i = 0; i < values.Length; i++)
        {
            _nodes[i] = new MyLinkedListNode<T>(values[i]);
        }

        First = _nodes[0];
        First.Next = _nodes[1];
        First.Previous = null;
        Last = _nodes[values.Length - 1];
        Last.Next = null;
        Last.Previous = _nodes[values.Length - 2];

        for (int i = 1; i < values.Length - 1; i++)
        {
            _nodes[i].Previous = _nodes[i - 1];
            _nodes[i].Next = _nodes[i + 1];
        }
    }



    public void AddFirst(T value)
    {
        // 구현
        MyLinkedListNode<T> node = new MyLinkedListNode<T>(value);
        node.Previous = null;
        First.Previous = node;
        node.Next = First;
        First = node;
    }

    public void AddLast(T value)
    {
        // 구현
        MyLinkedListNode<T> node = new MyLinkedListNode<T>(value);
        Last.Next = node;
        node.Previous = Last;
        node.Next = null;
        Last = node;

    }

    public void RemoveFirst()
    {
        // 구현
        First = First.Next;
        First.Previous = null;
    }

    public void RemoveLast()
    {
        // 구현
        Last = Last.Previous;
        Last.Next = null;
    }

    public bool Contains(T value)
    {
        // 구현
        MyLinkedListNode<T> findNode = Find(value);
        return findNode != null;
    }

    public MyLinkedListNode<T> Find(T value)
    {
        // 구현
        if (Equals(First.Value, value))
        {
            return First;
        }
        else
        {
            MyLinkedListNode<T> nextNode = First.Next;
            while(!Equals(nextNode.Value, value))
            {
                nextNode = nextNode.Next;
                if (nextNode == Last.Next)
                {
                    Console.WriteLine("Not Foundee!");
                    return null;
                }
            }
            return nextNode;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        
        yield return First.Value;

        MyLinkedListNode<T> nextNode = First.Next;
        while(nextNode != null && nextNode != Last.Next)
        {
            yield return nextNode.Value;
            nextNode = nextNode.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("LinkedList Elements : \n");
        int i = 1;
        foreach (var node in _nodes)
        {
            sb.Append($"{i}st Node : \"{node.Value}\"\n");
            i++;
        }
        return sb.ToString();
    }
}

public class MyLinkedListNode<T>
{
    public T Value { get; set; }
    public MyLinkedListNode<T> Next { get; set; }
    public MyLinkedListNode<T> Previous { get; set; }

    public MyLinkedListNode(T value)
    {
        Value = value;
    }
}
