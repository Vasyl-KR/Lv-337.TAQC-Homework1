using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*  In Main() method declare Dictionary PhoneBook for keeping pairs PersonName-PhoneNumber. 
    1) From file "phones.txt" read 9 pairs into PhoneBook. Write only PhoneNumbers into file "Phones.txt".
    2) Find and print phone number by the given name (name input from console)
    3) Change all phone numbers, which are in format 80######### into new format +380#########. 
    The result write into file "New.txt"

    Write a method ReadNumber(int start, int end), that reads from Console (or from file) integer number 
    and return it, if it is in the range [start...end]. 
    If an invalid number or non-number text is read, the method should throw an exception. 
    Using this method write a method Main(), that has to enter 10 numbers:
		a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100
*/


namespace Homework6
{
    class Program
    {

        static void Main()
        {
            //task1
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Vasyl\Source\Repos\Lv-337.TAQC-Homeworks\Homework1\phones.txt"))
                {
                    string line;
                    string[] input;
                    while ((line = sr.ReadLine()) != null)
                    {
                        input = line.Split(' ');
                        phoneBook.Add(input[1], input[0]);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("The file could not be read:");
            }
            Console.WriteLine("Enter name of person");
            string s = Console.ReadLine();
            if (phoneBook.ContainsKey(s))
            {
                Console.WriteLine(phoneBook[s]);
            }
            else
            {
                Console.WriteLine("Number not found");
            }
            using (StreamWriter sw = new StreamWriter("New.txt"))
            {
                foreach (KeyValuePair<string, string> kvp in phoneBook)
                {
                    if (kvp.Value.StartsWith("80"))
                    {
                        sw.WriteLine("{0} {1}", kvp.Key, "+3" + kvp.Value);
                    }
                }
            }

            //task2
            int[] numbers = new int[10];
            int start = 1;
            int end = 100;
            int i = 0;
            Console.WriteLine("Enter 10 numbers in range from 1 to 100");

            while (i < 10)
            {
                int temp = ReadNumber(start, end);
                if (temp != -1)
                {
                    numbers[i] = temp;
                    start = temp;
                    i++;
                }
            }
            Console.WriteLine("\nNumbers");
            int count = 0;
            foreach (int n in numbers)
            {
                count += 1;
                Console.WriteLine("№{0} - {1}", count, n);
            }

            Console.ReadKey();
        }
        static int ReadNumber(int start, int end)
        {
            int n;
            try
            {
                n = Int32.Parse(Console.ReadLine());
                if (n >= start && n <= end)
                {
                    return n;  
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid integer number, enter valid number");
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("Out of range, enter valid number");
            }
            return -1;
        }
    }
}
