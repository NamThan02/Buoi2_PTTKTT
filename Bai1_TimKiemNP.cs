//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Buoi2_PTTKTT
//{
//    class Bai1_TimKiemNP
//    {
//        static void Main(string[] args)
//        {
//            Console.InputEncoding = UnicodeEncoding.Unicode;
//            Console.OutputEncoding = UnicodeEncoding.Unicode;
//            BinarySearchArray();
//        }
//        static void BinarySearchArray()
//        {
//            Console.WriteLine("Nhập số lượng phần tử trong mảng:");
//            int n = int.Parse(Console.ReadLine());
//            int[] array = new int[n];

//            Console.WriteLine("Nhập các phần tử của mảng:");
//            for (int i = 0; i < n; i++)
//            {
//                array[i] = int.Parse(Console.ReadLine());
//            }

//            Array.Sort(array);

//            Console.WriteLine("Nhập số cần tìm:");
//            int key = int.Parse(Console.ReadLine());

//            int result = BinarySearch(array, key);

//            if (result == -1)
//            {
//                Console.WriteLine("Không tìm thấy phần tử trong mảng.");
//            }
//            else
//            {
//                Console.WriteLine("Phần tử được tìm thấy tại vị trí: " + result);
//            }
//            Console.ReadKey();

//        }

//        static int BinarySearch(int[] array, int key)
//        {
//            int left = 0, right = array.Length - 1;
//            while (left <= right)
//            {
//                int mid = left + (right - left) / 2;

//                if (array[mid] == key)
//                {
//                    return mid;
//                }

//                if (array[mid] < key)
//                {
//                    left = mid + 1;
//                }
//                else
//                {
//                    right = mid - 1;
//                }
//            }

//            return -1;
//        }
//    }
//}
