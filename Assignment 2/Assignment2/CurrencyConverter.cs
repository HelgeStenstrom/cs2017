// Helge Stenström
// 2017-09-08
// Programmering med C#


using System;

namespace Assignment2
{
  class CurrencyConverter : Startable
  {
    public void Start()
    {
      Banner();

      decimal sum = GetAndSumNumbers();
      Console.WriteLine();
      string currency = PromptForCurrency();
      decimal rate = PromptForRate();

      PresentResult(sum, rate, currency);

    }

    private void Banner()
    {
      Console.WriteLine();
      Console.WriteLine("Write 0 to finish input!");
      Console.WriteLine("Make sure to use decimal character like in " + 3.1415);
      Console.WriteLine();
    }

    private decimal PromptForNumber()
    {
      Console.Write("Write an amount or zero to finish: ");
      return decimal.Parse(Console.ReadLine());
    }

    private string PromptForCurrency()
    {
      Console.Write("Name of foreign currency: ");
      return Console.ReadLine();
    }

    private decimal PromptForRate()
    // Probably double would be a better choice, but the instructions say decimal.
    {
      Console.Write("Exchange rate: ");
      return decimal.Parse(Console.ReadLine());
    }

    private decimal GetAndSumNumbers()
    {
      decimal f;
      decimal sum = 0;
      do
      {
        f = PromptForNumber();
        sum += f;
        if (f == 0)
          break;
      }
      while (f != 0);
      return sum;
    }

    private decimal convert(decimal val, decimal rate)
    {
      return val/rate;
    }

    private void PresentResult(decimal val, decimal rate, string cur)
    {
      Console.WriteLine();
      Console.WriteLine("----------------");
      Console.WriteLine("This sum is " + val + " kr");
      Console.WriteLine();
      string s = String.Format("{0:0.00} kr is converted to {1:0.00} {2} at the rate of {3} kr/{2}", 
                                val, convert(val,rate), cur, rate);

      Console.WriteLine(s);
      Console.WriteLine();
    }


  }
}