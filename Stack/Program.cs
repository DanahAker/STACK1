
using System;


class Stack<T>
{

    public class Node<T>
    {
        public Node<T> previous = null;
        public T data;
    }

    private Node<T> root = null;
    private Node<T> current=null;
    private Node<T> p;

    public void Push(T Data)
    {
        Node<T> node = new Node<T>();
        node.data = Data;
        p=node;
        p.previous = current;
        current = node;

    }

    public void Pop()
    {
        p = current;
        current=current.previous;
        p.previous=null;
        
    }

    public void Print()
    {
        p = current;
        while(p != null)
        {
            Console.WriteLine(p.data);
            p = p.previous;
        }
    }

    public T Peek()
    {

        return current.data;
    }

    public void Clear()
    {

        root = null;
        current = root;

    }
}

class Program
{
    static void Main()
    {
        Stack<int> s = new Stack<int>();
        Console.WriteLine("push 1");
        s.Push(1);
        Console.WriteLine("push 9");
        s.Push(9);
        Console.WriteLine("all elements ");
        s.Print();
        object v = s.Peek();
        Console.WriteLine("last element:");
        Console.WriteLine(Convert.ToInt32(v));
        s.Pop();
        Console.WriteLine("after pop:");
        s.Print();
        Console.WriteLine("push 10");
        s.Push(10);
        Console.WriteLine("push 91");
        s.Push(91);
        Console.WriteLine("all elements");
        s.Print();
        s.Clear();
        Console.WriteLine("print after clear:");
        s.Print();

        /*Console.WriteLine("");
        Stack<String> s2 = new Stack<string>();
        Console.WriteLine("push hello");
        s2.Push("hello");
        Console.WriteLine("push world");
        s2.Push("world");
        Console.WriteLine("all elements ");
        s2.Print();
        */
    }
}






