using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculatefactorial();
            // EvenOdd();
            // Palindrome();
            // PalString();
            SumOfArray();
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

        static void SumOfArray()
        {
            Console.WriteLine("Enter the size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum =0;
            int [] numbers = new int[n];
            Console.WriteLine("Enter an array of numbers to find sum of digits:");

            for(int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }
            // foreach (var num in numbers) //another method to find sum of digits
            // {
            //     sum += Convert.ToInt32(num);
            // }   
            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}

/*---------------Abstract OOps---------

using System;

public abstract class Animal
{
    public abstract void Sound();
    
    public void Eat(){
        Console.WriteLine("Animal Eat");
    }
}
public class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog Barks");
    }
}
public class Tiger : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Tiger Roar");
    }
}
public class Program{
    public static void Main(string[] args){
        Animal dog = new Dog();
        dog.Sound();
        dog.Eat();
        
        Animal tiger = new Tiger();
        tiger.Sound();
        tiger.Eat();
    }
}
-----------------Inheritance OOps----------------

using System; //Inheritance

public class Teacher //Base class
{
    public string Name
    {
        get;
        set;
    }
    public string Name2
    {
        get;
        set;
    }
    public string StudentName
    {
        get;
        set;
    }
    public string StudentName2
    {
        get;
        set;
    }
    public void Subject()
    {
        Console.WriteLine($"{Name} is teaching Science");
    }
    public void Subject2()
    {
        Console.WriteLine($"{Name2} is teaching Biology");
    }
    public void Timing()
    {
        Console.WriteLine($"{Name} is teaching 2 hours");
    }
    public void Timing2()
    {
        Console.WriteLine($"{Name2} is teaching 3 hours");
    }
}

public class Student : Teacher //Derived Class
{
    public void Science()
    {
        Console.WriteLine($"{StudentName} is Studying Science from {Name}");
    }
}

public class Student2 : Teacher //Derived Class
{
    public void Biology()
    {
        Console.WriteLine($"{StudentName2} is Studying Biology from {Name2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student obj = new Student();
        obj.Name = "Sushmita";
        obj.StudentName="Sharique";
        obj.Subject();
        obj.Timing();
        obj.Science();
        
        Student2 obj1 = new Student2();
        obj1.Name2 = "Rashmi";
        obj1.StudentName2="Ahmad";
        obj1.Subject2();
        obj1.Timing2();
        obj1.Biology();
    }
}
*/