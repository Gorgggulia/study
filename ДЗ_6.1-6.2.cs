using System;



class Program
{
     static void Div(int a,int b)
    {
      Console.WriteLine("The result is: "+a/b);
    }

    
    public static void Main(string[] args)
    { 
      
      Console.Write("Type the first num: ");
      try
      {
      int a1=int.Parse(Console.ReadLine());
      Console.Write("Type the second num: ");
      int b1=int.Parse(Console.ReadLine());
      Div(a1,b1);
      }
      
      catch(FormatException)
      {
        Console.WriteLine("Wrong format");
        throw;
      }
      
    }
}