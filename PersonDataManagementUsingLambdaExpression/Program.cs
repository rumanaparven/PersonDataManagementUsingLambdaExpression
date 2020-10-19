using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagementUsingLambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management Problem using Lambda Expression");
            List<Person> list = new List<Person>();
            AddDetailsToList(list);
            RetrieveTopTwoRecordsForAgeLessThanSixty(list);

        }
        public static void AddDetailsToList(List<Person> list)
        {
            list.Add(new Person("123456789", "Michael", "abcdef", 35));
            list.Add(new Person("987654321", "Johny", "fcabdgr", 70));
            list.Add(new Person("987654321", "Tom", "fcabdgr", 59));
            list.Add(new Person("987654321", "Samuel", "fcabdgr", 45));
        }
        public static void RetrieveTopTwoRecordsForAgeLessThanSixty(List<Person> list)
        {
            foreach(Person p in list.FindAll(e => (e.age) < 60).Take(2).ToList())
            {
                Console.WriteLine("Namme : " + p.name + " Age : " + p.age);
            }
        }
    }
}
