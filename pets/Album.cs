using System;

namespace AlbumProgram
{
  public class Album
  {
    string artist;
    int trackCount;
    int year;
    DateTime addDate;

    public void start()
    {
      Console.WriteLine("----- Album program started ------");

      readAndSave();
      displayAlbum();

      Console.WriteLine("-----------------------------------");
    }

    private void readAndSave()
    {
      artist = askArtist();
      trackCount =  askTrackCount();
      year = askYear();
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

    private void displayAlbum()
    {
      Console.WriteLine("Artist: " + artist);
      Console.WriteLine("Number of tracks: " + trackCount);
      Console.WriteLine("Release year: " + year);
      Console.WriteLine("Added to collection: " + addDate);

    }
  }
}
