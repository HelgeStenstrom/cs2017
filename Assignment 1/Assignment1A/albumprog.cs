using System;

namespace AlbumProgram
{ 
  class AlbumMain
  {
    static void Main(string[] arguments)
    {
      Console.WriteLine("Welcome to the Album program.");

      Album album = new Album();
      album.start();

      Console.WriteLine();
      Console.WriteLine("Press Enter to exit.");
      Console.ReadLine();
    }
  }
}
