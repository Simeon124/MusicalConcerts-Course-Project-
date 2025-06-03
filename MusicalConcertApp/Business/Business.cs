using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;

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

        public static List<Concert> GetUserConcertsById(int id)
        {
            using (MusicalConcertAppDbContext dbc = new MusicalConcertAppDbContext())
            {
                var user = dbc.UserConcerts.Include(uc => uc.Concerts).FirstOrDefault(x => x.Id == id);
                return user.Concerts.ToList();
            }
        }

    }
}
