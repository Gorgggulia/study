using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using System.Threading;

namespace Навчання
{
    internal class Program
    {
        public const double PI = 3.1415926535897931;
        static void Main(string[] args)
        {
            ///Homework 1.1
            Console.Write("Type a lenth of the side: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter is: "+ a*4);
            Console.WriteLine("The area is: " + (a*a));
            ///Homework 1.2
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name}");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine($"Your name is {name} and you are {age} years old");
            ///Homework 1.3          
            Console.Write("Type the radius of the circle:");
            double r=double.Parse(Console.ReadLine());
            Console.WriteLine("The lenth(l) is: "+PI*2*r+" the area is: "+PI*r*r+" and the volum is: "+4/3*PI*r*r*r);

        }

    }
}
