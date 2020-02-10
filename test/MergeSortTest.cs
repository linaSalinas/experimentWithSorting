using System;
using sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class MergeSortTest
    {
        private MergeSort merge;
        private int[] testArray;

        public void setUpScenary1() {

        }

        public void setUpScenary2() {
            merge = new MergeSort();
            testArray = new int[] { 1, 4, 2, 0, 15, 8, 20, 7 };
        }

        [TestMethod]
        public void TestMergeSortConstructor()
        {
            setUpScenary1();
            merge = new MergeSort();
            Assert.IsNotNull(merge);
        }

        [TestMethod]
        public void TestMergeSort() 
        {
            setUpScenary2();
            merge.mergeSort(testArray, 0, testArray.Length-1);
            for(int i = 0; i < testArray.Length; i++) 
            {
                Assert.IsTrue(testArray[i] < testArray[i + 1]);
            }
        }
    }
}