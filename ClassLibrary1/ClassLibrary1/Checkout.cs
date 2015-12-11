using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout 
{
    public class Checkout
    {
        public string ShowAmount()
        {
            return "Please Scan Item";
        }

        public int ShowAmount(string input)
        {
            var totalAmount = 0;
            var checkoutItems = new Dictionary<string, int> {};

            foreach (char letter in input)
            {
                if (letter.Equals('A'))
                {
                    if (checkoutItems.ContainsKey("A"))
                    {
                        checkoutItems["A"] += 1;
                    }
                    else
                    {
                        checkoutItems["A"] = 1;
                    }
                }
                else if (letter.Equals('B'))
                {
                    if (checkoutItems.ContainsKey("B"))
                    {
                        checkoutItems["B"] += 1;
                    }
                    else
                    {
                        checkoutItems["B"] = 1;
                    }
                }
                else if (letter.Equals('C'))
                {
                    if (checkoutItems.ContainsKey("C"))
                    {
                        checkoutItems["C"] += 1;
                    }
                    else
                    {
                        checkoutItems["C"] = 1;
                    }
                }
                else if (letter.Equals('D'))
                {
                    if (checkoutItems.ContainsKey("D"))
                    {
                        checkoutItems["D"] += 1;
                    }
                    else
                    {
                        checkoutItems["D"] = 1;
                    }
                }
            }

            //go into the dictionary and separate each of the key value pairs
            //calculate the total amount for each item based on how many there is
            //calculate the overall total
            //return the total

            checkoutItems
            return totalAmount;
         }


    }
}

