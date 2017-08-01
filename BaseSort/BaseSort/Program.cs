using System;
using System.Linq;

namespace BaseSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 1, 5, 6, 4 };
            BubbleSort(arr);
            arr.ToList().ForEach(Console.WriteLine);
            Console.Read();
        }

        #region 冒泡排序
        /// <summary>
        /// 冒泡排序
        /// 时间复杂度：最好O(n),最差O(n^2)
        /// 该排序是稳定的
        /// </summary>
        /// <param name="array"></param>
        public static void BubbleSort(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int flag = 0;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag++;
                    }
                }

                if (flag == 0)
                    break;
            }
        }
        #endregion

        #region 插入排序
        public static void InsertionSort(int[] array)
        {

        }
        #endregion
    }
}