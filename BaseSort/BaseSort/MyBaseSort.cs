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
        public void InsertionSort(int[] array)
        {

        }
        #endregion
    }
}
