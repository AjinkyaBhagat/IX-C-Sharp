using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("***Hashtable***");
            Hashtable ht = new Hashtable();
            ht.Add("111", "Ajinkya");
            ht.Add("222", "Nitin");
            ht.Add("333", "Shardul");
            ht.Add("444", "Parth");
            ht.Add("555", "Vedant");

            if (ht.ContainsKey("666"))
            {
                Console.WriteLine("This Key Aleady in the list");
            }
            else
            {
                ht.Add("666", "Rohit");
                Console.WriteLine("Added new key");
            }
            //foreach (DictionaryEntry k in ht)
            //{
            //    Console.WriteLine("key:{0} Value:{1}",k.Key,k.Value);
            //}
            foreach(var i in ht.Keys)
            {
                Console.WriteLine(i+" "+ht[i]);
            }
            //Remove 
            Console.WriteLine("***Remove***");
            ht.Remove("222");
            foreach (var i in ht.Keys)
            {
                Console.WriteLine(i + " " + ht[i]);
            }
            //ContainsKey
            Console.WriteLine("***containsKey***");
            if (ht.ContainsKey("555"))
            {
                Console.WriteLine("Key is present");
            }
           

            //Stack
            Console.WriteLine("***Stack***");
            Stack<int> myStack = new Stack<int>();
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            foreach(var x in myStack) 
            { 
                Console.WriteLine(x); 
            }
            //pop
            Console.WriteLine(myStack.Pop()); 
            //peek
            Console.WriteLine(myStack.Peek());
            //contains
            Console.WriteLine(myStack.Contains(20));

            //Queue
            Console.WriteLine("***Queue***");
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);
            myQueue.Enqueue(40);
            myQueue.Enqueue(50);
            foreach(var x in myQueue)
            {
                Console.WriteLine(x);
            }
            //Dequeue
            Console.WriteLine("***Dequeue***");
            myQueue.Dequeue();
            foreach (var x in myQueue)
            {
                Console.WriteLine(x);
            }
            //peek
            Console.WriteLine(myQueue.Peek());
            //contains
            Console.WriteLine(myQueue.Contains(70));
        }
    }
}
