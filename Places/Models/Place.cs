using System.Collections.Generic;

namespace Places.Models
{
    public class Place
    {
        public string CityName { get; set; }
        public int Id { get; }
        public string StayLength { get; set; }
        public string JournalEntry { get; set; }
        private static List<Place> _instances = new List<Place>();

        public Place(string cityName)
        {
            CityName = cityName;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public Place(string cityName, string stayLength, string journalEntry)
        {
            CityName = cityName;
            StayLength = stayLength;
            JournalEntry = journalEntry;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Place> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
        public static Place Find(int searchId)
        {
            return _instances[searchId-1];
        }

    }
}