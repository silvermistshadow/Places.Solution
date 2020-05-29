using Microsoft.VisualStudio.TestTools.UnitTesting;
using Places.Models;
using System;
using System.Collections.Generic;

namespace PlacesTests
{
    [TestClass]
    public class PlaceTests : IDisposable
    {
        public void Dispose()
        {
            Place.ClearAll();
        }
        [TestMethod]
        public void PlaceConstructor_CreatesInstanceOfPlace_Place()
        {
            Place newPlace = new Place("test");
            Assert.AreEqual(typeof(Place), newPlace.GetType());
        }
        [TestMethod]
        public void PlaceConstructor2_CreatesInstanceOfPlace_Place()
        {
            Place newPlace = new Place("test", "1 day", "Test test test");
            Assert.AreEqual(typeof(Place), newPlace.GetType());
        }
    }
}