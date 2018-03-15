using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MergeSort;

namespace MergeSortTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] expected = new int[] { 1, 3, 4, 5, 6 };
            int[] array = new int[] { 5, 3, 1, 6, 4 };
            Class1 a = new Class1();
            int[] actual = Class1.sort(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
