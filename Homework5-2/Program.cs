using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Declare myColl of 10 integers and fill it from Console.
	1) Find and print all positions of element -10 in the collection
	2) Remove from collection elements, which are greater then 20. Print collection
	3) Insert elements 1,-3,-4 in positions 2, 8, 5. Print collection
	4) Sort and print collection 
 Use next Collections for this tasks: List and ArrayList
*/

namespace Homework5
{
    class Program
    {

        static void Main(string[] args)
        {
            //ArrayList
            ArrayList myColl = new ArrayList();
            int count = 0;
            Console.WriteLine("Enter 10 integer numbers");
            for (int i = 0; i < myColl.Capacity; i++)
            {
                myColl.Add(Int32.Parse(Console.ReadLine()));
            }

            foreach (var item in myColl)
            {
                count++;
                if ((int)item == -10)
                {
                    Console.WriteLine("-10 in position {0}", count);
                }
            }
            int capacity = myColl.Capacity;
            Console.WriteLine("Remove");
            for (int i = 0; i < capacity; i++)
            {
                if ((int)myColl[i] > 10)
                {
                    myColl.RemoveAt(i);
                    i--;
                    capacity--;
                }
                else
                {
                    Console.WriteLine(myColl[i]);
                }
            }

            Console.WriteLine("Insert");
            myColl.Insert(1, 1);
            myColl.Insert(7, -3);
            myColl.Insert(4, -4);
            foreach (int item in myColl)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sort");
            myColl.Sort();
            foreach (int item in myColl)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
