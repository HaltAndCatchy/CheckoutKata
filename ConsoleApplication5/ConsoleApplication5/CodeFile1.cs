using System;

namespace Test
{
    class test1
    {
        private static void Main()
        {
            Console.WriteLine("Plz enter integer");
            var Number = Console.ReadLine();
            var Integer = int.Parse(Number);
            Console.WriteLine(Number+1);

        }
    }

}