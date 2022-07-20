using System;
using System.Collections;

namespace ArrayAndArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Methods");
            int[] numArr =new int[6] {101,102,103,104,102,105};
            int[] numArr2 = new int[5];
            //Length
            Console.WriteLine(numArr.Length);
            //Indexof
            Console.WriteLine(Array.IndexOf(numArr,105));
            //Copy
            Array.Copy(numArr,numArr2,5);
            foreach(int num in numArr2)
            {
                Console.WriteLine(num);
            }
            //Reverse
            Array.Reverse(numArr2);
            foreach(int num in numArr2)
            {
                Console.WriteLine(num);
            }
            //Sort
            Array.Sort(numArr2);
            foreach (int num in numArr2)
            {
                Console.WriteLine(num);
            }
           //Rank
            Console.WriteLine(numArr2.Rank);
            //LastIndexOf
            Console.WriteLine(Array.LastIndexOf(numArr, 102));
            //Equals
            Console.WriteLine(Array.Equals(numArr,numArr2));


            //Array List
            Console.WriteLine("***Array List***");
            var arrList1 = new ArrayList();
            arrList1.Add(1);
            arrList1.Add("Ajinkya");
            arrList1.Add("10.2");
            arrList1.Add(null);
            arrList1.Add(false);
            foreach(var num in arrList1)
            {
                Console.WriteLine(num);
            }
            var listItem = arrList1[1];
            Console.WriteLine(listItem);
            //Remove
            arrList1.Remove(null);
            foreach (var num in arrList1)
            {
                Console.WriteLine(num);
            }
            //Insert
            arrList1.Insert(1,"Hello");
            foreach (var num in arrList1)
            {
                Console.WriteLine(num);
            }
            //RemoveAt
            arrList1.RemoveAt(1);
            foreach (var num in arrList1)
            {
                Console.WriteLine(num);
            }
            //contains
            Console.WriteLine(arrList1.Contains("Ajinkya"));
        }
    }
}
