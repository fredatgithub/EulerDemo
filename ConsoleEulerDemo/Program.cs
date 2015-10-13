using System;
using System.Collections.Generic;

namespace ConsoleEulerDemo
{
  class Program
  {
    static void Main()
    {
      foreach (var partialSum in GetEulerPartialSum(1000000))
      {
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(partialSum);
      }
      Console.ReadLine();
    }

    private static IEnumerable<double> GetEulerPartialSum(int n)
    {
      double sum = 0.0;
      for (int i = 1; i <= n; i++)
      {
        sum += 1.0 / Math.Pow(i, 2);
        yield return sum;
      }
    }
  }
}