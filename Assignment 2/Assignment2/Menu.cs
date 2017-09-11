// Helge Stenström
// 2017-09-08
// Programmering med C#


using System;

namespace Assignment2
{
  class Menu : Startable
  {
    private static string aline = "--------------------------------------------------\n";
    public void Start()
    {
      Console.Clear();
      Cycle();
      Console.WriteLine();
      //Console.ReadLine();
      // On my Mac, having the above ReadLine() active is only irritating.

    }

    private string Banner ()
    {
      string header = "                MAIN MENU                         \n";
      return aline+header+aline;
    }

    private void PrintBanner()
    {
      Console.Write(Banner());
    }

    private void Cycle()
    {
      while (true)
      {
        PrintChoices();
        string choice = GetChoice();
        if (choice == "0")
          break;
        else
          RunChoice(choice);
      }

    }

    private string MenuItem (string text)
    {
      return "   " + text;
    }

    private void PC (string text)
    // This function with a short name makes 
    // the code lines in PrintChoices shorter.
    // PC is for Print Choice.
    {
      Console.WriteLine(MenuItem(text));
    }


    private void PrintChoices ()
    {
      PrintBanner();
      PC("Whole Numbers with For                : 1");
      PC("Floating Point Numbers with While     : 2");
      PC("Currency Converter with Do While loop : 3");
      PC("Work Schedule                         : 4");
      PC("Temperature Table                     : 5");
      PC("Exit the program                      : 0");
      Console.Write(aline);
    }

    private string GetChoice()
    {
      Console.Write("Your choice: ");
      return Console.ReadLine();
    }

    private void RunChoice(string choice)
    {
      Startable action = new NullAction(); // This actions does nothing.
      // TODO: Find a better name than "action"

      switch (choice)
      // objects created here have names that are abbreviations of class names.
      {
        case "0":
          Console.WriteLine("This can't happen!");
          // Can't happen because we will not call the 
          // method if choice == 0.
          break;

        case "1":
          action = new WholeNumbersForAdd();
          break;

        case "2":
          action = new FloatingPointsNumberWhileAdd();
          break;

        case "3":
          action = new CurrencyConverter();
          break;

        case "4":
          action = new WorkingSchedule();
          break;

        case "5":
          action = new TempTable();
          break;

        default:
          Console.WriteLine("Invalid choice");
          break;
      }
      action.Start();
    }

  }
}