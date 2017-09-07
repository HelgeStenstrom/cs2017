using System;

namespace Assignment2
{
  class WholeNumbersForAdd
  {
    public void Start()
    {
      Banner();
      int count = GetValueCount();
      int sum = GetAndSumNumbers(count);
      PresentResult(sum);
    }

    private void Banner()
    {
      Console.WriteLine();
      Console.WriteLine("++++++ Summation of whole numbers ++++++");
      Console.WriteLine("             Using a for-statement      ");
      Console.WriteLine();
    }

    private int GetValueCount()
    {
      Console.Write("Number of values to sum? ");
      int count = int.Parse(Console.ReadLine());
      Console.WriteLine();
      return count;
    }

    private int GetAndSumNumbers(int count)
    {
      int sum = 0;
      for (int i = 1; i <= count; i++)
      {
        sum += PromptForNumber(i);
      }
      return sum;
    }

    private int PromptForNumber(int order)
    {
      Console.Write("Please give the value no ");
      Console.Write(order);
      Console.Write(" (whole number): ");
      return int.Parse(Console.ReadLine());
    }

    private void PresentResult(int sum)
    {
      Console.WriteLine("-----------------------------");
      Console.WriteLine();
      Console.WriteLine("The sum is       " + sum);
      Console.WriteLine();
    }

  } // End of class
}  // End of namespace