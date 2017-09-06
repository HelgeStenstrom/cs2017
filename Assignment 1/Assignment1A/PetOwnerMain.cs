// Author: Helge Stenström
// Date: 2016-09-06
// petownermain.cs, part of Assignment1A


using System;

namespace PetApplication
{
  class PetOwnerMain
  {

    static void setTerminalStyle()
    {
      Console.BackgroundColor = ConsoleColor.Gray;
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.Title = "Husdjursägare";
    }

    static void Main(string[] args)
    {
      Pet pet = new Pet();
      pet.start();
      Console.WriteLine("Press Enter to exit!");
      Console.ReadLine();
    }
  }
}
