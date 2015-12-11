using System;

namespace CSharpEx1
{
    class Program
    {
        private static void Main(string[]args)
        {
            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            var AgeInt = int.Parse(age);
            Console.WriteLine("You are {0} years old.",AgeInt);
            Console.ReadLine();



        }
        class Ex2Asterisks
        {
            private static void Exe(string[] args)
            {
                Console.WriteLine("*****");
                Console.WriteLine("*****");
                Console.WriteLine("*****");
                Console.WriteLine("*****");
                Console.WriteLine("*****");
                Console.ReadLine();
            }
        }
    }

}

