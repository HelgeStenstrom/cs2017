// Helge Stenström
// 2017-09-08
// Programmering med C#


using System;

namespace Assignment2
{
  class WholeNumbersForAdd : Startable
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

    private int GetValueCount2()
    {
      Console.Write("Number of values to sum? ");
      int count = int.Parse(Console.ReadLine());
      Console.WriteLine();
      return count;
    }

    private int GetValueCount()
    {
      return Input.ReadIntegerConsole("Number of values to sum? ");
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

    private int PromptForNumber2(int order)
    {
      Console.Write("Please give the value no ");
      Console.Write(order);
      Console.Write(" (whole number): ");
      int answer = int.Parse(Console.ReadLine());      
      return answer;
    }

    private int PromptForNumber(int order)
    { 
      string prompt = String.Format("Please give the value no {0} "
                                  + "(whole number) ", order);
      int answer = Input.ReadIntegerConsole(prompt);
      return answer;
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