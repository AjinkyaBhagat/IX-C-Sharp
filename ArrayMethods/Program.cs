using System;
namespace ArrayMethods
{
    internal class Program
    {
        public class ArrayMethods
        {
            public int arrLength(int[] arr)
            {
                return arr.Length;
            }
            public int[] arrRevers(int[] arr)
            {
                Array.Reverse(arr);
                return arr;
            }
            public int[] arrSort(int[] arr)
            {
                Array.Sort(arr);
                return arr;
            }  
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*Array*");
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80 };
            ArrayMethods obj= new ArrayMethods();
            Console.WriteLine(obj.arrLength(arr));
            
            //Reverse
            int[] arr2 = new int[arr.Length];
            arr2=obj.arrRevers(arr);
            foreach (int i in arr2)
            {
                Console.WriteLine("Reverse :"+i);
            }

            //Sort
            int[] arr3 = new int[arr.Length];
            arr3=obj.arrSort(arr);
            foreach (int i in arr2)
            {
                Console.WriteLine("Sorted :" + i);
            }
            
        }
    }
}
