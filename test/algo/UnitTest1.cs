using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Algo.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


        }
        [TestMethod]
        public void TestPalindrome()
        {

            Assert.AreEqual(true, Palindrome.IsPalindrom(121));

            Assert.AreEqual(false, Palindrome.IsPalindrom(1121));

            Assert.AreEqual(false, Palindrome.IsPalindrom(-1));
            
            var ls = new List<string>();
            Assert.AreEqual(false, ls.SequenceEqual(new List<string>()));
            


        }
    }
}
