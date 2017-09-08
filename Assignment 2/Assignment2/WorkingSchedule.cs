using System;

namespace Assignment2
{
  class WorkingSchedule
  {
    public void Start()
    {
      //Console.WriteLine("Assignment2 called");
      Banner();
      SelectAndRun();
    }

    private void Banner()
    {
      Console.WriteLine("                     YOUR SCHEDULE PROGRAM");
      Console.WriteLine("Select from the menu which type of schedule you want to see.");
      Console.WriteLine("------------------------------------------------------------");
      Console.WriteLine();
    }

    private void SelectAndRun()
    {
      while (true)
      // This type of loop allows me to break out of the loop 
      // before the action would take place. I need to have the 
      // test in the middle. At least it seems to be the simplest 
      // solution.
      {
        int choice = GetChoice();
        // Console.WriteLine("You choose {0}.", choice);
        if (choice == 0) break;
        RunChoice(choice);
      }
    }

    private void PrintChoices ()
    {
      Console.WriteLine(" 1 Show a list of the weekends to work");
      Console.WriteLine(" 2 Show a list of the nights to work");
      Console.WriteLine(" 0 Return to main menu");
      Console.WriteLine();
    }

    private int GetChoice()
    {
      PrintChoices();
      Console.Write("Your choice: ");
      return int.Parse(Console.ReadLine());
    }

    private void RunChoice(int choice)
    {
      Console.WriteLine();
      switch (choice)
      {
        case 1:
          Console.WriteLine("weekends to work");
          Weekends();
          break;
        case 2:
          Console.WriteLine("nights to work");
          Nights();
          break;
        default:
          Console.WriteLine("Invalid choice, try again!");
          break;
      }
    }

    private void Weekends()
    {}

    private void Nights()
    {}

  }
}
