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

        static void Main(string[] args)
        {
            ///Homework 3.1
            int counter = 0;
            string str=Console.ReadLine();
            for (int i=0; i<str.Length; i++)
            {
                if (str[i]=='a' || str[i] == 'o' || str[i] == 'i' || str[i] == 'e')
                {
                    counter++;
                }
                
            }
            Console.WriteLine(counter);
            ///Homework 3.2
            Console.Write("Enter the number of a month to get the count of days: ");
            int mounth=Convert.ToInt32((Console.ReadLine()));
            switch (mounth)
            {
                case 1:
                    Console.WriteLine(31);
                    break;                   
                case 2:
                    Console.WriteLine(31);
                    break;
                case 3:
                    Console.WriteLine(31);
                    break;
                case 4:
                    Console.WriteLine(31);
                    break;
                case 5:
                    Console.WriteLine(31);
                    break;
                case 6:
                    Console.WriteLine(31);
                    break;
                case 7:
                    Console.WriteLine(31);
                    break;
                case 8:
                    Console.WriteLine(31);
                    break;
                case 9:
                    Console.WriteLine(31);
                    break;
                case 10:
                    Console.WriteLine(31);
                    break;
                case 11:
                    Console.WriteLine(31);
                    break;
                case 12:
                    Console.WriteLine(31);
                    break;
                default:
                    Console.WriteLine("Wrong number");
                    break;
            }
            ///Homework 3.3
            List<int> num = new List<int>();
            for (int l = 0; l < 10; l ++)
            {
                int s = Convert.ToInt32((Console.ReadLine()));
                num.Add(s);
            }
            if (num.Min() > 0)
            {

                Console.WriteLine(num[5] * num[6] * num[7] * num[8] * num[9]);

            }
            if (num.Min() < 0)
            {
                Console.WriteLine(num[0] + num[1] + num[2] + num[3] + num[4]);
            }
        }
    }
}
