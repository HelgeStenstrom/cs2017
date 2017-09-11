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
    // Define the text that appears topmost in the main program.
    {
      string header = "                MAIN MENU                         \n";
      return aline+header+aline;
    }

    private void PrintBanner()
    {
      Console.Write(Banner());
    }

    private void Cycle()
    // Main UI loop. Repeat until exit is selected by "0" 
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
    // Format the menu items with a bit of prepending whitespace.
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
    // Return the selection code of the subprogram that the user has chosen.
    {
      Console.Write("Your choice: ");
      return Console.ReadLine();
    }

    private void RunChoice(string choice)
    {
      Startable subprogram = new NullAction(); // This subprograms does nothing.

      switch (choice)
      {
        case "0":
          Console.WriteLine("This can't happen!");
          // Can't happen because we will not call the 
          // method if choice == 0.
          break;

        case "1":
          subprogram = new WholeNumbersForAdd();
          break;

        case "2":
          subprogram = new FloatingPointsNumberWhileAdd();
          break;

        case "3":
          subprogram = new CurrencyConverter();
          break;

        case "4":
          subprogram = new WorkingSchedule();
          break;

        case "5":
          subprogram = new TempTable();
          break;

        default:
          Console.WriteLine("Invalid choice");
          break;
      }
      subprogram.Start();
    } // RunChoice
  } // class Menu
} // namespace
