using System;

namespace BaseSort
{
    public class MyBaseSort
    {
        #region 冒泡排序
        /// <summary>
        /// 冒泡排序
        /// 时间复杂度：最好O(n),最差O(n^2)
        /// 该排序是稳定的
        /// </summary>
        /// <param name="array"></param>
        public void BubbleSort(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                bool flag = false;  //用于标识这趟冒泡排序是否进行了元素的交换
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = true;
                    }
                }

                if (!flag)
                    break;
            }
        }
        #endregion

        #region 插入排序
        /// <summary>
        /// 插入排序
        /// 时间复杂度：最好情况 O(n),最差情况 O(n^2)
        /// 稳定性：稳定的
        /// </summary>
        /// <param name="array"></param>
        public void InsertionSort(int[] array)
        {
            //默认第一个是最小的
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];//将要插入的数值
                int insertIndex = i - 1;//前一个数的下标

                //如果条件满足，说明没找到适当的位置
                while (insertIndex >= 0 && temp < array[insertIndex])
                {
                    array[insertIndex + 1] = array[insertIndex]; //同时把比插入数要大的数往后移
                    insertIndex--;//指针后移
                }
                //插入数据
                array[insertIndex + 1] = temp;
            }
        }
        #endregion

        #region 希尔排序
        /// <summary>
        /// 希尔排序
        /// 时间复杂度：Θ(N^2)
        /// 稳定性：不稳定
        /// </summary>
        /// <param name="array"></param>
        public void ShellSort(int[] array)
        {
            int length = array.Length;
            for (int h = length / 2; h > 0; h /= 2)
            {
                for (int i = h; i < length; i++)
                {
                    int temp = array[i];
                    if (temp < array[i - h])
                    {
                        for (int j = 0; j < i; j += h)
                        {
                            if (temp < array[j])
                            {
                                temp = array[j];
                                array[j] = array[i];
                                array[i] = temp;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region 选择排序
        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="array"></param>
        public void SelectSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minValue = array[i];
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (minValue > array[j])
                    {
                        minValue = array[j];
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    array[minIndex] = array[i];
                    array[i] = minValue;
                }
            }

        }
        #endregion

        #region 快速排序
        private int SortUnit(int[] array, int low, int high)
        {
            int key = array[low];
            while (low < high)
            {
                while (array[high] > key && high > low)
                    high--;
                while (array[low] <= key && high > low)
                    low++;
                array[high] = array[low];
            }
            array[low] = key;
            return high;
        }

        public void QuickSort(int[] array, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int index = SortUnit(array, low, high);
            QuickSort(array, low, index - 1);
            QuickSort(array, index + 1, high);
        }
        #endregion

        #region 堆排序
        public void HeapSort(int[] array)
        {
            BuildMaxHeap(array);

            for(int i = array.Length; i > 0; i++)
            {
                Swap(ref array[0], ref array[i]);
                MaxHeaping(array, 0, 1);
            }
        }
        private void BuildMaxHeap(int[] array)
        {
            for(int i = (array.Length / 2) - 1; i >= 0; i--)
            {
                MaxHeaping(array,i,array.Length);
            }
        }

        private void MaxHeaping(int[] array,int i,int heapSize)
        {
            int left = (2 * i) + 1;
            int right = 2 * (i + 1);
            int large = i;

            if (left < heapSize && array[left] > array[large])
            {
                large = left;
            }
            if (right < heapSize && array[right] > array[large])
            {
                large = right;
            }

            if (i != large)
            {
                Swap(ref array[i], ref array[large]);
                MaxHeaping(array,large,heapSize);
            }
        }
        private void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        #endregion
    }
}
