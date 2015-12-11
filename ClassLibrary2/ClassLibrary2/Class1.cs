using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class Checkout 
    {

        public static string Display()
        {
            return "Hello and welcome to the checkout";       
        }

        public static int Display(string items)
        {
            SortInputtedItems(items);
            
            if (items == "A")
            {
                return 50;
            }
            if (items == "B")
            {
                return 30;
            }
            if (items == "C")
            {
                return 20;
            }
            if (items == "D")
            {
                return 15;
            }
            return 0;

        }

        public static Dictionary<string, int> SortInputtedItems(string scannedItems)
        {
            var initialItemCount = new Dictionary<string, int>() {{"A", 0}, {"B", 0}, {"C", 0}, {"D", 0}};
            foreach (char item in scannedItems)
            {
                if (initialItemCount.ContainsKey(item.ToString()))
                {
                    initialItemCount[item.ToString()] += 1;
                }
            }
            return initialItemCount;
        } 
    }
}
