

namespace Places.Models
{
    class Place
    {
        string CityName { get; set; }

        public Place(string cityName)
        {
            CityName = cityName;
        }
    }
}