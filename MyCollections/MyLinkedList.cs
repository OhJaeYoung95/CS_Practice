using System;
using System.Collections;

public class MyLinkedList<T> : IEnumerable<T>
{
    public MyLinkedListNode<T> First { get; private set; }
    public MyLinkedListNode<T> Last { get; private set; }

    public MyLinkedList(T[] values)
    {
        MyLinkedListNode<T> first = new MyLinkedListNode<T>(values[0]);
        First = first;

        MyLinkedListNode<T> nextNode = First.Next;


        for (int i = 1; i < values.Length - 1; ++i)
        {
            nextNode = new MyLinkedListNode<T>(values[i]);
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
