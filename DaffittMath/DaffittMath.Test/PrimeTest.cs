using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaffittMath.Test
{
    [TestClass]
    public class PrimeTest
    {
        // Test the result of passing NULL value to the IsPrime method
        // This test should pass (return False) because NULL is NOT a prime number
        [TestMethod]
        public void IsPrime_Null()
        {
            bool b;
            Prime p = new Prime();
            b = p.IsPrime(default(int?));
            Assert.AreEqual<bool>(false, b);
            Assert.IsNotNull((object)p);
        }

        // Test the result of passing 0 to the IsPrime method
        // This test should pass (return False) because 0 is NOT a prime number
        [TestMethod]
        public void IsPrime_0()
        {
            bool b;
            Prime p = new Prime();
            b = p.IsPrime(0);
            Assert.AreEqual<bool>(false, b);
            Assert.IsNotNull((object)p);
        }

        // Test the result of passing 1 to the IsPrime method
        // This test should pass (return False) because 1 is NOT a prime number
        [TestMethod]
        public void IsPrime_1()
        {
            bool b;
            Prime p = new Prime();
            b = p.IsPrime(1);
            Assert.AreEqual<bool>(false, b);
            Assert.IsNotNull((object)p);
        }

        // Test the result of passing 2 to the IsPrime method
        // This test should pass (return True) because 2 IS a prime number
        [TestMethod]
        public void IsPrime_2()
        {
            bool b;
            Prime p = new Prime();
            b = p.IsPrime(2);
            Assert.AreEqual<bool>(true, b);
            Assert.IsNotNull((object)p);
        }

        // Test the result of passing 7 to the IsPrime method
        // This test should pass (return True) because 7 IS a prime number
        [TestMethod]
        public void IsPrime_7()
        {
            bool b;
            Prime p = new Prime();
            b = p.IsPrime(7);
            Assert.AreEqual<bool>(true, b);
            Assert.IsNotNull((object)p);
        }

        // Test the result of passing 9 to the IsPrime method
        // This test should pass (return False) because 9 is NOT a prime number
        [TestMethod]
        public void IsPrime_9()
        {
            bool b;
            Prime p = new Prime();
            b = p.IsPrime(9);
            Assert.AreEqual<bool>(false, b);
            Assert.IsNotNull((object)p);
        }
    }
}
