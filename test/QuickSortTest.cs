using System;
using sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class QuickSortTest
    {
        private QuickSort quick;
        private int[] testArray;

        public void setUpScenary1()
        {

        }

        public void setUpScenary2()
        {
            quick = new QuickSort();
            testArray = new int[] { 1, 4, 2, 0, 15, 8, 20, 7 };
        }

        [TestMethod]
        public void TestMergeSortConstructor()
        {
            setUpScenary1();
            quick = new QuickSort();
            Assert.IsNotNull(quick);
        }

        [TestMethod]
        public void TestQuickSort()
        {

        }
    }
}
