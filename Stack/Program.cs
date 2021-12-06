
using System;


class Stack<T>
{
    /*  public Stack()
      {
      }
    */

    public class Node<T>
    {
        public Node<T> next = null;
        public Node<T> previous = null;
        public T data;
    }

    private Node<T> root = null;
    private Node<T> p;
    private Node<T> p2;

    public void Push(T Data)
    {
        p = root;
        Node<T> node = new Node<T>();
        node.data = Data;
        if (root == null)
        {
            root = node;
            return;
        }
        while (p.next != null)
        {
            p=p.next;
        }
        p.next = node;
        node.previous = p;
    }

    public void Pop()
    {
        
        if (root == null)
        {
            return;
        }

        if (root.next == null)
        {
            root = null;
            return;
        }
        p2 = root;
        p =root.next;
        while (p.next != null)
        {
            p = p.next;
            p2 = p2.next;
        }
        p2.next=null;
        p.previous = null;
    }

    public void Print()
    {
        p = root;
        while(p != null)
        {
            Console.WriteLine(p.data);
            p = p.next;
        }
    }

    public T Peek()
    {
        p = root;
       /* if(p == null)
        {
            
        }*/
        while (p.next != null)
        {
            p = p.next;
        }
        return p.data;
    }

    public void Clear()
    {

        if (root == null)
        {
            return;
        }

        if (root.next == null)
        {
            root = null;
            return;
        }
        p2 = root;
        p = root.next;
        root = null;
        while (p != null && p2!=null)
        {
            p2.next = null;
            p.previous = null;
            p2 = p;
            p = p.next;
        }

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






