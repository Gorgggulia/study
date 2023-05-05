using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using System.Threading;
using System.Security.Cryptography;

namespace Навчання
{
    using System;

    class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name { get { return name; } }
        public DateTime BirthYear { get { return birthYear; } }

        public Person()
        {
            name = "";
            birthYear = DateTime.MinValue;
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthYear.Year;
            if (birthYear > today.AddYears(-age))
                age--;
            return age;
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter birth year (yyyy): ");
            int year = int.Parse(Console.ReadLine());
            birthYear = new DateTime(year, 1, 1);
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return $"{name}, {Age()} years old";
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.name == p2.name;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }
    }

    class Program
    {
        static void Main()
        {
            Person[] people = new Person[6];

            for (int i = 0; i < 6; i++)
            {
                people[i] = new Person();
                people[i].Input();
            }

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age()} years old");
            }

            for (int i = 0; i < 6; i++)
            {
                if (people[i].Age() < 16)
                {
                    people[i].ChangeName("Very Young");
                }
            }

            foreach (Person person in people)
            {
                person.Output();
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 6; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"People {i + 1} and {j + 1} have the same name: {people[i].Name}");
                    }
                }
            }

            Console.ReadLine();
        }
    }

}
