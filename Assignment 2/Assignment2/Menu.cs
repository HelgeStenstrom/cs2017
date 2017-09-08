using System;

namespace Assignment2
{
  class Menu
  {
    private static string aline = "--------------------------------------------------\n";
    public void Start()
    {
      Console.Clear();
      Cycle();
      Console.WriteLine();
      //Console.ReadLine();

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

      switch (choice)
      {
        case "0":
          Console.WriteLine("This can't happen!");
          break;
        case "1":
          //Console.WriteLine("Running Whole Numbers");
          WholeNumbersForAdd wnfa = new WholeNumbersForAdd();
          wnfa.Start();
          break;
        case "2":
          //Console.WriteLine("Running Floating Point");
          FloatingPointsNumberWhileAdd fpnwa = new FloatingPointsNumberWhileAdd();
          fpnwa.Start();
          break;
        case "3":
          //Console.WriteLine("Running Currency Converter");
          CurrencyConverter cc = new CurrencyConverter();
          cc.Start();
          break;
        case "4":
          //Console.WriteLine("Running Work Schedule");
          WorkingSchedule ws = new WorkingSchedule();
          ws.Start();
          break;
        case "5":
          Console.WriteLine("temperature table");
          break;
        default:
          Console.WriteLine("Invalid choice");
          break;
      }
    }

  }
}