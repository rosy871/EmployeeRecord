using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecord
{
    class Person
    {
        private string firstname;

        public string Firstname
        {
            get { return firstname; }
            set
            {
                firstname = value;
                if (firstname.Length < 3)
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
        }

        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set
            {
                lastname = value;
                if (lastname.Length < 3)
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                if (age <= 0)
                    throw new ArgumentException("Age cannot be 0 or negative integer!");
            }
        }

        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                if (salary < 460)
                    throw new ArgumentException("salary cannot be less than 460 dollar!");
            }
        }



        private int choice;



        public Person(string fname, string lname, int age, decimal salary)
        {
            Firstname = fname;
            Lastname = lname;
            Age = age;
            Salary = salary;

            choice = 2;

        }

        public Person(string fname, string lname, int age)
        {
            Firstname = fname;
            Lastname = lname;
            Age = age;

            choice = 1;

        }



        public void IncreaseSalary(decimal percentage)
        {
            if (Age > 30)
                Salary += Salary * percentage / 100;

            else
                Salary += Salary * percentage / 200;
        }



        public override string ToString()
        {

            if (choice == 1)
                return $"{Firstname} {Lastname} is {Age} years old.";
            else
                return $"{Firstname} {Lastname} receives {Salary.ToString("#.##")} dollars.";

        }


    }
}
