using Day07_assignment;
using System.Collections;

MyStack<string> stack = new MyStack<string>(5);
stack.Push("1");
stack.Push("2");
stack.Push("3");
Console.WriteLine("count: " + stack.Count());


MyList<int> list = new MyList<int>();
list.Add(1);
list.Add(2);
list.Add(3);
Console.WriteLine("Element at index 1: " + list.Find(1));
