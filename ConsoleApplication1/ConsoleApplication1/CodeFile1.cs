using System;


    class Cave
    {
        private static void Main(string[] args)
        {
            double[] numbers = {10.5, 3.58, 4.3456, 100.43, 3.4};

            foreach (double number in numbers)
            {
                Console.Write("{0}", number.ToString("N2"));

            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }

