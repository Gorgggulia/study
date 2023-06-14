using Microsoft.Win32;
using System;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class Program
{
    
    static void NationalFlight()
    {
        Console.Clear();
        
        NationalFlight Nflight = new NationalFlight(1, 1111, "14:00", "16:00", "Kyiv", "Lviv", "-");
        Nflight.PrintMethod();
        NationalFlight Nflight1 = new NationalFlight(2, 1112, "14:30", "16:45", "Kyiv", "Odessa", "-");
        Nflight1.PrintMethod();
        NationalFlight Nflight2 = new NationalFlight(3, 1113, "15:00", "17:00", "Kyiv", "Dnipro", "-");
        Nflight2.PrintMethod();
        NationalFlight Nflight3 = new NationalFlight(4, 1114, "15:30", "17:00", "Kyiv", "Kharkiv", "-");
        Nflight3.PrintMethod();
        NationalFlight Nflight4 = new NationalFlight(5, 1115, "17:00", "17:30", "Kyiv", "Zaporizhzhia", "-");
        Nflight4.PrintMethod();
    }
    static void InternationalFlight()
    {
        Console.Clear();
        
        InternationalFlight flight = new InternationalFlight(1, 111, "9:00", "23:00", "Kyiv", "New-York", "Berlin");
        flight.PrintMethod();
        InternationalFlight flight1 = new InternationalFlight(2, 112, "9:30", "14:00", "Kyiv", "Berlin", "Warshaw");
        flight1.PrintMethod();
        InternationalFlight flight2 = new InternationalFlight(3, 113, "10:00", "19:00", "Kyiv", "Tokyo", "Abu Dhaby");
        flight2.PrintMethod();
        InternationalFlight flight3 = new InternationalFlight(4, 114, "10:30", "15:00", "Kyiv", "London", "Berlin");
        flight3.PrintMethod();
        InternationalFlight flight4 = new InternationalFlight(5, 115, "11:00", "23:00", "Kyiv", "Toronto", "Berlin");
        flight4.PrintMethod();
        InternationalFlight flight5 = new InternationalFlight(6, 116, "11:30", "21:00", "Kyiv", "Shanghai", "Abu Dhaby");
        flight5.PrintMethod();
        InternationalFlight flight6 = new InternationalFlight(7, 117, "12:00", "16:00", "Kyiv", "Munich", "-");
        flight6.PrintMethod();
        InternationalFlight flight7 = new InternationalFlight(8, 118, "12:30", "16:00", "Kyiv", "Paris", "-");
        flight7.PrintMethod();
        InternationalFlight flight8 = new InternationalFlight(9, 119, "13:00", "15:00", "Kyiv", "Warshaw", "-");
        flight8.PrintMethod();
        InternationalFlight flight9 = new InternationalFlight(10, 120, "13:30", "23:00", "Kyiv", "Antalya", "-");
        flight9.PrintMethod();
        InternationalFlight flight10 = new InternationalFlight(11, 121, "15:30", "20:30", "Kyiv", "Abu Dhaby", "Antalya");
        flight10.PrintMethod();
        InternationalFlight flight11 = new InternationalFlight(12, 122, "17:00", "21:00", "Kyiv", "Istanbul", "-");
        flight11.PrintMethod();
        InternationalFlight flight12 = new InternationalFlight(13, 123, "19:00", "23:00", "Kyiv", "Sharm El-Sheikh", "-");
        flight12.PrintMethod();
        InternationalFlight flight13 = new InternationalFlight(14, 124, "22:00", "12:00", "Kyiv", "Phuket", "Abu Dhaby");
        flight13.PrintMethod();
        InternationalFlight flight14 = new InternationalFlight(15, 125, "23:50", "03:00", "Kyiv", "Vienna", "-");
        flight14.PrintMethod();
        
    }
    static void Start()
    {
        
        Console.WriteLine("Press 1 to choose international fly, press 2 to choose national fly");
    }
    static void Seats()
    {
        Console.Clear();
        
        bool seatsWork = true;
        while (seatsWork)
        {
            Console.WriteLine("How many seats you want to buy? Available seats: 100");
            int d = 200;
            try
            {
                d = int.Parse(Console.ReadLine());
                if (d>100 || d<1)
                {
                    Console.WriteLine("Falce, try one more time");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Falce, try one more time");
            }
            finally
            {
                if (d >= 0 && d < 101)
                {
                    Console.WriteLine($"You have bought {d} seats, thanks for your purchase");
                    seatsWork = false;
                }
            }
        }
    }
    static void CheckInternational()
    {
        InternationalFlight one = new InternationalFlight();
        one.Check();
    }
    static void CheckNational()
    {
        NationalFlight one = new NationalFlight();
        one.Check();
    }
    static void GetMethod()
    {
        bool ProgramWork = true;
        while (ProgramWork)
        {          
            int a = 5;
            try
            {
                a = int.Parse(Console.ReadLine());
                if (a != 1 || a != 2)
                {
                    Console.WriteLine("Falce, try one more time");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Falce, try one more time");
            }
            finally
            {
                if (a == 1)
                {
                    ProgramWork = false;
                    InternationalFlight();

                    bool internationalFlight = true;
                    while (internationalFlight)
                    {
                        int b = 16;
                        Console.Write("Choose a race number: ");
                        try
                        {
                            b = int.Parse(Console.ReadLine());
                            if (b < 111 || b > 125)
                            {
                                Console.WriteLine("Falce, try one more time");
                                Console.WriteLine("");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Falce, try one more time");
                            Console.WriteLine("");
                        }
                        finally
                        {
                            if (b > 110 && b < 126)
                            {
                                internationalFlight = false;
                            }
                        }
                    }
                    Console.Clear();
                    CheckInternational();
                }
                else if (a == 2)
                {
                    NationalFlight();
                    ProgramWork = false;
                    bool nationalFlight = true;
                    while (nationalFlight)
                    {
                        int c = 16;
                        Console.Write("Choose a race number: ");
                        try
                        {
                            c = int.Parse(Console.ReadLine());
                            if (c < 1111 || c > 1115)
                            {
                                Console.WriteLine("Falce, try one more time");
                                Console.WriteLine("");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Falce, try one more time");
                            Console.WriteLine("");
                        }
                        finally
                        {
                            if (c > 1110 && c < 1116)
                            {
                                nationalFlight = false;
                            }
                        }
                        Console.Clear();
                        CheckNational();
                    }
                }

            }
        }
    }
    static void Main()
    {
        Start();
        GetMethod();
        Seats();
    }
}

