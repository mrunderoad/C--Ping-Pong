using System;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a Number:");
    string ArrayLength = Console.ReadLine();
    int arrLength = int.Parse(ArrayLength);
    Console.WriteLine("---------------------");
    for (int i = 1; i <= arrLength; i++)
    {
      if ((i % 5 == 0) && (i % 3 == 0))
      {
        Console.WriteLine("PingPong");
      }
      else if(i % 5 == 0)
      {
        Console.WriteLine("Pong");
      }
      else if(i % 3 == 0)
      {
        Console.WriteLine("Ping");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
    Console.WriteLine("---------------------");

    Console.WriteLine("What has to be broken before you can use it?");
    Console.WriteLine(Console.ReadLine().Contains("egg") ? "correct": "wrong");
  }

}



