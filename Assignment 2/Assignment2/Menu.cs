using System;

namespace Assignment2
{
  class Menu
  {
    private static string aline = "--------------------------------------------------\n";
    public void Start()
    {
      Console.Clear();
      //PrintBanner();
      Cycle();
      //PrintChoices();
      //RunChoice();
      Console.WriteLine();
      //Console.ReadLine();

    }

    private string Banner ()
    {
      //string line   = "--------------------------------------------------\n";
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

      bool exit = false;
      switch (choice)
      {
        case "0":
          exit = true;
          break;
        case "1":
          Console.WriteLine("Running Whole Numbers");
            //WholeNumbersForAdd subProgram = new WholeNumbersForAdd();
            // subProgram.Start();
          break;
        case "2":
          Console.WriteLine("Running Floating Point");
          break;
        case "3":
          Console.WriteLine("Running Currency Converter");
          break;
        case "4":
          Console.WriteLine("Running Work Schedule");
          break;
        default:
          Console.WriteLine("Invalid choice");
          break;
      }
    }

  }
}