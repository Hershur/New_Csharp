using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor bears same name with he class and acts as a a method
            Console.WriteLine("Enter your name");
            var inputString = Console.ReadLine();
            Console.WriteLine($"Hello {inputString}, what year were you born?");
            var birthYear = int.Parse(Console.ReadLine());
            int age = 2019 - birthYear;
            Console.WriteLine($"Wow, you are {age} years old");
            
        }
    }
}
