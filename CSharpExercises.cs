using System;

namespace Aging
{
    class Test1
    {
        private static void Main()
        {
            Console.WriteLine("How old are you?");
            var Number = Console.ReadLine();
            var Integer = int.Parse(Number);
            Console.WriteLine(Integer+100+"years old!") ;

            
           
        }
    }

}