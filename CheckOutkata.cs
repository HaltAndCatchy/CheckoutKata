using System;

namespace CheckOut
{
    class CheckOut
    {
        static void Main()
        {
            
            var items = Console.ReadLine ();
            int subtotal = 0;
            int countitems = 0;
            int Adiscount = 20;
            foreach (char item in items) {

                if (item == 'A') { subtotal = subtotal + 50; countitems++;}
                 
                if (item == 'B') subtotal = subtotal + 30; 
              
                if (item == 'C') subtotal = subtotal + 20;

                if (item == 'D') subtotal = subtotal + 15;
                
            
            }
            subtotal -= Adiscount * (countitems/3);
            Console.WriteLine("subtotal: "+subtotal);
            Console.ReadLine();
 
        }
    }
}