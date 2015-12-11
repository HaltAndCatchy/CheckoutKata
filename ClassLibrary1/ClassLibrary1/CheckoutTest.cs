using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using checkout;

namespace CheckoutTestLibrary
{
    [TestFixture]
    class Class2 
    {
        [Test]
        public static void CheckoutReturnsSomething()
        {
            var checkout = new Checkout();
            Assert.That(checkout.ShowAmount(),Is.EqualTo("Please Scan Item"));
        }

        [Test]
        public static void CheckoutTestingForEmptyString()
        {
            var checkout = new Checkout();
            Assert.That(checkout.ShowAmount(""), Is.EqualTo(0));
        }

        [Test]
        public static void CheckoutAValue()
        {
            var checkout = new Checkout();
            Assert.That(checkout.ShowAmount("A"), Is.EqualTo(50));
        }

        [Test]
        public static void CheckoutBValue()
        {
            var checkout = new Checkout();
            Assert.That(checkout.ShowAmount("B"), Is.EqualTo(30));
        }

        [Test]
        public static void CheckoutCValue()
        {
            var checkout = new Checkout();
            Assert.That(checkout.ShowAmount("C"), Is.EqualTo(20));
        }

        [Test]
        public static void CheckoutDValue()
        {
            var checkout = new Checkout();
            Assert.That(checkout.ShowAmount("D"), Is.EqualTo(15));
        }

        [Test]
        public static void CheckoutMultipleAs()
        {
            var checkout = new Checkout();
            Assert.That(checkout.ShowAmount("AA"), Is.EqualTo(100));
        }

        [Test]
        public static void CheckoutMultipleBs()
        {
            var checkout = new Checkout();
            Assert.That(checkout.ShowAmount("BB"), Is.EqualTo(60));
        }

        [Test]
        public static void CheckoutMultipleCs()
        {
            var checkout = new Checkout();
            Assert.That(checkout.ShowAmount("CC"), Is.EqualTo(40));
        }

        [Test]
        public static void CheckoutMultipleDs()
        {
            var checkout = new Checkout();
            Assert.That(checkout.ShowAmount("DD"), Is.EqualTo(30));
        }

        [Test]
        public static void CheckoutVarietyAB()
        {
            var checkout = new Checkout();
            Assert.That(checkout.ShowAmount("AB"), Is.EqualTo(80));
        }

        [Test]
        public static void CheckoutVarietyAAB()
        {
            var checkout = new Checkout();
            Assert.That(checkout.ShowAmount("AAB"), Is.EqualTo(130));
        }

        [Test]
        public static void CheckoutADiscount()
        {
            var checkout = new Checkout();
            Assert.That(checkout.ShowAmount("AAA"), Is.EqualTo(130));
        }
    }


}
