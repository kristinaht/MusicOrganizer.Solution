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

    public override bool Equals(System.Object otherAlbum)
    { 
      if(!(otherAlbum is Album))
      {
        return false;
      }
      Album newAlbum = (Album) otherAlbum;
      bool idEquality = (this.Id == newAlbum.Id);
      bool titleEquality = (this.Title == newAlbum.Title);
      bool trackTotalsEquality = (this.TrackTotals == newAlbum.TrackTotals);
      bool runTimeEquality = (this.RunTime == newAlbum.RunTime);
      return (titleEquality && trackTotalsEquality && runTimeEquality && idEquality);
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;

      cmd.CommandText = @"INSERT INTO albums (title, track_totals, run_time) VALUES (@AlbumTitle, @AlbumTrackTotals, @AlbumRunTime);";
      MySqlParameter title = new MySqlParameter();
      title.ParameterName = "@AlbumTitle";
      title.Value = this.Title;
      MySqlParameter trackTotals = new MySqlParameter();
      trackTotals.ParameterName = "@AlbumTrackTotals";
      trackTotals.Value = this.TrackTotals;
      MySqlParameter runTime = new MySqlParameter();
      runTime.ParameterName = "@AlbumRunTime";
      runTime.Value = this.RunTime;

      cmd.Parameters.Add(title);
      cmd.Parameters.Add(trackTotals);
      cmd.Parameters.Add(runTime);
      cmd.ExecuteNonQuery();
      Id = (int) cmd.LastInsertedId;

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
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

