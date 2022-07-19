using System;
namespace FirstAssignment
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("All Conditional Statements");
            int age = 20;
            //If Else-If Else Statment
            Console.WriteLine("If Else-If Else");
            if (age == 0)
            {
                Console.WriteLine("Invalid Age");
            }
            else if (age >= 18) {
                Console.WriteLine("You can drive");
            }
            else
            {
                Console.WriteLine("Sorry you are below 18 years");
            }

            //While Loop
            Console.WriteLine("1 to 10 Numbers using While Loop");
            int num = 1;
            while (num <= 10)
            {
                Console.WriteLine(num);
                num++;
            }

            //Do-While Loop
            Console.WriteLine("Table of 2 using Do-While Loop");
            int number = 2;
            int i = 1;
            do
            {
                Console.WriteLine(number*i);
                i++;
            }while (i <= 10);

            //For Loop
            Console.WriteLine("Displaying all city's using For Loop");
            string[] city = { "pune", "mumbai", "delhi", "sambhajinagar" };
            for(int j = 0; j < city.Length; j++)
            {
                Console.WriteLine(city[j]);
            }

            //ForEach Loop
            Console.WriteLine("Displaying all city's using ForEach Loop");
            foreach (string j in city)
            {
                Console.WriteLine(j);
            }

            //Switch
            Console.WriteLine("Checking Vowels using Switch");
             Console.WriteLine("Enter Alphabet");
            char ch = char.Parse(Console.ReadLine());
            switch (ch) {
                 case 'a':
                     Console.WriteLine("Vowel");
                     break;
                 case 'e':
                     Console.WriteLine("Vowel");
                     break;
                 case 'i':
                     Console.WriteLine("Vowel");
                     break;
                 case 'o':
                     Console.WriteLine("Vowel");
                     break;
                 case 'u':
                     Console.WriteLine("Vowel");
                     break;
                 default:
                     Console.WriteLine("Not A Vowel");
                     break;
             }
        }
    }
}
