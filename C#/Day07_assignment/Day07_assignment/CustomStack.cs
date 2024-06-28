using System;


namespace Day07_assignment;

public class MyStack<T>
{
    private T[] _items;
    private int _top;

    public MyStack(int capacity)
    {
        _items = new T[capacity];
        _top = -1;
    }

    public int Count()
    {
        return _top + 1;
    }

    public T pop()
    {
        if(_top < 0)
        {
            throw new InvalidOperationException("Stack is Empty");

        }

        T item = _items[_top]; ;
        _top--;
        return item;
    }

    public void Push(T item)
    {
        if (_top == _items.Length - 1)
        {
            throw new StackOverflowException("Stack is full");
        }
        _top++;
        _items[_top] = item;
    }
}
