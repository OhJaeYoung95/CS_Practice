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

    public void Clear()
    {
        MyLinkedListNode<T> nextNode = First.Next;
        First = null;
        while (nextNode != null)
        {
            MyLinkedListNode<T> clearNode = nextNode;
            nextNode = null;
            nextNode = clearNode.Next;
            clearNode = null;
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

    public MyLinkedListNode<T> AddAfter(MyLinkedListNode<T> node, T value)
    {
        if (node == null)
        {
            Console.WriteLine($"Not Founded Node({node})!");
            return null;
        }

        MyLinkedListNode<T> insertNode = new MyLinkedListNode<T>(value);
        AddAfter(node, insertNode);

        return insertNode;
    }

    public void AddAfter(MyLinkedListNode<T> node, MyLinkedListNode<T> newNode)
    {
        if(node == null)
        {
            Console.WriteLine($"Not Founded Node({node})!");
            return;
        }

        if(node == Last)
        {
            newNode.Next = null;
            node.Next = newNode;
            newNode.Previous = node;
        }
        else
        {
            newNode.Next = node.Next;
            node.Next.Previous = newNode;
            newNode.Previous = node;
            node.Next = newNode;
        }

    }

    public MyLinkedListNode<T> AddBefore(MyLinkedListNode<T> node, T value)
    {
        if (node == null)
        {
            Console.WriteLine($"Not Founded Node({node})!");
            return null;
        }

        MyLinkedListNode<T> insertNode = new MyLinkedListNode<T>(value);
        AddBefore(node, insertNode);

        return insertNode;
    }

    public void AddBefore(MyLinkedListNode<T> node, MyLinkedListNode<T> newNode)
    {
        if (node == null)
        {
            Console.WriteLine($"Not Founded Node({node})!");
            return;
        }

        if (node == First)
        {
            node.Previous = newNode;
            newNode.Previous = null;
            newNode.Next = node;
        }
        else
        {
            newNode.Previous = node.Previous;
            node.Previous.Next = newNode;
            newNode.Next = node;
            node.Previous = newNode;
        }
    }
    public bool Remove(T value)
    {
        MyLinkedListNode<T> findNode = Find(value);
        if (findNode == null)
            return false;
        Remove(findNode);
        return true;
    }
    public void Remove(MyLinkedListNode<T> node)
    {
        if(node == null)
        {
            throw new ArgumentNullException(nameof(node), "The 'node' parameter cannot be null.");
        }
        else if(Find(node.Value) == null)
        {
            throw new InvalidOperationException("The 'node' Not found  so, InvalidOperationException occurred.");
        }
        else
        {
            if(node == First)
            {
                First = node.Next;
                First.Previous = null;
                node = null;
            }
            else if(node == Last)
            {
                Last = node.Previous;
                Last.Next = null;
                node = null;
            }
            else
            {
                node.Previous.Next = node.Next;
                node.Next.Previous = node.Previous;
                node = null;
            }
        }
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
                    Console.WriteLine("Not Found!");
                    return null;
                }
            }
            return nextNode;
        }
    }
    public MyLinkedListNode<T>? FindLast(T value)
    {
        if (Equals(Last.Value, value))
        {
            return Last;
        }
        else
        {
            MyLinkedListNode<T> previousNode = Last.Previous;
            while (!Equals(previousNode.Value, value))
            {
                previousNode = previousNode.Previous;
                if (previousNode == First.Previous)
                {
                    Console.WriteLine("Not Found!");
                    return null;
                }
            }
            return previousNode;
        }
    }
    public void CopyTo(T[] array, int index)
    {
        int nodeIndex = 0;
        array[nodeIndex] = First.Value;
        MyLinkedListNode<T> nextNode = First.Next;
        while (nextNode != null)
        {
            nodeIndex++;
            array[nodeIndex] = nextNode.Value;
            nextNode = nextNode.Next;
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
        sb.Append("LinkedList Elements : ----------------\n");
        int i = 0;
        if(First == null)
        {
            sb.Append("LinkedList is Empty!\n");
            sb.Append("--------------------------------------\n");
            return sb.ToString();
        }
        sb.Append($"{i}st Node : \"{First.Value}\"\n");
        MyLinkedListNode<T> nextNode = First.Next;
        while (nextNode != null)
        {
            sb.Append($"{i++}st Node : \"{nextNode.Value}\"\n");
            nextNode = nextNode.Next;
        }

        sb.Append("--------------------------------------\n");
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
