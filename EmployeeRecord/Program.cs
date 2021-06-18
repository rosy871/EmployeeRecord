using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeRecord
{
    class Program
    {

        static void Main(string[] args)
        {

            menuOperation();
        }

        private static void menuOperation()
        {
            do
            {
                menuChoice();
                switch (Console.ReadLine())
                {

                    case "1":
                        Console.WriteLine("Enter first name last name and age for 5 persons");
                        solution1();
                        break;

                    case "2":
                        StartUp s = new();
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Wrong input , Type again...");
                        break;

                }
            } while (true);

        }

        private static void menuChoice()
        {
            Console.WriteLine("\nPress 1 for solution 1");
            Console.WriteLine("Press 2 for solution 2");
            Console.WriteLine("press 3 Exit");
        }


        private static void solution1()
        {
            var lines = 5;
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                try
                {

                    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                    persons.Add(person);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }


            persons.OrderBy(p => p.Firstname)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p.ToString()));
        }


    }
}
