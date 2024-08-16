// using System;

// public class Node<T>
// {
//     public T Value { get; set; }
//     public Node<T> Next { get; set; }

//     public Node(T value)
//     {
//         Value = value;
//         Next = null;
//     }
// }

// public class LinkedList<T>
// {
//     private Node<T> head;

//     public void Add(T value)
//     {
//         if (head == null)
//         {
//             head = new Node<T>(value);
//         }
//         else
//         {
//             Node<T> current = head;
//             while (current.Next != null)
//             {
//                 current = current.Next;
//             }
//             current.Next = new Node<T>(value);
//         }
//     }

//     public void Print()
//     {
//         Node<T> current = head;
//         while (current != null)
//         {
//             Console.Write(current.Value + " ");
//             current = current.Next;
//         }
//         Console.WriteLine();
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         LinkedList<int> list = new LinkedList<int>();
//         list.Add(1);
//         list.Add(2);
//         list.Add(3);
//         list.Print(); // Output: 1 2 3
//     }
// }
using System;
using System.Collections.Generic;
class Node<T>
{
    public T Value { get; set; }
    public Node<T> Next { get; set; }
    public Node(T value)
    {
        Value = value;
        Next = null;
    }
}

public class main
{
    public static void Main(string[] args)
    {
        LinkedList<string> list = new LinkedList<string>();
        list.Add("Suriya");
        list.print();
    }
}