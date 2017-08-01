using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BaseSort.Test
{
    public class BaseSortTest
    {
        private readonly MyBaseSort _sort;
        public BaseSortTest()
        {
            _sort = new MyBaseSort();
        }
        [Fact]
        public void BubbleSortTest()
        {
            int[] test = { 1, 2, 3, 4, 5, 6 };
            int[] result = { 3, 2, 6, 4, 5, 1 };
            _sort.BubbleSort(result);
            Assert.Equal(test,result);
        }

        [Fact]
        public void InsertionSortTest()
        {
            int[] test = { 1, 2, 3, 4, 5, 6 };
            int[] result = { 3, 2, 6, 4, 5, 1 };
            _sort.InsertionSort(result);
            Assert.Equal(test, result);
        }
    }
}
