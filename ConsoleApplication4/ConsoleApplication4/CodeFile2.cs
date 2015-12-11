using System;

namespace CheekyBugger
{
    internal class RunIt
    {
        private static void Main()
        {
            Console.WriteLine("How old are you?");
            var Age = Console.ReadLine();
            var Integer = int.Parse("Age");
            Console.WriteLine(Integer+10);

        }
    }
}