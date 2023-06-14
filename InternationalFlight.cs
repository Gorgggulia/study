using System;
using System.Collections.Generic;
using System.Threading;

class InternationalFlight : Flight
{
    List<string> surnames = new List<string>() { "Surname1", "Surname2", "Surname3" };
    List<int> visaNumber = new List<int>() { 121, 131, 141, 151};
    public InternationalFlight()
    {
    }
    public InternationalFlight(int fn, int rn, string dt, string at, string dp, string ap, string ip)
    {
        flightNumber = fn;
        raceNumber = rn;
        depatureTime = dt;
        arrivalTime = at;
        depaturePlace = dp;
        arrivalPlace = ap;
        intermediatePoint = ip;
    }
    public override void Check()
    {
        Client client = new Client();
        Console.WriteLine("Enter your surname");
        client.SurName = Console.ReadLine();
        Console.WriteLine("Enter your visa number");
        client.VisaNumber = int.Parse(Console.ReadLine());
        for (int i = 0; i < surnames.Count; i++)
        {
            for(int j = 0; j < visaNumber.Count; j++)
            {
                if (surnames[i] == client.SurName && visaNumber[i]==client.VisaNumber)
                {
                    Console.WriteLine("You are eligable");
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    Console.WriteLine("False, you are not eligable");
                    throw new Exception();
                }
            }
            
        }
    }
}

