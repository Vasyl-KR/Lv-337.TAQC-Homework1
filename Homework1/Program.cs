using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] nums = new int[4];
            int[] nums2 = new int[4] { 1, 2, 3, 5 };
            int[] nums5 = { 1, 2, 3, 5 };

            int[] nums = new int[4];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 5;
            Console.WriteLine(nums[3]);  // 5
            nums[4] = 9; //IndexOutOfRangeException

            int[] nums1 = new int[] { 0, 1, 2, 3, 4, 5 };

            int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };

            int[,] nums1;
            int[,] nums2 = new int[2, 3];
            int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };

            int[,] mas = { { 1, 2, 3 },
                           { 4, 5, 6 },
                           { 7, 8, 9 },
                           { 10, 11, 12 } };
            foreach (int i in mas)
                Console.Write($"{i} ");


            ArrayList list = new ArrayList();
            list.Add(2.3); // заносимо в список об'єкт типу double
            list.Add(55); // заносимо в список об'єкт типу int
            list.AddRange(new string[] { "Hello", "world" }); // заносимо в список масив рядків

            // перебір значень
            foreach (object o in list)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
            // видаляєм перший елемент
            list.RemoveAt(0);
            // перевертаєм список
            list.Reverse();
            // отримання елементу за індексом
            Console.WriteLine(list[0]);
            Console.WriteLine();
            // властивість Count
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            
            Console.ReadKey();
        }
    }
}
