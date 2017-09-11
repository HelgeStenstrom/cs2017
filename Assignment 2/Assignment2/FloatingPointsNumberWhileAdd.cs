// Helge Stenström
// 2017-09-08
// Programmering med C#


using System;

namespace Assignment2
{
  class FloatingPointsNumberWhileAdd : Startable
  {
    public void Start()
    {
      Banner();
      double sum = GetAndSumNumbers();
      PresentResult(sum);
    }

    private void Banner()
    {
      Console.WriteLine();
      Console.WriteLine("  ++++++ Summation of real numbers ++++++");
      Console.WriteLine("             Using a While-statement      ");
      Console.WriteLine(" Use same decimal character as in " + 3.1415);
      Console.WriteLine();
    }

    private double PromptForNumber2()
    {
      Console.Write("Write an amount to sum or zero to finish: ");
      return double.Parse(Console.ReadLine());
    }

    private double PromptForNumber()
    {
      Console.Write("Write an amount to sum or zero to finish: ");
      return Input.ReadDoubleConsole();
    }

    private double GetAndSumNumbers()
    {
      double sum = 0;
      while ( true)
      {
        double f = PromptForNumber();
        sum += f;
        if (f == 0)
          break;
      }
      return sum;
    }

    private void PresentResult(double f)
    {
      Console.WriteLine("------------");
      Console.WriteLine("This sum is " + f);
      Console.WriteLine();

    }

  }
  
}