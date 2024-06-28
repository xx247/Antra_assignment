using System;


namespace Day07_assignment;

internal class MyList<T>
{
    private T[] _items;
    private int _count;
    

    public MyList(int capacity = 4)
    {

        _items = new T[capacity];
        _count = 0;
    }


    public void Add(T element)
    {
        EnsureCapacity();
        _items[_count++] = element;
    }

    public T Remove(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        T removedItem = _items[index];

        for (int i = index; i < _count - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        _count--;
        _items[_count] = default(T); // Clear the last element  For reference types (like string or object), default(T) returns null.
        //For value types (like int, float, bool), default(T) returns the zero value for that type.
        return removedItem;
    }

    public bool Contains(T element)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_items[i].Equals(element))
            {
                return true;
            }
        }

        return false;
    }

    public void Clear()
    {
        _items = new T[4];
        _count = 0;
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > _count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        EnsureCapacity();

        for (int i = _count; i > index; i--)
        {
            _items[i] = _items[i - 1];
        }

        _items[index] = element;
        _count++;
    }

    public void DeleteAt(int index)
    {
        Remove(index);
    }

    public T Find(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return _items[index];
    }

    private void EnsureCapacity()
    {
        if (_count == _items.Length)
        {
            int newCapacity = _items.Length * 2;
            T[] newArray = new T[newCapacity];
            Array.Copy(_items, newArray, _count);
            _items = newArray;
        }
    }
}
