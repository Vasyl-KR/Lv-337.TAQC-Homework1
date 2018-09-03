using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create interface IDeveloper with property Tool, methods Create() and Destroy()
      Create two classes Programmer (with field language) and Builder (with field tool), 
      which implement this interface.
      Create List of IDeveloper and add some Programmers and Builders to it. Call Create() 
      and Destroy() methods, property Tool for all of it.

  Create Console Application project in VS. In the Main() method declare Dictionary<uint,string>. 
  Add to Dictionary from Console seven pairs (ID, Name) of some persons. Ask user to enter ID, 
  then find and write corresponding Name from your Dictionary. If you can't find this ID - say about it to user. 
*/

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1
            IDeveloper[] developers = new IDeveloper[2];
            developers[0] = new Programmer("C++");
            developers[1] = new Builder("drill");

            foreach (IDeveloper d in developers)
            {
                d.Create();
                d.Destroy();
            }

            foreach (IDeveloper d in developers)
            {
                Console.WriteLine(d.Tool);
            }
            //task2
            Dictionary<uint, string> persons = new Dictionary<uint, string>();
            for (int i = 0; i < 7; i++)
            {
                uint tempID;
                do
                {
                    Console.WriteLine("Enter ID of person");
                    uint.TryParse(Console.ReadLine(), out tempID);
                    if (persons.ContainsKey(tempID))
                        Console.WriteLine("This ID already exists, try another");
                } while (persons.ContainsKey(tempID));
                Console.WriteLine("Enter name of person");
                persons.Add(tempID, Console.ReadLine());
            }
            Console.WriteLine("Enter the person ID you are looking for");
            uint ID;
            uint.TryParse(Console.ReadLine(), out ID);
            if (persons.ContainsKey(ID))
            {
                Console.WriteLine("Corresponding name is {0}", persons[ID]);
            }
            else
            {
                Console.WriteLine("Can't find this ID");
            }

            Console.ReadKey();

        }
    }
}
