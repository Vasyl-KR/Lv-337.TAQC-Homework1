using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Customer
    {
        private int id;
        private string name;
        private string city;

        public Customer(int id, string name, string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
        public int ID
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }  
        }
        public string City
        {
            get { return city; }
        }

        public override string ToString()
        {
            return string.Format($"{id} {name} {city}");
        }

    }
    public class Distributor
    {
        private int id;
        private string name;
        private string city;

        public Distributor(int id, string name, string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
        public string Name
        {
            get { return name; }
        }
        public string City
        {
            get { return city; }
        }

        public override string ToString()
        {
            return string.Format($"{id} {name} {city}");
        }
    }

    class Program
    {
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            //string[] teams = { "Баварiя", "Реал Мадрид", "Болонья", "Манчестер Сiтi", "ПСЖ", "Барселона" };

            //var selectedTeams = new List<string>();
            //foreach (string s in teams)
            //{
            //    if (s.ToUpper().StartsWith("Б"))
            //        selectedTeams.Add(s);
            //}

            //foreach (string s in selectedTeams)
            //    Console.WriteLine(s);

            //string[] teams = { "Баварiя", "Реал Мадрид", "Болонья", "Манчестер Сiтi", "ПСЖ", "Барселона" };

            //var selectedTeams = from t in teams // визначаємо кожен об'єкт з teams як t
            //                    where t.ToUpper().StartsWith("Б") //фільтрація за критерієм
            //                    select t; // вибираємо об'єкт

            //foreach (string s in selectedTeams)
            //    Console.WriteLine(s);

            //var selectedTeams2 = teams
            //                    .Where(t => t.ToUpper()
            //                    .StartsWith("Б"))
            //                    .Select(t=>"ФК - " + t);

            //foreach (string s in selectedTeams2)
            //    Console.WriteLine(s);

            //Operation operation = (x, y) => x + y;
            //Console.WriteLine(operation(10, 20));       // 30
            //Console.WriteLine(operation(40, 20));       // 60
            //Console.Read();

            ////  1. Source must implement IEnumerable<T>
            //int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //// 2. query extended System.Linq.Enumerable methods
            //IEnumerable<int> numQuery =
            //                 from num in numbers
            //                 where (num % 2) == 0
            //                 select num;

            //// 3. query execution
            //foreach (int num in numQuery)
            //{
            //    Console.Write("{0} ", num);
            //}

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(1, "Vasya", "Lviv"));
            customers.Add(new Customer(2, "Ivan", "Kyiv"));
            customers.Add(new Customer(3, "Roman", "Lviv"));
            customers.Add(new Customer(4, "Volodmyr", "Lutsk"));
            customers.Add(new Customer(5, "Olena", "Paris"));
            customers.Add(new Customer(6, "Oleg", "Lviv"));
            List<Distributor> distributors = new List<Distributor>();
            distributors.Add(new Distributor(1, "Nestle", "Lviv"));
            distributors.Add(new Distributor(1, "Roshen", "Kyiv"));

            //var queryAllCustomers = from cust in customers
            //                        select cust;
            //foreach (var s in queryAllCustomers)
            //    Console.WriteLine(s);

            //var queryLvivCustomers = customers
            //                         .Where(cust => cust.City == "Lviv")
            //                         .Select(cust=>cust);

            //foreach (var s in queryLvivCustomers)
            //    Console.WriteLine(s);

            //var queryLvivCustomers3 = from cust in customers
            //                            where cust.City == "Lviv"
            //                            orderby cust.Name ascending
            //                            select cust;

            //foreach (var s in queryLvivCustomers3)
            //    Console.WriteLine(s);


            //var queryCustomersByCity = from cust in customers
            //                           group cust by cust.City;

            //foreach (var customerGroup in queryCustomersByCity)
            //{
            //    Console.WriteLine(customerGroup.Key);
            //    foreach (Customer customer in customerGroup)
            //    {
            //        Console.WriteLine("    {0}", customer.Name);
            //    }
            //}

            //var innerJoinQuery = from cust in customers
            //                     join dist in distributors on cust.City equals dist.City
            //                     select new { CustomerName = cust.Name, DistributorName = dist.Name };
            //foreach (var s in innerJoinQuery)
            //    Console.WriteLine(s.CustomerName + " " + s.DistributorName);



            Console.ReadKey();
        }
    }
}
