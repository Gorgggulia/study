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
    internal class Program
    {
        struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public override string ToString()
            {
                return $"Name: {name}\nMark: {mark}\nAge: {age}";
            }
        }
        enum HTTPError
        {
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403,
            NotFound = 404,
            InternalServerError = 500,
            NotImplemented = 501,
            BadGateway = 502,
            ServiceUnavailable = 503,
            GatewayTimeout = 504
        }

        static void Main(string[] args)
        {

            ///Homework 2.1
            Console.WriteLine("Type 3 numbers");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            if (a <= 5 && a >= -5 && b <= 5 && b >= -5 && c <= 5 && c >= -5)
            {
                Console.WriteLine("In range");
            }
            else 
            {
                Console.WriteLine("Not in range");
            }
            ///Homework 2.2
            List<int> list = new List<int>();
            int a1=int.Parse(Console.ReadLine());
            int b1=int.Parse(Console.ReadLine());
            int c1=int.Parse(Console.ReadLine());
            list.Add(a1);
            list.Add(b1);
            list.Add(c1);
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            ///Homework 2.3
            {
                Console.Write("Enter HTTP error code: ");
                int errorCode = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(HTTPError), errorCode))
                {
                    HTTPError httpError = (HTTPError)errorCode;
                    Console.WriteLine($"The error is {httpError}");
                }
                else
                {
                    Console.WriteLine("Invalid HTTP error code.");
                }
            }
            ///Homework 2.4
            Dog myDog = new Dog();

            Console.Write("Enter dog's name: ");
            myDog.name = Console.ReadLine();

            Console.Write("Enter dog's mark: ");
            myDog.mark = Console.ReadLine();

            Console.Write("Enter dog's age: ");
            myDog.age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDog's information:");
            Console.WriteLine(myDog);

        }
    }
}
