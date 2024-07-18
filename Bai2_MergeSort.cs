using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_PTTKTT
{
    class Bai2_MergeSort
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            MergeSortArray();
        }

        static void MergeSortArray()
        {
            Console.WriteLine("Nhập số lượng phần tử trong mảng:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Nhập các phần tử của mảng:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            MergeSort(array, 0, array.Length - 1);

            Console.WriteLine("Mảng sau khi sắp xếp MergeSort:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.ReadKey();

        }

        static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        static void Merge(int[] array, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; ++i)
                L[i] = array[left + i];
            for (int j = 0; j < n2; ++j)
                R[j] = array[middle + 1 + j];

            int k = left;
            int i1 = 0, j1 = 0;
            while (i1 < n1 && j1 < n2)
            {
                if (L[i1] <= R[j1])
                {
                    array[k] = L[i1];
                    i1++;
                }
                else
                {
                    array[k] = R[j1];
                    j1++;
                }
                k++;
            }

            while (i1 < n1)
            {
                array[k] = L[i1];
                i1++;
                k++;
            }

            while (j1 < n2)
            {
                array[k] = R[j1];
                j1++;
                k++;
            }
        }

    }

}
