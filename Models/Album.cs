using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Album
  {
    public string Title { get; set; }
    public string TrackTotals { get; set; }
    public string RunTime { get; set; }
    public int Id { get; }
    private static List<Album> _instances = new List<Album> {};

    public Album(string title, string trackTotals, string runTime)
    {
      Title = title;
      _instances.Add(this);
      Id = _instances.Count;
      TrackTotals = trackTotals;
      RunTime = runTime;
    }

    public static List<Album> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Album Find(int searchId)
    {
      return _instances[searchId -1];
    }
  }
}
