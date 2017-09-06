using System;
using System.Collections.Generic;

namespace AlbumProgram
{
  public class Album
  {
    string artist;
    List<string> trackNames = new List<string>();
    int trackCount = 0;
    int year;
    DateTime addDate;

    public void start()
    {
      Console.Clear();
      Console.WriteLine("----- Welcome to the album program  ------");
      readAndSave();
      displayAlbum();
      Console.WriteLine("----- Welcome back another time ----------");
    }

    private void readAndSave()
    {
      artist = askArtist();
      year = askYear();
      getTracks();
      addDate = getAddDate();
    }

    private string askArtist()
    {
      Console.Write("Who is the artist? ");
      return Console.ReadLine();
    }

    private int askTrackCount()
    {
      Console.Write("How many tracks? ");
      return int.Parse(Console.ReadLine());
    }

    private string askTrack()
    {
      Console.WriteLine("Enter a track name, or Enter to quit: ");
      return Console.ReadLine();
    }

    private void getTracks()
    {
      while (true)
      {
        string response = askTrack();
        if (response == "")
          break;
        else
          {
            trackNames.Add(response);
            trackCount += 1;
          }
      }
    }

    private int askYear()
    {
      Console.Write("When was it released? ");
      return int.Parse(Console.ReadLine());
    }

    private DateTime getAddDate()
    {
      DateTime now = DateTime.Now;
      return now;
    }

    private void displayTracks()
    {
      foreach (var track in trackNames)
      {
        Console.WriteLine("  " + track);
      }
    }

    private void displayAlbum()
    {
      Console.WriteLine();
      Console.WriteLine("=========================");
      Console.WriteLine("Artist: " + artist);
      Console.WriteLine("Release year: " + year);
      Console.WriteLine("Number of tracks: " + trackCount);
      displayTracks();
      Console.WriteLine("Added to collection: " + addDate);
      Console.WriteLine("=========================");
      Console.WriteLine();

    }
  }
}
