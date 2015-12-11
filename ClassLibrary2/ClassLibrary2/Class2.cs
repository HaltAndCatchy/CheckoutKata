using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using CheckoutKata;

namespace CheckoutTesting
{
    [TestFixture]
    internal class CheckoutTests
    {
        [Test]
        public void CheckingReturnCapability()
        {
            Assert.That(Checkout.Display(), Is.EqualTo("Hello and welcome to the checkout"));
        }

        [Test]
        public void CheckingReadingInputCapabilityItemA()
        {
            Assert.That(Checkout.Display("A"), Is.EqualTo(50));
        }

        [Test]
        public void CheckingRecognitionOfInvalidInput()
        {
            Assert.That(Checkout.Display("Z"), Is.EqualTo(0));
        }

        [Test]
        public void CheckingReadingInputCapabilityItemB()
        {
            Assert.That(Checkout.Display("B"), Is.EqualTo(30));
        }

        [Test]
        public void CheckingReadingInputCapabilityItemC()
        {
            Assert.That(Checkout.Display("C"), Is.EqualTo(20));

        }

       
        [Test]
        public void CheckingReadingInputCapabilityItemD()
        {
            Assert.That(Checkout.Display("D"), Is.EqualTo(15));
        }

        [Test]
        public void CheckingInputGetsSorted()
        {
            var sortedItems = new Dictionary<string, int>() { { "A", 2 }, { "B", 0 }, { "C", 0 }, { "D", 0 } };
            Assert.That(Checkout.SortInputtedItems("AA"), Is.EqualTo(sortedItems));
        }

        [Test]
        public void CheckingMultipleItemsMultipleValueInputGetsSorted()
        {
            var sortedItems = new Dictionary<string, int>() { { "A", 2 }, { "B", 1 }, { "C", 5 }, { "D", 2 } };
            Assert.That(Checkout.SortInputtedItems("AABCCCCCDD"), Is.EqualTo(sortedItems));
        }

        [Test]
        public void DisplayConnectsToSortInputtedItems()
        {
            var sortedItems = new Dictionary<string, int>() { { "A", 2 }, { "B", 1 }, { "C", 5 }, { "D", 2 } };
            Assert.That(Checkout.Display("AABCCCCCDD"), Is.EqualTo(sortedItems));
        }




    }
}
