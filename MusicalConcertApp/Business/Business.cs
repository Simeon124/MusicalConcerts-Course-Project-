using Data;
using Data.Models;

namespace Business
{
    public static class Business
    {
        public static void Main()
        {

        }

        public static List<Concert> Concerts { get; set; } = new List<Concert>();

        public static List<Concert> GetConcerts()
        {
            using (MusicalConcertAppDbContext dbc = new MusicalConcertAppDbContext())
            {
                Concerts = dbc.Concerts.ToList();
                return Concerts;
            }
        }

    }
}
