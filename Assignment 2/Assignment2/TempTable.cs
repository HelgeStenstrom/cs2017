// Helge Stenström
// 2017-09-08
// Programmering med C#

using System;

namespace Assignment2
{
  class TempTable : Startable
  {
    public void Start()
    {
      SelectionBanner();
      ChoiceDialog();
      Console.WriteLine("You selected " + choice);
      PrintTable(choice);
    }

    private string choice;
    private string fromUnit;
    private string toUnit;

    private void SelectionBanner()
    {
      Console.WriteLine();
      Console.WriteLine("Select conversion type:");
      Console.WriteLine("fc:  Celsius -> Fahrenheit");
      Console.WriteLine("cf:  Fahrenheit -> Celsius");
    }

    private void ChoiceDialog()
    {
      while (true)
      {
        Console.Write("Your choice: ");
        string yourchoice = Console.ReadLine();
        if ((yourchoice == "cf" )|| (yourchoice == "fc"))
        {
          choice =  yourchoice;
          break;
        }
        else
          Console.WriteLine("Wrong choice, try again!");
      }
    }

    private void PrintTable(string choice)
    {
      Console.WriteLine("??? Printing a table");
      TableHeader();
      Table();
    }

    private void TableHeader()
    {
      Console.Clear();
      Console.WriteLine("   Temperature Table");
      Console.WriteLine("");
      switch (choice)
      {
        case "fc":
          Console.WriteLine("Changing Fahrenheit (F) to Celsius (C)");
          fromUnit = "°F";
          toUnit = "°C";
          break;

        case "cf":
          Console.WriteLine("Changing Celsius (C) to Fahrenheit (F)");
          fromUnit = "°C";
          toUnit = "°F";
          break;

        default:
          Console.WriteLine("This can't happen!");
          //Assert(false);
          break;
      }
      Console.WriteLine("--------------------------------------");
      Console.WriteLine();
    }

    private void Table()
    {
      for (double temp = 0.0; temp <= 100; temp += 4.0)
      {
        double converted;
        switch (choice)
        {
          case "cf":
            converted = toF(temp);
            break;
          default:
            converted = toC(temp);
            break;
        }
        Console.WriteLine("    {0,5} {1} = {2,6:F2} {3}", 
                          temp, fromUnit, converted, toUnit);
        // See https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting
      }      
    }

    private double toC(double f)
    {
      return 5.0 / 9.0 * (f - 32.0);
    }

    private double toF (double c)
    {
      return 9.0 / 5.0 * c + 32.0;
    }

  }

}