using System;
using System.Collections.Generic;

namespace PersonDataManagementUsingLambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management Problem using Lambda Expression");
            List<Person> list = new List<Person>();
            AddDetailsToList(list);

        }
        public static void AddDetailsToList(List<Person> list)
        {
            list.Add(new Person("123456789", "Michael", "abcdef", 35));
            list.Add(new Person("987654321", "Johny", "fcabdgr", 70));
            Console.ReadLine();
        }
    }
}
