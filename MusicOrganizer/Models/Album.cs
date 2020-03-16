using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MusicOrganizer.Models
{
  public class Album
  {
    public string Title { get; set; }
    public string TrackTotals { get; set; }
    public string RunTime { get; set; }
    public int Id { get; set; }
    private static List<Album> _instances = new List<Album> {};

    
    public Album(string title, string trackTotals, string runTime)
    {
      Title = title;
      TrackTotals = trackTotals;
      RunTime = runTime;
    }
    public Album(string title, string trackTotals, string runTime, int id)
    {
      Title = title;
      TrackTotals = trackTotals;
      RunTime = runTime;
      Id = id;
    }


    public static List<Album> GetAll()
    {
      List<Album> allAlbums = new List<Album> { };
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM albums;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while (rdr.Read())
      {
        int albumId = rdr.GetInt32(0);
        string albumTitle = rdr.GetString(1);
        string albumTrackTotals = rdr.GetString(2);
        string albumRunTime = rdr.GetString(3);
        Album newAlbum = new Album(albumTitle, albumTrackTotals, albumRunTime, albumId);
        allAlbums.Add(newAlbum);
      }
      conn.Close();
      if (conn != null)
      {
          conn.Dispose();
      }
      return allAlbums;
    }

    public static void ClearAll()
    {     
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM albums;";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }
        public static Album Find(int searchId)
    {
      Album placeholderAlbum = new Album("placeholder album", "sdfsd", "fdsfsdf");
      return placeholderAlbum;
    }
  }
 }

