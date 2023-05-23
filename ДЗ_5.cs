using System;
using System.Collections.Generic;

interface IDeveloper
{
    string Tool { get; set; }
    void Create();
    void Destroy();
}

class Programmer : IDeveloper
{
    public string Tool { get; set; }
    public string Language { get; set; }

    public void Create()
    {
        Console.WriteLine($"Programmer using {Tool} is creating something in {Language} language.");
    }

    public void Destroy()
    {
        Console.WriteLine($"Programmer using {Tool} is destroying something in {Language} language.");
    }
}

class Builder : IDeveloper
{
    public string Tool { get; set; }
    public string Field { get; set; }

    public void Create()
    {
        Console.WriteLine($"Builder using {Tool} is creating something in {Field} field.");
    }

    public void Destroy()
    {
        Console.WriteLine($"Builder using {Tool} is destroying something in {Field} field.");
    }
}

class DeveloperComparer : IComparer<IDeveloper>
{
    public int Compare(IDeveloper x, IDeveloper y)
    {
        if (x is Programmer && y is Programmer)
        {
            var programmerX = (Programmer)x;
            var programmerY = (Programmer)y;
            return string.Compare(programmerX.Language, programmerY.Language, StringComparison.OrdinalIgnoreCase);
        }
        else if (x is Builder && y is Builder)
        {
            var builderX = (Builder)x;
            var builderY = (Builder)y;
            return string.Compare(builderX.Field, builderY.Field, StringComparison.OrdinalIgnoreCase);
        }

        return 0;
    }
}

class Program
{
    static void Main()
    {
        var developers = new List<IDeveloper>();

        var programmer1 = new Programmer { Tool = "IDE", Language = "C#" };
        var programmer2 = new Programmer { Tool = "Text Editor", Language = "Java" };
        var builder1 = new Builder { Tool = "Hammer", Field = "Construction" };
        var builder2 = new Builder { Tool = "Screwdriver", Field = "Carpentry" };

        developers.Add(programmer1);
        developers.Add(programmer2);
        developers.Add(builder1);
        developers.Add(builder2);

        foreach (var developer in developers)
        {
            developer.Create();
            developer.Destroy();
            Console.WriteLine();
        }

        developers.Sort(new DeveloperComparer());

        Console.WriteLine("Sorted Developers:");
        foreach (var developer in developers)
        {
            if (developer is Programmer programmer)
            {
                Console.WriteLine($"Programmer using {programmer.Tool} with language: {programmer.Language}");
            }
            else if (developer is Builder builder)
            {
                Console.WriteLine($"Builder using {builder.Tool} in field: {builder.Field}");
            }
        }

        Console.WriteLine();

        var dictionary = new Dictionary<uint, string>();

        for (int i = 0; i < 7; i++)
        {
            Console.Write("Enter ID: ");
            uint id = uint.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            dictionary.Add(id, name);
        }

        Console.Write("Enter ID to find corresponding Name: ");
        uint searchId = uint.Parse(Console.ReadLine());

        if (dictionary.TryGetValue(searchId, out string searchName))
        {
            Console.WriteLine($"Name: {searchName}");
        }
        else
        {
            Console.WriteLine("No corresponding name found for the entered ID.");
        }

        Console.ReadLine();
    }
}