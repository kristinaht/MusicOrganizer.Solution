using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;
using MySql.Data.MySqlClient;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class AlbumTest : IDisposable
  {
    public void Dispose()
    {
      Album.ClearAll();
    }
    public AlbumTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=music_organizer_test;";
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyListFromDatabase_AlbumList()
    {
      //Arrange
      List<Album> newList = new List<Album> { };

      //Act
      List<Album> result = Album.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Equals_ReturnTrueIfDescriptionsAreTheSame_Item()
    {
      Album firstAlbum = new Album("title", "something", "shth");
       Album secondAlbum = new Album("title", "something", "shth");

       Assert.AreEqual(firstAlbum, secondAlbum);

    }
  }
}