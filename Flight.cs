using System;

abstract class Flight
{
    public int flightNumber { get; set; }
    public string depatureTime { get; set; }
    public string arrivalTime { get; set; }
    public int raceNumber { get; set; }
    public string intermediatePoint { get; set; }
    public string depaturePlace { get; set; }
    public string arrivalPlace { get; set; }
    public bool ProgramWork1 { get; set; }
public void PrintMethod()
    {
        Console.WriteLine($"{flightNumber}) The race number: {raceNumber}, " +
            $"depature time: {depatureTime}, " +
            $" arrival time: {arrivalTime}, " +
            $"depature place: {depaturePlace}, " +
            $"arrivall place: {arrivalPlace}, " +
            $"intermediate point: {intermediatePoint}");
        Console.WriteLine("");
    }
    public abstract void Check();
}

