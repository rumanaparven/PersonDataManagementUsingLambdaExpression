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
            RetrieveRecordsForAgeBetn13To18(list);

        }
        public static void AddDetailsToList(List<Person> list)
        {
            list.Add(new Person("123456789", "Michael", "abcdef", 35));
            list.Add(new Person("987654321", "Johny", "fcabdgr", 15));
            list.Add(new Person("987654321", "Tom", "fcabdgr", 17));
            list.Add(new Person("987654321", "Samuel", "fcabdgr", 45));
        }
        public static void RetrieveTopTwoRecordsForAgeLessThanSixty(List<Person> list)
        {
            Console.WriteLine("Top two persons in the list with age less than 60 : ");
            foreach (Person p in list.FindAll(e => (e.age) < 60).Take(2).ToList())
            {
                Console.WriteLine("Namme : " + p.name + " Age : " + p.age);
            }
            Console.WriteLine(" \n");
        }
        public static void RetrieveRecordsForAgeBetn13To18(List<Person> list)
        {
            Console.WriteLine("Person with age between 13 and 18 : ");
            foreach (Person p in list.FindAll(e => (e.age) >=13 && (e.age)<=18).ToList())
            {
                Console.WriteLine("Namme : " + p.name + " Age : " + p.age);
            }
        }
    }

}
