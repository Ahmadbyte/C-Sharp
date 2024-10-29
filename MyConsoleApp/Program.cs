using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculatefactorial();
            EvenOdd();
            Palindrome();
            PalString();
        }
        static void Calculatefactorial()
        {
            Console.WriteLine("Enter a number to find factorial :");
            int num = Convert.ToInt32(Console.ReadLine());

            long factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("The factorial of " + num + " is: " + factorial);
        }
        static void EvenOdd()
        {
            Console.WriteLine("Enter num to find EvenOdd :");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even : " + num);
            }
            else
            {
                Console.WriteLine("Not Even : " + num);
            }
        }
        static void Palindrome()
        {
            Console.WriteLine("Enter a number to find pal :");
            int num = Convert.ToInt32(Console.ReadLine());

            int rev = 0;
            int temp = num;

            while (num > 0)
            {
                int ld = num % 10;
                rev = ld + rev * 10;
                num /= 10;
            }
            if (temp == rev)
            {
                Console.WriteLine("Number is Palidrome : " + rev);
            }
            else
            {
                Console.WriteLine("Number is not Palidrome : " + rev);
            }
        }

        static void PalString()
        {
            Console.WriteLine("Enter String to find Palstring:");
            string str = Console.ReadLine();
            string rstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                rstr = str[i] + rstr;
            }
            Console.WriteLine("Rev String is : " + rstr);

            // if (str.Equals(rstr, StringComparison.OrdinalIgnoreCase))
            if (str.ToLower() == rstr.ToLower()) //another method to compare string
            {
                Console.WriteLine("The string is a palindrome : " + rstr);
            }
            else
            {
                Console.WriteLine("The string is not a palindrome : " + rstr);
            }
        }
    }
}