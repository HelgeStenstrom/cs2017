using System;

namespace Assignment2
{
  class WholeNumbersForAdd
  {
    public void Start()
    {
      Banner();
      int count = GetValueCount();
      Console.WriteLine("count = " + count);
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

  }
}