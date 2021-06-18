using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecord
{
    class StartUp
    {
        public StartUp()
        {
            Console.WriteLine("\nsolution 2");
            Console.WriteLine("Enter number of entry: ");
            var lines = int.Parse(Console.ReadLine());
            solution2(lines);
           
        }

        private void solution2(int lines)
        {
           
            Console.WriteLine($"Enter firstname lastname age and salary for {lines} persons.");

            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {

                do
                {
                    var cmdArgs = Console.ReadLine().Split();
                    try
                    {
                        var person = new Person(cmdArgs[0], cmdArgs[1],
                            int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                        persons.Add(person);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                    break;
                } while (true);
            }

            Console.WriteLine("Enter bonus percentage");
            var bonus = decimal.Parse(Console.ReadLine());

            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
